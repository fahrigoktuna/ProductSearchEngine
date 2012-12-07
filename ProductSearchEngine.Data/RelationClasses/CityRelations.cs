///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.1
// Code is generated on: 14 Ocak 2012 Cumartesi 02:54:11
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using ProductSearchEngine;
using ProductSearchEngine.FactoryClasses;
using ProductSearchEngine.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ProductSearchEngine.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: City. </summary>
	public partial class CityRelations
	{
		/// <summary>CTor</summary>
		public CityRelations()
		{
		}

		/// <summary>Gets all relations of the CityEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.StoreInformationEntityUsingCityId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CityEntity and StoreInformationEntity over the 1:n relation they have, using the relation between the fields:
		/// City.Id - StoreInformation.CityId
		/// </summary>
		public virtual IEntityRelation StoreInformationEntityUsingCityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "StoreInformations" , true);
				relation.AddEntityFieldPair(CityFields.Id, StoreInformationFields.CityId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CityEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreInformationEntity", false);
				return relation;
			}
		}


		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticCityRelations
	{
		internal static readonly IEntityRelation StoreInformationEntityUsingCityIdStatic = new CityRelations().StoreInformationEntityUsingCityId;

		/// <summary>CTor</summary>
		static StaticCityRelations()
		{
		}
	}
}
