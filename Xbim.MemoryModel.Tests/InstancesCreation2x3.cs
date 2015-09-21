using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xbim.Common;
using Xbim.Ifc2x3;
using Xbim.Ifc2x3.ActorResource;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.PropertyResource;
using Xbim.Ifc2x3.SharedBldgElements;
using Xbim.IO.Memory;

namespace Xbim.MemoryModel.Tests
{
    [TestClass]
    public class InstancesCreation2X3
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
                var rels = wall.IsDefinedBy.OfType<IfcRelDefinesByProperties>();
                Assert.AreEqual(1, rels.Count());
                Assert.IsTrue(wall.Name == "Sample wall");


                //Optional item set test.
                var organization = model.Instances.New<IfcOrganization>();
                Assert.IsTrue(null == organization.Roles);
                Assert.IsTrue(organization.Roles.Equals(null));

                Assert.IsTrue(null == (organization.Roles as ItemSet<IfcActorRole>));
                Assert.IsTrue((organization.Roles as IItemSet<IfcActorRole>).Equals(null));

                if(organization.Roles == null) 
                    organization.Roles.Initialize();
                
                Assert.IsFalse(null == organization.Roles);
                Assert.IsFalse(organization.Roles.Equals(null));

                //it is possible to add an object to the set without initialization or any previous assignment
                organization.Roles.Add(model.Instances.New<IfcActorRole>());

                

                txn.Commit();
            }
        }
    }

   
}