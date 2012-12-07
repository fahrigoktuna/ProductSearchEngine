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
	/// <summary>Implements the relations factory for the entity: Product. </summary>
	public partial class ProductRelations
	{
		/// <summary>CTor</summary>
		public ProductRelations()
		{
		}

		/// <summary>Gets all relations of the ProductEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CommentEntityUsingProductId);
			toReturn.Add(this.ProductKeywordEntityUsingProductId);
			toReturn.Add(this.ProductPhotoEntityUsingProductId);
			toReturn.Add(this.ProductSpecificationEntityUsingProductId);
			toReturn.Add(this.BrandEntityUsingBrandId);
			toReturn.Add(this.CategoryEntityUsingCategoryId);
			toReturn.Add(this.StoreEntityUsingStoreId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and CommentEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.Id - Comment.ProductId
		/// </summary>
		public virtual IEntityRelation CommentEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Comments" , true);
				relation.AddEntityFieldPair(ProductFields.Id, CommentFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CommentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ProductKeywordEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.Id - ProductKeyword.ProductId
		/// </summary>
		public virtual IEntityRelation ProductKeywordEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductKeywords" , true);
				relation.AddEntityFieldPair(ProductFields.Id, ProductKeywordFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductKeywordEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ProductPhotoEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.Id - ProductPhoto.ProductId
		/// </summary>
		public virtual IEntityRelation ProductPhotoEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductPhotos" , true);
				relation.AddEntityFieldPair(ProductFields.Id, ProductPhotoFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductPhotoEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ProductSpecificationEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.Id - ProductSpecification.ProductId
		/// </summary>
		public virtual IEntityRelation ProductSpecificationEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductSpecifications" , true);
				relation.AddEntityFieldPair(ProductFields.Id, ProductSpecificationFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductSpecificationEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between ProductEntity and BrandEntity over the m:1 relation they have, using the relation between the fields:
		/// Product.BrandId - Brand.Id
		/// </summary>
		public virtual IEntityRelation BrandEntityUsingBrandId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Brand", false);
				relation.AddEntityFieldPair(BrandFields.Id, ProductFields.BrandId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BrandEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ProductEntity and CategoryEntity over the m:1 relation they have, using the relation between the fields:
		/// Product.CategoryId - Category.Id
		/// </summary>
		public virtual IEntityRelation CategoryEntityUsingCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Category", false);
				relation.AddEntityFieldPair(CategoryFields.Id, ProductFields.CategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CategoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ProductEntity and StoreEntity over the m:1 relation they have, using the relation between the fields:
		/// Product.StoreId - Store.Id
		/// </summary>
		public virtual IEntityRelation StoreEntityUsingStoreId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Store", false);
				relation.AddEntityFieldPair(StoreFields.Id, ProductFields.StoreId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
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
	internal static class StaticProductRelations
	{
		internal static readonly IEntityRelation CommentEntityUsingProductIdStatic = new ProductRelations().CommentEntityUsingProductId;
		internal static readonly IEntityRelation ProductKeywordEntityUsingProductIdStatic = new ProductRelations().ProductKeywordEntityUsingProductId;
		internal static readonly IEntityRelation ProductPhotoEntityUsingProductIdStatic = new ProductRelations().ProductPhotoEntityUsingProductId;
		internal static readonly IEntityRelation ProductSpecificationEntityUsingProductIdStatic = new ProductRelations().ProductSpecificationEntityUsingProductId;
		internal static readonly IEntityRelation BrandEntityUsingBrandIdStatic = new ProductRelations().BrandEntityUsingBrandId;
		internal static readonly IEntityRelation CategoryEntityUsingCategoryIdStatic = new ProductRelations().CategoryEntityUsingCategoryId;
		internal static readonly IEntityRelation StoreEntityUsingStoreIdStatic = new ProductRelations().StoreEntityUsingStoreId;

		/// <summary>CTor</summary>
		static StaticProductRelations()
		{
		}
	}
}
