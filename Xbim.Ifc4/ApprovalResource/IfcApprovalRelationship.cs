// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 03:44:03
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ExternalReferenceResource;
using Xbim.Ifc4.MeasureResource;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.ApprovalResource
{
	[EntityName("IFCAPPROVALRELATIONSHIP", 22)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcApprovalRelationship : IfcResourceLevelRelationship, IInstantiableEntity
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcApprovalRelationship(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedApprovals = new ItemSet<IfcApproval>( this );
		}

		#region Explicit attribute fields
		private IfcApproval _relatingApproval;
		private ItemSet<IfcApproval> _relatedApprovals;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttributee(2, EntityAttributeState.Mandatory)]
		public IfcApproval @RelatingApproval 
		{ 
			get 
			{
				if(Activated) return _relatingApproval;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatingApproval;
			} 
			set
			{
				SetValue( v =>  _relatingApproval = v, _relatingApproval, value,  "RelatingApproval");
			} 
		}
	
		[EntityAttributee(3, EntityAttributeState.Mandatory)]
		public ItemSet<IfcApproval> @RelatedApprovals 
		{ 
			get 
			{
				if(Activated) return _relatedApprovals;
				
				Model.Activate(this, true);
				Activated = true;
				return _relatedApprovals;
			} 
			set
			{
				SetValue( v =>  _relatedApprovals = v, _relatedApprovals, value,  "RelatedApprovals");
			} 
		}
	
		#endregion

		#region Inverse attributes

		#endregion

		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
					base.Parse(propIndex, value); 
					return;
				case 2: 
					_relatingApproval = (IfcApproval)(value.EntityVal);
					return;
				case 3: 
					if (_relatedApprovals == null) _relatedApprovals = new ItemSet<IfcApproval>( this );
					_relatedApprovals.InternalAdd((IfcApproval)value.EntityVal);
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