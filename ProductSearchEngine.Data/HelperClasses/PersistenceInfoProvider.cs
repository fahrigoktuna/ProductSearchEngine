///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.1
// Code is generated on: 14 Ocak 2012 Cumartesi 02:54:12
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ProductSearchEngine.HelperClasses
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal static class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass((16 + 0));
			InitBrandEntityMappings();
			InitCategoryEntityMappings();
			InitCityEntityMappings();
			InitCommentEntityMappings();
			InitKeywordEntityMappings();
			InitLastViewedProductEntityMappings();
			InitMembershipEntityMappings();
			InitProductEntityMappings();
			InitProductKeywordEntityMappings();
			InitProductPhotoEntityMappings();
			InitProductSpecificationEntityMappings();
			InitRateEntityMappings();
			InitRoleEntityMappings();
			InitStoreEntityMappings();
			InitStoreInformationEntityMappings();
			InitWebTrackerEntityMappings();

		}


		/// <summary>Inits BrandEntity's mappings</summary>
		private void InitBrandEntityMappings()
		{
			this.AddElementMapping( "BrandEntity", "ProductSearchEngine", @"dbo", "Brand", 3 );
			this.AddElementFieldMapping( "BrandEntity", "Id", "Id", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "BrandEntity", "Name", "Name", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "BrandEntity", "PhotoUniqueName", "PhotoUniqueName", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits CategoryEntity's mappings</summary>
		private void InitCategoryEntityMappings()
		{
			this.AddElementMapping( "CategoryEntity", "ProductSearchEngine", @"dbo", "Category", 3 );
			this.AddElementFieldMapping( "CategoryEntity", "BaseCategoryId", "BaseCategoryId", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "CategoryEntity", "Id", "Id", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1 );
			this.AddElementFieldMapping( "CategoryEntity", "Name", "Name", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits CityEntity's mappings</summary>
		private void InitCityEntityMappings()
		{
			this.AddElementMapping( "CityEntity", "ProductSearchEngine", @"dbo", "City", 2 );
			this.AddElementFieldMapping( "CityEntity", "Id", "Id", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "CityEntity", "Name", "Name", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits CommentEntity's mappings</summary>
		private void InitCommentEntityMappings()
		{
			this.AddElementMapping( "CommentEntity", "ProductSearchEngine", @"dbo", "Comment", 6 );
			this.AddElementFieldMapping( "CommentEntity", "Content", "Content", true, "NVarChar", 1000, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "CommentEntity", "Id", "Id", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1 );
			this.AddElementFieldMapping( "CommentEntity", "ProductId", "ProductId", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			this.AddElementFieldMapping( "CommentEntity", "RateId", "RateId", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			this.AddElementFieldMapping( "CommentEntity", "Status", "Status", true, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
			this.AddElementFieldMapping( "CommentEntity", "Title", "Title", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 5 );
		}
		/// <summary>Inits KeywordEntity's mappings</summary>
		private void InitKeywordEntityMappings()
		{
			this.AddElementMapping( "KeywordEntity", "ProductSearchEngine", @"dbo", "Keyword", 2 );
			this.AddElementFieldMapping( "KeywordEntity", "Id", "Id", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "KeywordEntity", "Keyword", "Keyword", true, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits LastViewedProductEntity's mappings</summary>
		private void InitLastViewedProductEntityMappings()
		{
			this.AddElementMapping( "LastViewedProductEntity", "ProductSearchEngine", @"dbo", "LastViewedProduct", 4 );
			this.AddElementFieldMapping( "LastViewedProductEntity", "Id", "Id", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "LastViewedProductEntity", "IpAdrees", "IpAdrees", true, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "LastViewedProductEntity", "ProductId", "ProductId", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			this.AddElementFieldMapping( "LastViewedProductEntity", "ViewedTime", "ViewedTime", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits MembershipEntity's mappings</summary>
		private void InitMembershipEntityMappings()
		{
			this.AddElementMapping( "MembershipEntity", "ProductSearchEngine", @"dbo", "Membership", 6 );
			this.AddElementFieldMapping( "MembershipEntity", "Id", "Id", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "MembershipEntity", "Password", "Password", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "MembershipEntity", "RoleId", "RoleId", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			this.AddElementFieldMapping( "MembershipEntity", "Status", "Status", true, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 3 );
			this.AddElementFieldMapping( "MembershipEntity", "StoreInformationId", "StoreInformationId", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			this.AddElementFieldMapping( "MembershipEntity", "UserName", "UserName", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 5 );
		}
		/// <summary>Inits ProductEntity's mappings</summary>
		private void InitProductEntityMappings()
		{
			this.AddElementMapping( "ProductEntity", "ProductSearchEngine", @"dbo", "Product", 14 );
			this.AddElementFieldMapping( "ProductEntity", "AddedDate", "AddedDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0 );
			this.AddElementFieldMapping( "ProductEntity", "BrandId", "BrandId", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			this.AddElementFieldMapping( "ProductEntity", "CategoryId", "CategoryId", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			this.AddElementFieldMapping( "ProductEntity", "DetailDescription", "DetailDescription", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "ProductEntity", "Id", "Id", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4 );
			this.AddElementFieldMapping( "ProductEntity", "IsFreeShipping", "IsFreeShipping", true, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 5 );
			this.AddElementFieldMapping( "ProductEntity", "IsNewItem", "IsNewItem", true, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 6 );
			this.AddElementFieldMapping( "ProductEntity", "IsSliderProduct", "IsSliderProduct", true, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 7 );
			this.AddElementFieldMapping( "ProductEntity", "IsSpeacialProduct", "IsSpeacialProduct", true, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 8 );
			this.AddElementFieldMapping( "ProductEntity", "Price", "Price", true, "Float", 0, 0, 38, false, "", null, typeof(System.Double), 9 );
			this.AddElementFieldMapping( "ProductEntity", "RedirectUrl", "RedirectUrl", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "ProductEntity", "Status", "Status", true, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 11 );
			this.AddElementFieldMapping( "ProductEntity", "StoreId", "StoreId", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 12 );
			this.AddElementFieldMapping( "ProductEntity", "Title", "Title", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 13 );
		}
		/// <summary>Inits ProductKeywordEntity's mappings</summary>
		private void InitProductKeywordEntityMappings()
		{
			this.AddElementMapping( "ProductKeywordEntity", "ProductSearchEngine", @"dbo", "ProductKeyword", 2 );
			this.AddElementFieldMapping( "ProductKeywordEntity", "KeywordId", "KeywordId", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "ProductKeywordEntity", "ProductId", "ProductId", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
		}
		/// <summary>Inits ProductPhotoEntity's mappings</summary>
		private void InitProductPhotoEntityMappings()
		{
			this.AddElementMapping( "ProductPhotoEntity", "ProductSearchEngine", @"dbo", "ProductPhoto", 3 );
			this.AddElementFieldMapping( "ProductPhotoEntity", "Id", "Id", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "ProductPhotoEntity", "ProductId", "ProductId", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			this.AddElementFieldMapping( "ProductPhotoEntity", "UniqueName", "UniqueName", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits ProductSpecificationEntity's mappings</summary>
		private void InitProductSpecificationEntityMappings()
		{
			this.AddElementMapping( "ProductSpecificationEntity", "ProductSearchEngine", @"dbo", "ProductSpecification", 3 );
			this.AddElementFieldMapping( "ProductSpecificationEntity", "ProductId", "ProductId", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "ProductSpecificationEntity", "SpecificationName", "SpecificationName", false, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "ProductSpecificationEntity", "SpecificationValue", "SpecificationValue", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits RateEntity's mappings</summary>
		private void InitRateEntityMappings()
		{
			this.AddElementMapping( "RateEntity", "ProductSearchEngine", @"dbo", "Rate", 2 );
			this.AddElementFieldMapping( "RateEntity", "Id", "Id", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "RateEntity", "Value", "Value", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
		}
		/// <summary>Inits RoleEntity's mappings</summary>
		private void InitRoleEntityMappings()
		{
			this.AddElementMapping( "RoleEntity", "ProductSearchEngine", @"dbo", "Role", 2 );
			this.AddElementFieldMapping( "RoleEntity", "Id", "Id", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "RoleEntity", "Name", "Name", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits StoreEntity's mappings</summary>
		private void InitStoreEntityMappings()
		{
			this.AddElementMapping( "StoreEntity", "ProductSearchEngine", @"dbo", "Store", 3 );
			this.AddElementFieldMapping( "StoreEntity", "Id", "Id", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "StoreEntity", "MembershipId", "MembershipId", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			this.AddElementFieldMapping( "StoreEntity", "Name", "Name", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits StoreInformationEntity's mappings</summary>
		private void InitStoreInformationEntityMappings()
		{
			this.AddElementMapping( "StoreInformationEntity", "ProductSearchEngine", @"dbo", "StoreInformation", 7 );
			this.AddElementFieldMapping( "StoreInformationEntity", "Address", "Address", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "StoreInformationEntity", "AuthorizedName", "AuthorizedName", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "StoreInformationEntity", "CityId", "CityId", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			this.AddElementFieldMapping( "StoreInformationEntity", "Email", "Email", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "StoreInformationEntity", "Id", "Id", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4 );
			this.AddElementFieldMapping( "StoreInformationEntity", "Telephone", "Telephone", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "StoreInformationEntity", "WebAddress", "WebAddress", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits WebTrackerEntity's mappings</summary>
		private void InitWebTrackerEntityMappings()
		{
			this.AddElementMapping( "WebTrackerEntity", "ProductSearchEngine", @"dbo", "WebTracker", 4 );
			this.AddElementFieldMapping( "WebTrackerEntity", "Browser", "Browser", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "WebTrackerEntity", "Id", "Id", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1 );
			this.AddElementFieldMapping( "WebTrackerEntity", "IpAddress", "IpAddress", true, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "WebTrackerEntity", "VisitTime", "VisitTime", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}

	}
}