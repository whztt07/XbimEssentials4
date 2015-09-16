using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbim.Common;

namespace Xbim.Ifc2x3.Kernel
{
    public partial class IfcTypeObject
    {
        public void AddPropertySet(IfcPropertySetDefinition pSetDefinition)
        {
            if (HasPropertySets == null) HasPropertySets = new ItemSet<IfcPropertySetDefinition>(this);
            HasPropertySets.Add(pSetDefinition);
        }
    }
}
