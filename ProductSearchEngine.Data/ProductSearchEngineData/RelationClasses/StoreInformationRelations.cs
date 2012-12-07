///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.1
// Code is generated on: 28 Kasım 2011 Pazartesi 20:19:29
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
	/// <summary>Implements the relations factory for the entity: StoreInformation. </summary>
	public partial class StoreInformationRelations
	{
		/// <summary>CTor</summary>
		public StoreInformationRelations()
		{
		}

		/// <summary>Gets all relations of the StoreInformationEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.MembershipEntityUsingStoreInformationId);
			toReturn.Add(this.CityEntityUsingCityId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between StoreInformationEntity and MembershipEntity over the 1:n relation they have, using the relation between the fields:
		/// StoreInformation.Id - Membership.StoreInformationId
		/// </summary>
		public virtual IEntityRelation MembershipEntityUsingStoreInformationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Memberships" , true);
				relation.AddEntityFieldPair(StoreInformationFields.Id, MembershipFields.StoreInformationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreInformationEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MembershipEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between StoreInformationEntity and CityEntity over the m:1 relation they have, using the relation between the fields:
		/// StoreInformation.CityId - City.Id
		/// </summary>
		public virtual IEntityRelation CityEntityUsingCityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "City", false);
				relation.AddEntityFieldPair(CityFields.Id, StoreInformationFields.CityId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CityEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreInformationEntity", true);
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
	internal static class StaticStoreInformationRelations
	{
		internal static readonly IEntityRelation MembershipEntityUsingStoreInformationIdStatic = new StoreInformationRelations().MembershipEntityUsingStoreInformationId;
		internal static readonly IEntityRelation CityEntityUsingCityIdStatic = new StoreInformationRelations().CityEntityUsingCityId;

		/// <summary>CTor</summary>
		static StaticStoreInformationRelations()
		{
		}
	}
}
