using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xbim.CobieExpress;
using Xbim.Common;

namespace Xbim.MemoryModel.Tests
{
    [TestClass]
    public class CobieExpressCreation
    {
        [TestMethod]
        public void CreateSimpleModel()
        {
            var model = new Model<EntityFactory>();
            _model = model;
            using (var txn = model.BeginTransaction("Model creation"))
            {
                var facility = New<CobieFacility>(f =>
                {
                    f.Name = "New facility";
                    f.Created = model.Instances.New<CobieCreatedInfo>(ci => ci.CreatedOn = DateTime.Now);
                    f.LinearUnits = New<CobiePickValue>(pv => pv.Value = "Meters");
                    f.Attributes.Add(New<CobieAttribute>(c =>
                    {
                        c.Set("String value");
                        c.Name = "String";
                    }));
                    f.Attributes.Add(New<CobieAttribute>(c =>
                    {
                        c.Set(456.123);
                        c.Name = "Real";
                    }));
                    f.Attributes.Add(New<CobieAttribute>(c =>
                    {
                        c.Set(true);
                        c.Name = "Boolean";
                    }));
                });
                var instance = ((IInstantiableEntity) facility);
                var name = instance.GetValue("Name") as string;
                DateTime date = facility.Created.CreatedOn;
                txn.Commit();
            }
        }

        private IModel _model;
        private T New<T>(Action<T> init = null) where T: IInstantiableEntity
        {
            return _model.Instances.New<T>(init);
        }
    }
}
