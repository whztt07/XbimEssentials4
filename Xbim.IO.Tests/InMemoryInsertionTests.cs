﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xbim.Common;
using Xbim.Ifc4;
using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.SharedBldgElements;
using Xbim.IO.Memory;

namespace Xbim.MemoryModel.Tests
{
    [TestClass]
    public class InMemoryInsertionTests
    {
        [DeploymentItem("TestFiles")]
        [TestMethod]
        public void CopyWallsOver()
        {
            using (var model = new MemoryModel<EntityFactory>())
            {
                model.Open("SampleHouse4.ifc");
                var walls = model.Instances.OfType<IfcWall>().ToList();
                using (var iModel = new MemoryModel<EntityFactory>())
                {
                    using (var txn = iModel.BeginTransaction("Insert copy"))
                    {
                        var w = new Stopwatch();
                        w.Start();
                        var mappings = new Dictionary<int, IPersistEntity>();
                        foreach (var wall in walls)
                        {
                            iModel.InsertCopy(wall, mappings, true, true, (property, parentObject) =>
                            {
                                //left out geometry and placement
                                if ((property.PropertyInfo.Name == "Representation" || property.PropertyInfo.Name == "ObjectPlacement") &&
                                    parentObject is IfcProduct)
                                    return null;

                                //only bring over IsDefinedBy and IsTypedBy inverse relationships
                                if (property.EntityAttribute.Order < 0 && !(
                                    property.PropertyInfo.Name == "IsDefinedBy" ||
                                    property.PropertyInfo.Name == "IsTypedBy"
                                    ))
                                    return null;

                                return property.PropertyInfo.GetValue(parentObject, null);
                            });
                        }
                        txn.Commit();
                        w.Stop();

                        var iWalls = iModel.Instances.OfType<IfcWall>().ToList();
                        Assert.IsTrue(walls.Count == iWalls.Count);
                        iModel.Save("..\\..\\SampleHouseInserted.ifc");
                        Debug.WriteLine("Time to insert {0} walls (Overall {1} entities): {2}ms", walls.Count, iModel.Instances.Count, w.ElapsedMilliseconds);
                    }

                    
                }
            }
        }

    }
}
