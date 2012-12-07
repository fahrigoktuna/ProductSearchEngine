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
	/// <summary>Implements the relations factory for the entity: Membership. </summary>
	public partial class MembershipRelations
	{
		/// <summary>CTor</summary>
		public MembershipRelations()
		{
		}

		/// <summary>Gets all relations of the MembershipEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.StoreEntityUsingMembershipId);
			toReturn.Add(this.StoreInformationEntityUsingStoreInformationId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between MembershipEntity and StoreEntity over the 1:n relation they have, using the relation between the fields:
		/// Membership.Id - Store.MembershipId
		/// </summary>
		public virtual IEntityRelation StoreEntityUsingMembershipId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Stores" , true);
				relation.AddEntityFieldPair(MembershipFields.Id, StoreFields.MembershipId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MembershipEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between MembershipEntity and StoreInformationEntity over the m:1 relation they have, using the relation between the fields:
		/// Membership.StoreInformationId - StoreInformation.Id
		/// </summary>
		public virtual IEntityRelation StoreInformationEntityUsingStoreInformationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "StoreInformation", false);
				relation.AddEntityFieldPair(StoreInformationFields.Id, MembershipFields.StoreInformationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreInformationEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MembershipEntity", true);
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
	internal static class StaticMembershipRelations
	{
		internal static readonly IEntityRelation StoreEntityUsingMembershipIdStatic = new MembershipRelations().StoreEntityUsingMembershipId;
		internal static readonly IEntityRelation StoreInformationEntityUsingStoreInformationIdStatic = new MembershipRelations().StoreInformationEntityUsingStoreInformationId;

		/// <summary>CTor</summary>
		static StaticMembershipRelations()
		{
		}
	}
}
