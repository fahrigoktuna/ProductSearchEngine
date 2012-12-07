///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.1
// Code is generated on: 28 Kasım 2011 Pazartesi 20:19:30
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using ProductSearchEngine.FactoryClasses;
using ProductSearchEngine;

namespace ProductSearchEngine.HelperClasses
{
	/// <summary>Field Creation Class for entity BrandEntity</summary>
	public partial class BrandFields
	{
		/// <summary>Creates a new BrandEntity.Id field instance</summary>
		public static EntityField Id
		{
			get { return (EntityField)EntityFieldFactory.Create(BrandFieldIndex.Id);}
		}
		/// <summary>Creates a new BrandEntity.Name field instance</summary>
		public static EntityField Name
		{
			get { return (EntityField)EntityFieldFactory.Create(BrandFieldIndex.Name);}
		}
		/// <summary>Creates a new BrandEntity.PhotoUniqueName field instance</summary>
		public static EntityField PhotoUniqueName
		{
			get { return (EntityField)EntityFieldFactory.Create(BrandFieldIndex.PhotoUniqueName);}
		}
	}

	/// <summary>Field Creation Class for entity CategoryEntity</summary>
	public partial class CategoryFields
	{
		/// <summary>Creates a new CategoryEntity.BaseCategoryId field instance</summary>
		public static EntityField BaseCategoryId
		{
			get { return (EntityField)EntityFieldFactory.Create(CategoryFieldIndex.BaseCategoryId);}
		}
		/// <summary>Creates a new CategoryEntity.Id field instance</summary>
		public static EntityField Id
		{
			get { return (EntityField)EntityFieldFactory.Create(CategoryFieldIndex.Id);}
		}
		/// <summary>Creates a new CategoryEntity.Name field instance</summary>
		public static EntityField Name
		{
			get { return (EntityField)EntityFieldFactory.Create(CategoryFieldIndex.Name);}
		}
	}

	/// <summary>Field Creation Class for entity CityEntity</summary>
	public partial class CityFields
	{
		/// <summary>Creates a new CityEntity.Id field instance</summary>
		public static EntityField Id
		{
			get { return (EntityField)EntityFieldFactory.Create(CityFieldIndex.Id);}
		}
		/// <summary>Creates a new CityEntity.Name field instance</summary>
		public static EntityField Name
		{
			get { return (EntityField)EntityFieldFactory.Create(CityFieldIndex.Name);}
		}
	}

	/// <summary>Field Creation Class for entity CommentEntity</summary>
	public partial class CommentFields
	{
		/// <summary>Creates a new CommentEntity.Content field instance</summary>
		public static EntityField Content
		{
			get { return (EntityField)EntityFieldFactory.Create(CommentFieldIndex.Content);}
		}
		/// <summary>Creates a new CommentEntity.Id field instance</summary>
		public static EntityField Id
		{
			get { return (EntityField)EntityFieldFactory.Create(CommentFieldIndex.Id);}
		}
		/// <summary>Creates a new CommentEntity.ProductId field instance</summary>
		public static EntityField ProductId
		{
			get { return (EntityField)EntityFieldFactory.Create(CommentFieldIndex.ProductId);}
		}
		/// <summary>Creates a new CommentEntity.RateId field instance</summary>
		public static EntityField RateId
		{
			get { return (EntityField)EntityFieldFactory.Create(CommentFieldIndex.RateId);}
		}
		/// <summary>Creates a new CommentEntity.Title field instance</summary>
		public static EntityField Title
		{
			get { return (EntityField)EntityFieldFactory.Create(CommentFieldIndex.Title);}
		}
	}

	/// <summary>Field Creation Class for entity KeywordEntity</summary>
	public partial class KeywordFields
	{
		/// <summary>Creates a new KeywordEntity.Id field instance</summary>
		public static EntityField Id
		{
			get { return (EntityField)EntityFieldFactory.Create(KeywordFieldIndex.Id);}
		}
		/// <summary>Creates a new KeywordEntity.Keyword field instance</summary>
		public static EntityField Keyword
		{
			get { return (EntityField)EntityFieldFactory.Create(KeywordFieldIndex.Keyword);}
		}
	}

