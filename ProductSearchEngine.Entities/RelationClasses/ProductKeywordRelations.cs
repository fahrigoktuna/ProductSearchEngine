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
	/// <summary>Implements the relations factory for the entity: ProductKeyword. </summary>
	public partial class ProductKeywordRelations
	{
		/// <summary>CTor</summary>
		public ProductKeywordRelations()
		{
		}

		/// <summary>Gets all relations of the ProductKeywordEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.KeywordEntityUsingKeywordId);
			toReturn.Add(this.ProductEntityUsingProductId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between ProductKeywordEntity and KeywordEntity over the m:1 relation they have, using the relation between the fields:
		/// ProductKeyword.KeywordId - Keyword.Id
		/// </summary>
		public virtual IEntityRelation KeywordEntityUsingKeywordId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Keyword", false);
				relation.AddEntityFieldPair(KeywordFields.Id, ProductKeywordFields.KeywordId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KeywordEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductKeywordEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ProductKeywordEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// ProductKeyword.ProductId - Product.Id
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Product", false);
				relation.AddEntityFieldPair(ProductFields.Id, ProductKeywordFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductKeywordEntity", true);
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
	internal static class StaticProductKeywordRelations
	{
		internal static readonly IEntityRelation KeywordEntityUsingKeywordIdStatic = new ProductKeywordRelations().KeywordEntityUsingKeywordId;
		internal static readonly IEntityRelation ProductEntityUsingProductIdStatic = new ProductKeywordRelations().ProductEntityUsingProductId;

		/// <summary>CTor</summary>
		static StaticProductKeywordRelations()
		{
		}
	}
}
