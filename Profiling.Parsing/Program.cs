using System;
using System.Diagnostics;
using log4net;
using Xbim.Common.Metadata;
using Xbim.Ifc2x3;
using Xbim.Ifc2x3.IO;
using Xbim.Ifc2x3.SharedBldgElements;
using Xbim.IO.Memory;

namespace Profiling.Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            //const string name = "SampleHouse.ifc";
            const string name = "Lakeside.ifc";
            var w = new Stopwatch();
            
            w.Start();
            using (var model = new XbimModel())
            {
                model.CreateFrom(name);
                w.Stop();
                model.Close();
            }

            //var type = ExpressMetaData.ExpressType(typeof (IfcWall));
            //w.Stop();

            Console.WriteLine("{0}ms to create Esent model", w.ElapsedMilliseconds);

            //w.Start();
            //var model2 = new MemoryModel<EntityFactory>();
            //model2.Open(name);
            //w.Stop();
            //Console.WriteLine("{0}ms to load memory model", w.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}
