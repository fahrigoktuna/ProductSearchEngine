///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.1
// Code is generated on: 28 Kasım 2011 Pazartesi 20:19:28
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ProductSearchEngine.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal static class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass( (13 + 0));
			InitBrandEntityInfos();
			InitCategoryEntityInfos();
			InitCityEntityInfos();
			InitCommentEntityInfos();
			InitKeywordEntityInfos();
			InitMembershipEntityInfos();
			InitProductEntityInfos();
			InitProductKeywordEntityInfos();
			InitProductPhotoEntityInfos();
			InitProductSpecificationEntityInfos();
			InitRateEntityInfos();
			InitStoreEntityInfos();
			InitStoreInformationEntityInfos();

			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits BrandEntity's FieldInfo objects</summary>
		private void InitBrandEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BrandFieldIndex), "BrandEntity");
			this.AddElementFieldInfo("BrandEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)BrandFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("BrandEntity", "Name", typeof(System.String), false, false, false, true,  (int)BrandFieldIndex.Name, 250, 0, 0);
			this.AddElementFieldInfo("BrandEntity", "PhotoUniqueName", typeof(System.String), false, false, false, true,  (int)BrandFieldIndex.PhotoUniqueName, 500, 0, 0);
		}
		/// <summary>Inits CategoryEntity's FieldInfo objects</summary>
		private void InitCategoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CategoryFieldIndex), "CategoryEntity");
			this.AddElementFieldInfo("CategoryEntity", "BaseCategoryId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)CategoryFieldIndex.BaseCategoryId, 0, 0, 10);
			this.AddElementFieldInfo("CategoryEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)CategoryFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("CategoryEntity", "Name", typeof(System.String), false, false, false, true,  (int)CategoryFieldIndex.Name, 250, 0, 0);
		}
		/// <summary>Inits CityEntity's FieldInfo objects</summary>
		private void InitCityEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CityFieldIndex), "CityEntity");
			this.AddElementFieldInfo("CityEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)CityFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("CityEntity", "Name", typeof(System.String), false, false, false, true,  (int)CityFieldIndex.Name, 250, 0, 0);
		}
		/// <summary>Inits CommentEntity's FieldInfo objects</summary>
		private void InitCommentEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CommentFieldIndex), "CommentEntity");
			this.AddElementFieldInfo("CommentEntity", "Content", typeof(System.String), false, false, false, true,  (int)CommentFieldIndex.Content, 1000, 0, 0);
			this.AddElementFieldInfo("CommentEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)CommentFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("CommentEntity", "ProductId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)CommentFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("CommentEntity", "RateId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)CommentFieldIndex.RateId, 0, 0, 10);
			this.AddElementFieldInfo("CommentEntity", "Title", typeof(System.String), false, false, false, true,  (int)CommentFieldIndex.Title, 250, 0, 0);
		}
		/// <summary>Inits KeywordEntity's FieldInfo objects</summary>
		private void InitKeywordEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(KeywordFieldIndex), "KeywordEntity");
			this.AddElementFieldInfo("KeywordEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)KeywordFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("KeywordEntity", "Keyword", typeof(System.String), false, false, false, true,  (int)KeywordFieldIndex.Keyword, 150, 0, 0);
		}
		/// <summary>Inits MembershipEntity's FieldInfo objects</summary>
		private void InitMembershipEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(MembershipFieldIndex), "MembershipEntity");
			this.AddElementFieldInfo("MembershipEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)MembershipFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("MembershipEntity", "Password", typeof(System.String), false, false, false, true,  (int)MembershipFieldIndex.Password, 500, 0, 0);
			this.AddElementFieldInfo("MembershipEntity", "Status", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)MembershipFieldIndex.Status, 0, 0, 0);
			this.AddElementFieldInfo("MembershipEntity", "StoreInformationId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)MembershipFieldIndex.StoreInformationId, 0, 0, 10);
			this.AddElementFieldInfo("MembershipEntity", "UserName", typeof(System.String), false, false, false, true,  (int)MembershipFieldIndex.UserName, 250, 0, 0);
		}
		/// <summary>Inits ProductEntity's FieldInfo objects</summary>
		private void InitProductEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductFieldIndex), "ProductEntity");
			this.AddElementFieldInfo("ProductEntity", "AddedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductFieldIndex.AddedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "BrandId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ProductFieldIndex.BrandId, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "CategoryId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ProductFieldIndex.CategoryId, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "DetailDescription", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.DetailDescription, 2147483647, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)ProductFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "IsFreeShipping", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)ProductFieldIndex.IsFreeShipping, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "IsNewItem", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)ProductFieldIndex.IsNewItem, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "IsSliderProduct", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)ProductFieldIndex.IsSliderProduct, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "IsSpeacialProduct", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)ProductFieldIndex.IsSpeacialProduct, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "Price", typeof(Nullable<System.Double>), false, false, false, true,  (int)ProductFieldIndex.Price, 0, 0, 38);
			this.AddElementFieldInfo("ProductEntity", "RedirectUrl", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.RedirectUrl, 500, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "Status", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)ProductFieldIndex.Status, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "StoreId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ProductFieldIndex.StoreId, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "Title", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.Title, 500, 0, 0);
		}
		/// <summary>Inits ProductKeywordEntity's FieldInfo objects</summary>
		private void InitProductKeywordEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductKeywordFieldIndex), "ProductKeywordEntity");
			this.AddElementFieldInfo("ProductKeywordEntity", "KeywordId", typeof(System.Int32), true, true, false, false,  (int)ProductKeywordFieldIndex.KeywordId, 0, 0, 10);
			this.AddElementFieldInfo("ProductKeywordEntity", "ProductId", typeof(System.Int32), true, true, false, false,  (int)ProductKeywordFieldIndex.ProductId, 0, 0, 10);
		}
		/// <summary>Inits ProductPhotoEntity's FieldInfo objects</summary>
		private void InitProductPhotoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductPhotoFieldIndex), "ProductPhotoEntity");
			this.AddElementFieldInfo("ProductPhotoEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)ProductPhotoFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("ProductPhotoEntity", "ProductId", typeof(System.Int32), false, true, false, false,  (int)ProductPhotoFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("ProductPhotoEntity", "UniqueName", typeof(System.String), false, false, false, true,  (int)ProductPhotoFieldIndex.UniqueName, 500, 0, 0);
		}
		/// <summary>Inits ProductSpecificationEntity's FieldInfo objects</summary>
		private void InitProductSpecificationEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductSpecificationFieldIndex), "ProductSpecificationEntity");
			this.AddElementFieldInfo("ProductSpecificationEntity", "ProductId", typeof(System.Int32), true, true, false, false,  (int)ProductSpecificationFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("ProductSpecificationEntity", "SpecificationName", typeof(System.String), true, false, false, false,  (int)ProductSpecificationFieldIndex.SpecificationName, 150, 0, 0);
			this.AddElementFieldInfo("ProductSpecificationEntity", "SpecificationValue", typeof(System.String), false, false, false, true,  (int)ProductSpecificationFieldIndex.SpecificationValue, 250, 0, 0);
		}
		/// <summary>Inits RateEntity's FieldInfo objects</summary>
		private void InitRateEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(RateFieldIndex), "RateEntity");
			this.AddElementFieldInfo("RateEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)RateFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("RateEntity", "Value", typeof(Nullable<System.Int32>), false, false, false, true,  (int)RateFieldIndex.Value, 0, 0, 10);
		}
		/// <summary>Inits StoreEntity's FieldInfo objects</summary>
		private void InitStoreEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(StoreFieldIndex), "StoreEntity");
			this.AddElementFieldInfo("StoreEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)StoreFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("StoreEntity", "MembershipId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)StoreFieldIndex.MembershipId, 0, 0, 10);
			this.AddElementFieldInfo("StoreEntity", "Name", typeof(System.String), false, false, false, true,  (int)StoreFieldIndex.Name, 250, 0, 0);
		}
		/// <summary>Inits StoreInformationEntity's FieldInfo objects</summary>
		private void InitStoreInformationEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(StoreInformationFieldIndex), "StoreInformationEntity");
			this.AddElementFieldInfo("StoreInformationEntity", "Address", typeof(System.String), false, false, false, true,  (int)StoreInformationFieldIndex.Address, 2147483647, 0, 0);
			this.AddElementFieldInfo("StoreInformationEntity", "AuthorizedName", typeof(System.String), false, false, false, true,  (int)StoreInformationFieldIndex.AuthorizedName, 250, 0, 0);
			this.AddElementFieldInfo("StoreInformationEntity", "CityId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)StoreInformationFieldIndex.CityId, 0, 0, 10);
			this.AddElementFieldInfo("StoreInformationEntity", "Email", typeof(System.String), false, false, false, true,  (int)StoreInformationFieldIndex.Email, 250, 0, 0);
			this.AddElementFieldInfo("StoreInformationEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)StoreInformationFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("StoreInformationEntity", "Telephone", typeof(System.String), false, false, false, true,  (int)StoreInformationFieldIndex.Telephone, 250, 0, 0);
			this.AddElementFieldInfo("StoreInformationEntity", "WebAddress", typeof(System.String), false, false, false, true,  (int)StoreInformationFieldIndex.WebAddress, 250, 0, 0);
		}
		
	}
}




