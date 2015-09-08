// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		08/09/2015 09:16:44
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using Xbim.Common;

namespace Xbim.CobieExpress
{
	public sealed class EntityFactory : IEntityFactory
	{
		public T New<T>(IModel model) where T: IInstantiableEntity
		{
			return (T)New(model, typeof(T));
		}

		public T New<T>(IModel model, Action<T> init) where T: IInstantiableEntity
		{
			var o = New<T>(model);
			init(o);
			return o;
		}

		public IInstantiableEntity New(IModel model, Type t)
		{
			//check that the type is from this assembly
			if(t.Assembly != GetType().Assembly)
				throw new Exception("This factory only creates types from its assembly");

			return New(model, t.Name);
		}

		public IInstantiableEntity New(IModel model, string typeName)
		{
			if (model == null || typeName == null)
				throw new ArgumentNullException();

			var name = typeName.ToUpper();
			switch(name)
			{
				case "COBIEPICKLIST": return new CobiePickList ( model );
				case "COBIEPICKVALUE": return new CobiePickValue ( model );
				case "COBIEPICKKEYVALUE": return new CobiePickKeyValue ( model );
				case "COBIEPHASE": return new CobiePhase ( model );
				case "COBIEEXTERNALSYSTEM": return new CobieExternalSystem ( model );
				case "COBIECREATEDINFO": return new CobieCreatedInfo ( model );
				case "COBIECONTACT": return new CobieContact ( model );
				case "COBIEFACILITY": return new CobieFacility ( model );
				case "COBIEPROJECT": return new CobieProject ( model );
				case "COBIESITE": return new CobieSite ( model );
				case "COBIEFLOOR": return new CobieFloor ( model );
				case "COBIESPACE": return new CobieSpace ( model );
				case "COBIEZONE": return new CobieZone ( model );
				case "COBIETYPE": return new CobieType ( model );
				case "COBIEWARRANTY": return new CobieWarranty ( model );
				case "COBIECOMPONENT": return new CobieComponent ( model );
				case "COBIESYSTEM": return new CobieSystem ( model );
				case "COBIECONNECTION": return new CobieConnection ( model );
				case "COBIESPARE": return new CobieSpare ( model );
				case "COBIERESOURCE": return new CobieResource ( model );
				case "COBIEJOB": return new CobieJob ( model );
				case "COBIEIMPACT": return new CobieImpact ( model );
				case "COBIEDOCUMENT": return new CobieDocument ( model );
				case "COBIEATTRIBUTE": return new CobieAttribute ( model );
				case "COBIEISSUE": return new CobieIssue ( model );
				default:
					throw new Exception("Type must be non-abstract type of IInstantiableEntity");
			}
		}
	}
}
