using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
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
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Properties.Settings.Default.LastInput = TxtInputFile.Text;
            Properties.Settings.Default.LastOutput = TxtOutputFile.Text;
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

        ////this is the base - all products, controls, resources, processes, actors
        //toInsert.AddRange(source.Instances.OfType<IfcProduct>());

        ////object types and properties for all products
        //toInsert.AddRange(source.Instances.OfType<IfcRelDefines>());
        //
        ////spatial containment and references
        //toInsert.AddRange(source.Instances.OfType<IfcRelContainedInSpatialStructure>());
        //toInsert.AddRange(source.Instances.OfType<IfcRelReferencedInSpatialStructure>());
        //
        ////aggregations will bring in all spatial decompositions and product decompositions (if elements is a aggregation of several elements)
        //toInsert.AddRange(source.Instances.OfType<IfcRelAggregates>());
        //
        ////assignmnet to groups will bring in all system aggregarions if defined in the file
        //toInsert.AddRange(source.Instances.OfType<IfcRelAssignsToGroup>());
        //
        ////associations with classification, material and documents
        //toInsert.AddRange(source.Instances.OfType<IfcRelAssociatesClassification>());
        //toInsert.AddRange(source.Instances.OfType<IfcRelAssociatesMaterial>());
        //toInsert.AddRange(source.Instances.OfType<IfcRelAssociatesDocument>());

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
                        var toInsert =  source.Instances.OfType<IfcRoot>();
                        var cache = new Dictionary<int, IPersistEntity>();

                        //set to happen out of transaction. This should save some memory used by transaction log
                        foreach (var entity in toInsert)
                            target.InsertCopy(entity, cache, false, true, GeometryFilter, true);

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


            MessageBox.Show(this, msg);
            Close();
        }

        private static object GeometryFilter(ExpressMetaProperty property, object parentObject)
        {
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
