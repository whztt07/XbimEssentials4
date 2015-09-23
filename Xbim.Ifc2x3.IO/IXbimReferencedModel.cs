using Xbim.Common;

namespace Xbim.IO.Esent
{
    public interface IXbimReferencedModel
    {
        IModel Model { get; }

        /// <summary>
        /// Returns the identifier for this reference within the scope of the referencing model
        /// </summary>
        string Identifier { get; }

        string Name { get; }
        string OrganisationName { get; }
        string OwnerName { get; }
    }
}
