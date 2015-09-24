// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:46
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.CobieExpress
{
	public sealed class EntityFactory : IEntityFactory
	{
		public T New<T>(IModel model, int entityLabel, bool activated) where T: IInstantiableEntity
		{
			return (T)New(model, typeof(T), entityLabel, activated);
		}

		public T New<T>(IModel model, Action<T> init, int entityLabel, bool activated) where T: IInstantiableEntity
		{
			var o = New<T>(model, entityLabel, activated);
			init(o);
			return o;
		}

		public IInstantiableEntity New(IModel model, Type t, int entityLabel, bool activated)
		{
			//check that the type is from this assembly
			if(t.Assembly != GetType().Assembly)
				throw new Exception("This factory only creates types from its assembly");

			return New(model, t.Name, entityLabel, activated);
		}

		public IInstantiableEntity New(IModel model, string typeName, int entityLabel, bool activated)
		{
			if (model == null || typeName == null)
				throw new ArgumentNullException();

			var name = typeName.ToUpper();
			switch(name)
			{
				case "COBIEPICKLIST": return new CobiePickList ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "PICKLIST": return new CobiePickList ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIEPICKVALUE": return new CobiePickValue ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "PICKVALUE": return new CobiePickValue ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIEPICKKEYVALUE": return new CobiePickKeyValue ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "PICKKEYVALUE": return new CobiePickKeyValue ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIEPHASE": return new CobiePhase ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "PHASE": return new CobiePhase ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIEEXTERNALSYSTEM": return new CobieExternalSystem ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "EXTERNALSYSTEM": return new CobieExternalSystem ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIECREATEDINFO": return new CobieCreatedInfo ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "CREATEDINFO": return new CobieCreatedInfo ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIECONTACT": return new CobieContact ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "CONTACT": return new CobieContact ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIEFACILITY": return new CobieFacility ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "FACILITY": return new CobieFacility ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIEPROJECT": return new CobieProject ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "PROJECT": return new CobieProject ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIESITE": return new CobieSite ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "SITE": return new CobieSite ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIEFLOOR": return new CobieFloor ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "FLOOR": return new CobieFloor ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIESPACE": return new CobieSpace ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "SPACE": return new CobieSpace ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIEZONE": return new CobieZone ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "ZONE": return new CobieZone ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIETYPE": return new CobieType ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "TYPE": return new CobieType ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIEWARRANTY": return new CobieWarranty ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "WARRANTY": return new CobieWarranty ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIECOMPONENT": return new CobieComponent ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COMPONENT": return new CobieComponent ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIESYSTEM": return new CobieSystem ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "SYSTEM": return new CobieSystem ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIECONNECTION": return new CobieConnection ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "CONNECTION": return new CobieConnection ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIESPARE": return new CobieSpare ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "SPARE": return new CobieSpare ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIERESOURCE": return new CobieResource ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "RESOURCE": return new CobieResource ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIEJOB": return new CobieJob ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "JOB": return new CobieJob ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIEIMPACT": return new CobieImpact ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "IMPACT": return new CobieImpact ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIEDOCUMENT": return new CobieDocument ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "DOCUMENT": return new CobieDocument ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIEATTRIBUTE": return new CobieAttribute ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "ATTRIBUTE": return new CobieAttribute ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "COBIEISSUE": return new CobieIssue ( model ) { Activated = activated, EntityLabel = entityLabel };
				case "ISSUE": return new CobieIssue ( model ) { Activated = activated, EntityLabel = entityLabel };
				default:
					return null;
			}
		}
		public IInstantiableEntity New(IModel model, int typeId, int entityLabel, bool activated)
		{
			if (model == null)
				throw new ArgumentNullException();

			switch(typeId)
			{
				case 7: return new CobiePickList ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 8: return new CobiePickValue ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 9: return new CobiePickKeyValue ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 10: return new CobiePhase ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 11: return new CobieExternalSystem ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 12: return new CobieCreatedInfo ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 14: return new CobieContact ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 16: return new CobieFacility ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 17: return new CobieProject ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 18: return new CobieSite ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 19: return new CobieFloor ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 20: return new CobieSpace ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 21: return new CobieZone ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 22: return new CobieType ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 23: return new CobieWarranty ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 24: return new CobieComponent ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 25: return new CobieSystem ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 26: return new CobieConnection ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 27: return new CobieSpare ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 28: return new CobieResource ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 29: return new CobieJob ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 30: return new CobieImpact ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 31: return new CobieDocument ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 32: return new CobieAttribute ( model ) { Activated = activated, EntityLabel = entityLabel };
				case 33: return new CobieIssue ( model ) { Activated = activated, EntityLabel = entityLabel };
				default:
					return null;
			}
		}

		public IExpressValueType New(string typeName)
		{
		if (typeName == null)
				throw new ArgumentNullException();

			var name = typeName.ToUpper();
			switch(name)
			{
				case "STRINGVALUE": return new StringValue ();
				case "INTEGERVALUE": return new IntegerValue ();
				case "FLOATVALUE": return new FloatValue ();
				case "BOOLEANVALUE": return new BooleanValue ();
				case "DATETIMEVALUE": return new DateTimeValue ();
				default:
					return null;
			}
		}

		private static List<string> _schemasIds = new List<string> { "COBIE_EXPRESS" };
		public IEnumerable<string> SchemasIds { get { return _schemasIds; } }

	}
}
