using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            using (var model = new XbimModel())
            {
                model.CreateFrom("SampleHouse.ifc", dbName, null, true);
                var project = model.IfcProject;
                Assert.IsNotNull(project);
                Assert.IsNotNull(project.Name);
                model.Close();    
            }

            using (var model = new XbimModel())
            {
                model.Open(dbName);
                var project = model.IfcProject;
                Assert.IsNotNull(project);
                Assert.IsNotNull(project.Name);
            }

        }
    }
}
