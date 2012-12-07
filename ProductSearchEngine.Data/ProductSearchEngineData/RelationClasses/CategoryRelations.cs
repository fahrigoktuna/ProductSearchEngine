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
	/// <summary>Implements the relations factory for the entity: Category. </summary>
	public partial class CategoryRelations
	{
		/// <summary>CTor</summary>
		public CategoryRelations()
		{
		}

		/// <summary>Gets all relations of the CategoryEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CategoryEntityUsingBaseCategoryId);
			toReturn.Add(this.ProductEntityUsingCategoryId);
			toReturn.Add(this.CategoryEntityUsingIdBaseCategoryId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CategoryEntity and CategoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Category.Id - Category.BaseCategoryId
		/// </summary>
		public virtual IEntityRelation CategoryEntityUsingBaseCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Categories" , true);
				relation.AddEntityFieldPair(CategoryFields.Id, CategoryFields.BaseCategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CategoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CategoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between CategoryEntity and ProductEntity over the 1:n relation they have, using the relation between the fields:
		/// Category.Id - Product.CategoryId
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Products" , true);
				relation.AddEntityFieldPair(CategoryFields.Id, ProductFields.CategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CategoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between CategoryEntity and CategoryEntity over the m:1 relation they have, using the relation between the fields:
		/// Category.BaseCategoryId - Category.Id
		/// </summary>
		public virtual IEntityRelation CategoryEntityUsingIdBaseCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Category", false);
				relation.AddEntityFieldPair(CategoryFields.Id, CategoryFields.BaseCategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CategoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CategoryEntity", true);
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
	internal static class StaticCategoryRelations
	{
		internal static readonly IEntityRelation CategoryEntityUsingBaseCategoryIdStatic = new CategoryRelations().CategoryEntityUsingBaseCategoryId;
		internal static readonly IEntityRelation ProductEntityUsingCategoryIdStatic = new CategoryRelations().ProductEntityUsingCategoryId;
		internal static readonly IEntityRelation CategoryEntityUsingIdBaseCategoryIdStatic = new CategoryRelations().CategoryEntityUsingIdBaseCategoryId;

		/// <summary>CTor</summary>
		static StaticCategoryRelations()
		{
		}
	}
}
