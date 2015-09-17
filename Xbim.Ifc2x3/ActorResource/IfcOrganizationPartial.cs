using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbim.Common;

namespace Xbim.Ifc2x3.ActorResource
{
    public partial class IfcOrganization
    {
        public void AddRole(IfcActorRole newRole)
        {
            if (Roles == null)
                Roles = new ItemSet<IfcActorRole>(this);
            Roles.Add(newRole);
        }
    }
}
