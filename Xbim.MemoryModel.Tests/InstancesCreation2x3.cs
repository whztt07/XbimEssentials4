using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xbim.Ifc2x3;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.PropertyResource;
using Xbim.Ifc2x3.SharedBldgElements;

namespace Xbim.MemoryModel.Tests
{
    [TestClass]
    public class InstancesCreation2X3
    {
        [TestMethod]
        public void BasicInstances()
        {
            var model = new Model<EntityFactory>();
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

                var rels = wall.IsDefinedBy.OfType<IfcRelDefinesByProperties>();
                Assert.AreEqual(1, rels.Count());
                Assert.IsTrue(wall.Name == "Sample wall");

                txn.Commit();
            }
        }
    }

   
}