using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xbim.Ifc2x3;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.SharedBldgElements;
using Xbim.IO.Memory;

namespace Xbim.IO.ParserTests
{
    [TestClass]
    [DeploymentItem("TestFiles")]
    public class LoadingIfc2x3
    {
        [TestMethod]
        public void LoadingTest()
        {
            var model = new MemoryModel<EntityFactory>();
            model.Open("SampleHouse.ifc");

            var project = model.Instances.OfType<IfcProject>().FirstOrDefault();
            Assert.IsNotNull(project);
            Assert.IsNotNull(project.Name);

            var walls = model.Instances.OfType<IfcWall>();
            var wallsCount = walls.Count();
            Assert.AreEqual(5, wallsCount);
        }
    }
}
