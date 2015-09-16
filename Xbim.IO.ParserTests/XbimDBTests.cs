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
                model.Close();    
            }

            using (var model = new XbimModel())
            {
                model.Open(dbName);
                var project = model.IfcProject;
                Debug.WriteLine(project.Name ?? "No project name defined.");
            }

        }
    }
}
