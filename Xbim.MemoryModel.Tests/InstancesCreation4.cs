using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xbim.Ifc4;
using Xbim.Ifc4.SharedBldgElements;
using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.PropertyResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.IO.Memory;

namespace Xbim.MemoryModel.Tests
{
    [TestClass]
    public class InstancesCreation4
    {
        [TestMethod]
        public void BasicInstances()
        {
            var model = new MemoryModel<EntityFactory>();
            using (var txn = model.BeginTransaction("Example"))
            {
                var wall = model.Instances.New<IfcWall>(w =>
                {
                    w.Name = "Sample wall";
                    w.Description = "Some description";
                });

                var pset = model.Instances.New<IfcPropertySet>(p =>
                {
                    p.Name = "Very first property set.";
                    p.HasProperties.Add(model.Instances.New<IfcPropertySingleValue>(v =>
                    {
                        v.Name = "Property name";
                        v.NominalValue = new IfcLabel("Value of the first property");
                    })
                        );
                });

                model.Instances.New<IfcRelDefinesByProperties>(r =>
                {
                    r.RelatedObjects.Add(wall);
                    r.RelatingPropertyDefinition = pset;
                });

                var rels = wall.IsDefinedBy.FirstOrDefault();
                Assert.IsTrue(rels != null);
                Assert.IsTrue(wall.Name == "Sample wall");

                txn.Commit();
            }
        }
    }
}