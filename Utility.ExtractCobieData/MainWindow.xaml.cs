using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;
using Xbim.Common;
using Xbim.Common.Metadata;
using Xbim.Ifc2x3;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.ProductExtension;
using Xbim.IO.Memory;

namespace Utility.ExtractCobieData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public override void EndInit()
        {
            base.EndInit();

            //set last paths
            TxtInputFile.Text = Properties.Settings.Default.LastInput;
            TxtOutputFile.Text = Properties.Settings.Default.LastOutput;
            TxtGuidFilter.Text = Properties.Settings.Default.GuidFilter;
            CheckBoxIncludeGeometry.IsChecked = Properties.Settings.Default.IncludeGeometry;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            //save settings
            Properties.Settings.Default.LastInput = TxtInputFile.Text;
            Properties.Settings.Default.LastOutput = TxtOutputFile.Text;
            Properties.Settings.Default.GuidFilter = TxtGuidFilter.Text;
            Properties.Settings.Default.IncludeGeometry = CheckBoxIncludeGeometry.IsChecked == true;
            Properties.Settings.Default.Save();

            base.OnClosing(e);
        }

        private void TxtOutputFile_OnGotFocus(object sender, RoutedEventArgs e)
        {
            var dlg = new SaveFileDialog
            {
                Title = "Select output IFC2x3 file",
                AddExtension = true,
                DefaultExt = ".ifc", 
                Filter = "IFC2x3 files (*.ifc)|*.ifc"
            };
            if (dlg.ShowDialog(this) == true)
                TxtOutputFile.Text = dlg.FileName;
        }

        private void TxtInputFile_OnGotFocus(object sender, RoutedEventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "IFC2x3 files (*.ifc)|*.ifc",
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                Title = "Select input IFC2x3 file"
            };
            if (dlg.ShowDialog(this) == true)
                TxtInputFile.Text = dlg.FileName;
        }


        

        private void BtnRun_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtInputFile.Text) ||
                string.IsNullOrWhiteSpace(TxtOutputFile.Text))
            {
                MessageBox.Show("You have to specify input and output file.");
                return;
            }

            Cursor = Cursors.Wait;
            var w = Stopwatch.StartNew();
            long originalCount;
            long resultCount;
            using (var source = new MemoryModel<EntityFactory>())
            {
                source.Open(TxtInputFile.Text);
                using (var target = new MemoryModel<EntityFactory>())
                {
                    //insertion itself will be configured to happen out of transaction but other operations might need to be transactional
                    using (var txn = target.BeginTransaction("COBie data extraction"))
                    {
                        var toInsert = GetEntitiesToInsert(source);
                        var cache = new Dictionary<int, IPersistEntity>();

                        //set to happen out of transaction. This should save some memory used by transaction log
                        foreach (var entity in toInsert)
                            target.InsertCopy(entity, cache, false, true, Filter, true);

                        txn.Commit();
                    }

                    target.Save(TxtOutputFile.Text);
                    originalCount = source.Instances.Count;
                    resultCount = target.Instances.Count;
                }
            }
            Cursor = Cursors.Arrow;
            w.Stop();

            var originalSize = new FileInfo(TxtInputFile.Text).Length;
            var cobieSize = new FileInfo(TxtOutputFile.Text).Length;
            var processingTime = w.ElapsedMilliseconds;
            var msg = string.Format("COBie content extracted in {0}s \n" +
                                    "Original size: {1:n0}B \n" +
                                    "Resulting size: {2:n0}B \n" +
                                    "Number of objects in original: {3:n0} \n" +
                                    "Number of objects in result: {4:n0}", 
                processingTime/1000, 
                originalSize, 
                cobieSize,
                originalCount,
                resultCount);

            //clear primary elements
            _primaryElements = null;

            MessageBox.Show(this, msg);
            Close();
        }

        private IEnumerable<IPersistEntity> GetEntitiesToInsert(IModel model)
        {
            var guids = TxtGuidFilter.Text;
            if (string.IsNullOrWhiteSpace(guids))
                return model.Instances.OfType<IfcRoot>();

            var ids =
                guids.Split(new char[] {',', ' ', ';'}, StringSplitOptions.RemoveEmptyEntries).Select(g => g.Trim());

            //root elements specified by GUID
            var roots = model.Instances.Where<IfcRoot>(r => ids.Contains(r.GlobalId.ToString())).Cast<IPersistEntity>().ToList();
            _primaryElements = roots.OfType<IfcProduct>().ToList();

            //we should add spatial hierarchy right here so it brings its attributes as well
            var spatialRels = model.Instances.Where<IfcRelContainedInSpatialStructure>(
                r => _primaryElements.Any(e => r.RelatedElements.Contains(e)));
            var spatialRefs =
                model.Instances.Where<IfcRelReferencedInSpatialStructure>(
                    r => _primaryElements.Any(e => r.RelatedElements.Contains(e)));

            var structures =
                spatialRels.Select(r => r.RelatingStructure).Union(spatialRefs.Select(r => r.RelatingStructure));
            var spatialHierarchy = GetUpstreamHierarchy(structures, model);
            _primaryElements.AddRange(spatialHierarchy);

            //object types and properties for all primary products (elements and spatial elements)
            roots.AddRange(model.Instances.Where<IfcRelDefines>( r => _primaryElements.Any(e => r.RelatedObjects.Contains(e))));
            
            //spatial containment and references
            roots.AddRange(spatialRels);
            roots.AddRange(spatialRefs);
            
            //aggregations will bring in all spatial decompositions and product decompositions (if elements is a aggregation of several elements)
            roots.AddRange(model.Instances.Where<IfcRelAggregates>(r => _primaryElements.Contains(r.RelatingObject) 
                || _primaryElements.Any(p => r.RelatedObjects.Contains(p))));
            
            //assignmnet to groups will bring in all system aggregarions if defined in the file
            roots.AddRange(model.Instances.Where<IfcRelAssigns>(r => _primaryElements.Any(e => r.RelatedObjects.Contains(e))));
            
            //associations with classification, material and documents
            roots.AddRange(model.Instances.Where<IfcRelAssociates>(r => _primaryElements.Any(e => r.RelatedObjects.Contains(e))));

            return roots;
        }

        private IEnumerable<IfcProduct> GetUpstreamHierarchy(
            IEnumerable<IfcSpatialStructureElement> spatialStructureElements, IModel model)
        {
            var elements = spatialStructureElements.ToList();
            if(!elements.Any())
                yield break;

            foreach (var element in elements)
            {
                yield return element;
            }

            var decomposing =
                model.Instances.Where<IfcRelAggregates>(
                    r => elements.Any(s => r.RelatedObjects.Contains(s)))
                    .Select(r => r.RelatingObject)
                    .OfType<IfcSpatialStructureElement>();
            foreach (var product in GetUpstreamHierarchy(decomposing, model))
            {
                yield return product;
            }
        }

        private List<IfcProduct> _primaryElements; 

        private object Filter(ExpressMetaProperty property, object parentObject)
        {
            if (_primaryElements != null && _primaryElements.Any())
            {
                if (typeof(IfcProduct).IsAssignableFrom(property.PropertyInfo.PropertyType))
                {
                    var element = property.PropertyInfo.GetValue(parentObject, null) as IfcProduct;
                    if (element != null && _primaryElements.Contains(element))
                        return element;
                    return null;
                }
                if (typeof(IEnumerable<IPersistEntity>).IsAssignableFrom(property.PropertyInfo.PropertyType))
                {
                    var entities = property.PropertyInfo.GetValue(parentObject, null) as IEnumerable<IPersistEntity>;
                    if (entities == null)
                        return null;
                    var elementsToRemove = entities.OfType<IfcProduct>().Where(e => !_primaryElements.Contains(e)).ToList();
                    //if there are no IfcElements return what is in there with no care
                    if (elementsToRemove.Any())
                        //return original values excluding elements not included in the primary set
                        return entities.Except(elementsToRemove).ToList();
                }
            }
                


            //if geometry is to be included don't filter it out
            if (CheckBoxIncludeGeometry.IsChecked == true)
                return property.PropertyInfo.GetValue(parentObject, null);

            //leave out geometry and placement of products
            if (parentObject is IfcProduct && 
                (property.PropertyInfo.Name == "Representation" || property.PropertyInfo.Name == "ObjectPlacement")
                )
                return null;

            //leave out representation maps
            if (parentObject is IfcTypeProduct && property.PropertyInfo.Name == "RepresentationMaps")
                return null;

            //leave out eventual connection geometry
            if (parentObject is IfcRelSpaceBoundary && property.PropertyInfo.Name == "ConnectionGeometry")
                return null;

            //return the value for anything else
            return property.PropertyInfo.GetValue(parentObject, null);
        }
    }
}
