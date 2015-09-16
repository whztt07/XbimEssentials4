// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		16.09.2015 04:23:01
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.StructuralLoadResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[EntityName("IFCSTRUCTURALCONNECTION", 265)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcStructuralConnection : IfcStructuralItem
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralConnection(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcBoundaryCondition _appliedCondition;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional)]
		public IfcBoundaryCondition @AppliedCondition 
		{ 
			get 
			{
				if(Activated) return _appliedCondition;
				
				Model.Activate(this, true);
				Activated = true;
				return _appliedCondition;
			} 
			set
			{
				SetValue( v =>  _appliedCondition = v, _appliedCondition, value,  "AppliedCondition");
			} 
		}
	
		#endregion

		#region Inverse attributes
		public IEnumerable<IfcRelConnectsStructuralMember> @ConnectsStructuralMembers 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelConnectsStructuralMember>(e => e.RelatedStructuralConnection == this);
			} 
		}
	

		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
					base.Parse(propIndex, value); 
					return;
				case 7: 
					_appliedCondition = (IfcBoundaryCondition)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		
	}
}