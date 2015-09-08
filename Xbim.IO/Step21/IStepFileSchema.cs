using System.Collections.Generic;
using System.IO;
using Xbim.Common;
using Xbim.XbimExtensions.Interfaces;

namespace Xbim.IO.Step21
{
    public interface IStepFileSchema : IPersist, IExpressHeaderType
    {
        List<string> Schemas { get; set; }
        void Write(BinaryWriter binaryWriter);
        void Read(BinaryReader binaryReader);
    }
}
