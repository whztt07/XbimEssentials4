using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xbim.Ifc2x3;
using Xbim.Ifc2x3.IO;
using Xbim.Ifc2x3.Kernel;
using Xbim.IO.Memory;

namespace Xbim.IO.ParserTests
{
    [TestClass]
    [DeploymentItem("TestFiles")]
    public class XbimDBTests
    {
        [TestMethod]
        public void CreateModelFromIfc()
        {
            var dbName = "test.xbim";
            var watch = new Stopwatch();
            using (var model = new XbimModel())
            {
                watch.Start();
                model.CreateFrom("SampleHouse.ifc", dbName, null, true);
                watch.Stop();
                Debug.WriteLine("It took {0}ms to convert the file into DB.", watch.ElapsedMilliseconds);

                var project = model.IfcProject;
                Assert.IsNotNull(project);
                Assert.IsNotNull(project.Name);
                model.Close();    
            }

            using (var model = new XbimModel())
            {
                watch.Start();
                model.Open(dbName);
                var project = model.IfcProject;
                watch.Stop();
                Debug.WriteLine("It took {0}ms to open the DB.", watch.ElapsedMilliseconds);

                Assert.IsNotNull(project);
                Assert.IsNotNull(project.Name);
            }

            using (var model = new MemoryModel<EntityFactory>())
            {
                watch.Start();
                model.Open("SampleHouse.ifc");
                watch.Stop();
                Debug.WriteLine("It took {0}ms to open IFC in memory.", watch.ElapsedMilliseconds);

                var project = model.Instances.FirstOrDefault<IfcProject>();
                Assert.IsNotNull(project);
                Assert.IsNotNull(project.Name);
            }

        }
    }
}
