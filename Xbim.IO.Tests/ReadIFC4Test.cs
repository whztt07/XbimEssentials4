using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xbim.Ifc4;
using Xbim.Ifc4.GeometricModelResource;
using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.SharedBldgElements;
using Xbim.IO.Memory;

namespace Xbim.MemoryModel.Tests
{
    [TestClass]
    [DeploymentItem("TestFiles")]
    public class ReadIfc4Test
    {
        [TestMethod]
        public void LoadIfc4Test()
        {
            var model = new MemoryModel<EntityFactory>();
            model.Open("SampleHouse4.ifc");

            var project = model.Instances.FirstOrDefault<IfcProject>();
            Assert.IsNotNull(project);
            Assert.IsNotNull(project.Name);

            var walls = model.Instances.OfType<IfcWall>();
            var doors = model.Instances.OfType<IfcDoor>();
            Assert.IsTrue(walls.Any());
            Assert.IsTrue(doors.Any());
        }

        [TestMethod]
        public void IfcCartesianPointList3DTest()
        {
            var model = new MemoryModel<EntityFactory>();
            model.Open("IfcCartesianPointList3D.ifc");
            var pl = model.Instances.FirstOrDefault<IfcCartesianPointList3D>();
            Assert.IsNotNull(pl);
        }
    }
}