	/// <summary>Field Creation Class for entity MembershipEntity</summary>
	public partial class MembershipFields
	{
		/// <summary>Creates a new MembershipEntity.Id field instance</summary>
		public static EntityField Id
		{
			get { return (EntityField)EntityFieldFactory.Create(MembershipFieldIndex.Id);}
		}
		/// <summary>Creates a new MembershipEntity.Password field instance</summary>
		public static EntityField Password
		{
			get { return (EntityField)EntityFieldFactory.Create(MembershipFieldIndex.Password);}
		}
		/// <summary>Creates a new MembershipEntity.Status field instance</summary>
		public static EntityField Status
		{
			get { return (EntityField)EntityFieldFactory.Create(MembershipFieldIndex.Status);}
		}
		/// <summary>Creates a new MembershipEntity.StoreInformationId field instance</summary>
		public static EntityField StoreInformationId
		{
			get { return (EntityField)EntityFieldFactory.Create(MembershipFieldIndex.StoreInformationId);}
		}
		/// <summary>Creates a new MembershipEntity.UserName field instance</summary>
		public static EntityField UserName
		{
			get { return (EntityField)EntityFieldFactory.Create(MembershipFieldIndex.UserName);}
		}
	}

	/// <summary>Field Creation Class for entity ProductEntity</summary>
	public partial class ProductFields
	{
		/// <summary>Creates a new ProductEntity.AddedDate field instance</summary>
		public static EntityField AddedDate
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.AddedDate);}
		}
		/// <summary>Creates a new ProductEntity.BrandId field instance</summary>
		public static EntityField BrandId
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.BrandId);}
		}
		/// <summary>Creates a new ProductEntity.CategoryId field instance</summary>
		public static EntityField CategoryId
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.CategoryId);}
		}
		/// <summary>Creates a new ProductEntity.DetailDescription field instance</summary>
		public static EntityField DetailDescription
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.DetailDescription);}
		}
		/// <summary>Creates a new ProductEntity.Id field instance</summary>
		public static EntityField Id
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.Id);}
		}
		/// <summary>Creates a new ProductEntity.IsFreeShipping field instance</summary>
		public static EntityField IsFreeShipping
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.IsFreeShipping);}
		}
		/// <summary>Creates a new ProductEntity.IsNewItem field instance</summary>
		public static EntityField IsNewItem
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.IsNewItem);}
		}
		/// <summary>Creates a new ProductEntity.IsSliderProduct field instance</summary>
		public static EntityField IsSliderProduct
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.IsSliderProduct);}
		}
		/// <summary>Creates a new ProductEntity.IsSpeacialProduct field instance</summary>
		public static EntityField IsSpeacialProduct
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.IsSpeacialProduct);}
		}
		/// <summary>Creates a new ProductEntity.Price field instance</summary>
		public static EntityField Price
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.Price);}
		}
		/// <summary>Creates a new ProductEntity.RedirectUrl field instance</summary>
		public static EntityField RedirectUrl
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.RedirectUrl);}
		}
		/// <summary>Creates a new ProductEntity.Status field instance</summary>
		public static EntityField Status
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.Status);}
		}
		/// <summary>Creates a new ProductEntity.StoreId field instance</summary>
		public static EntityField StoreId
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.StoreId);}
		}
		/// <summary>Creates a new ProductEntity.Title field instance</summary>
		public static EntityField Title
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.Title);}
		}
	}

	/// <summary>Field Creation Class for entity ProductKeywordEntity</summary>
	public partial class ProductKeywordFields
	{
		/// <summary>Creates a new ProductKeywordEntity.KeywordId field instance</summary>
		public static EntityField KeywordId
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductKeywordFieldIndex.KeywordId);}
		}
		/// <summary>Creates a new ProductKeywordEntity.ProductId field instance</summary>
		public static EntityField ProductId
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductKeywordFieldIndex.ProductId);}
		}
	}

	/// <summary>Field Creation Class for entity ProductPhotoEntity</summary>
	public partial class ProductPhotoFields
	{
		/// <summary>Creates a new ProductPhotoEntity.Id field instance</summary>
		public static EntityField Id
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductPhotoFieldIndex.Id);}
		}
		/// <summary>Creates a new ProductPhotoEntity.ProductId field instance</summary>
		public static EntityField ProductId
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductPhotoFieldIndex.ProductId);}
		}
		/// <summary>Creates a new ProductPhotoEntity.UniqueName field instance</summary>
		public static EntityField UniqueName
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductPhotoFieldIndex.UniqueName);}
		}
	}

	/// <summary>Field Creation Class for entity ProductSpecificationEntity</summary>
	public partial class ProductSpecificationFields
	{
		/// <summary>Creates a new ProductSpecificationEntity.ProductId field instance</summary>
		public static EntityField ProductId
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductSpecificationFieldIndex.ProductId);}
		}
		/// <summary>Creates a new ProductSpecificationEntity.SpecificationName field instance</summary>
		public static EntityField SpecificationName
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductSpecificationFieldIndex.SpecificationName);}
		}
		/// <summary>Creates a new ProductSpecificationEntity.SpecificationValue field instance</summary>
		public static EntityField SpecificationValue
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductSpecificationFieldIndex.SpecificationValue);}
		}
	}

	/// <summary>Field Creation Class for entity RateEntity</summary>
	public partial class RateFields
	{
		/// <summary>Creates a new RateEntity.Id field instance</summary>
		public static EntityField Id
		{
			get { return (EntityField)EntityFieldFactory.Create(RateFieldIndex.Id);}
		}
		/// <summary>Creates a new RateEntity.Value field instance</summary>
		public static EntityField Value
		{
			get { return (EntityField)EntityFieldFactory.Create(RateFieldIndex.Value);}
		}
	}

	/// <summary>Field Creation Class for entity StoreEntity</summary>
	public partial class StoreFields
	{
		/// <summary>Creates a new StoreEntity.Id field instance</summary>
		public static EntityField Id
		{
			get { return (EntityField)EntityFieldFactory.Create(StoreFieldIndex.Id);}
		}
		/// <summary>Creates a new StoreEntity.MembershipId field instance</summary>
		public static EntityField MembershipId
		{
			get { return (EntityField)EntityFieldFactory.Create(StoreFieldIndex.MembershipId);}
		}
		/// <summary>Creates a new StoreEntity.Name field instance</summary>
		public static EntityField Name
		{
			get { return (EntityField)EntityFieldFactory.Create(StoreFieldIndex.Name);}
		}
	}

	/// <summary>Field Creation Class for entity StoreInformationEntity</summary>
	public partial class StoreInformationFields
	{
		/// <summary>Creates a new StoreInformationEntity.Address field instance</summary>
		public static EntityField Address
		{
			get { return (EntityField)EntityFieldFactory.Create(StoreInformationFieldIndex.Address);}
		}
		/// <summary>Creates a new StoreInformationEntity.AuthorizedName field instance</summary>
		public static EntityField AuthorizedName
		{
			get { return (EntityField)EntityFieldFactory.Create(StoreInformationFieldIndex.AuthorizedName);}
		}
		/// <summary>Creates a new StoreInformationEntity.CityId field instance</summary>
		public static EntityField CityId
		{
			get { return (EntityField)EntityFieldFactory.Create(StoreInformationFieldIndex.CityId);}
		}
		/// <summary>Creates a new StoreInformationEntity.Email field instance</summary>
		public static EntityField Email
		{
			get { return (EntityField)EntityFieldFactory.Create(StoreInformationFieldIndex.Email);}
		}
		/// <summary>Creates a new StoreInformationEntity.Id field instance</summary>
		public static EntityField Id
		{
			get { return (EntityField)EntityFieldFactory.Create(StoreInformationFieldIndex.Id);}
		}
		/// <summary>Creates a new StoreInformationEntity.Telephone field instance</summary>
		public static EntityField Telephone
		{
			get { return (EntityField)EntityFieldFactory.Create(StoreInformationFieldIndex.Telephone);}
		}
		/// <summary>Creates a new StoreInformationEntity.WebAddress field instance</summary>
		public static EntityField WebAddress
		{
			get { return (EntityField)EntityFieldFactory.Create(StoreInformationFieldIndex.WebAddress);}
		}
	}
	

}