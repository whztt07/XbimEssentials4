using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xbim.IO.Esent;

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
            using (var model = new EsentModel())
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

            using (var model = new EsentModel())
            {
                watch.Start();
                model.Open(dbName);
                var project = model.IfcProject;
                watch.Stop();
                Debug.WriteLine("It took {0}ms to open the DB.", watch.ElapsedMilliseconds);

                Assert.IsNotNull(project);
                Assert.IsNotNull(project.Name);
            }

        }
    }
}
