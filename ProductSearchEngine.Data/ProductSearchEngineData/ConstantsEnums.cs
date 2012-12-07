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

namespace ProductSearchEngine
{
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Brand.</summary>
	public enum BrandFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Name. </summary>
		Name,
		///<summary>PhotoUniqueName. </summary>
		PhotoUniqueName,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Category.</summary>
	public enum CategoryFieldIndex
	{
		///<summary>BaseCategoryId. </summary>
		BaseCategoryId,
		///<summary>Id. </summary>
		Id,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: City.</summary>
	public enum CityFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Comment.</summary>
	public enum CommentFieldIndex
	{
		///<summary>Content. </summary>
		Content,
		///<summary>Id. </summary>
		Id,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>RateId. </summary>
		RateId,
		///<summary>Title. </summary>
		Title,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Keyword.</summary>
	public enum KeywordFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Keyword. </summary>
		Keyword,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Membership.</summary>
	public enum MembershipFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Password. </summary>
		Password,
		///<summary>Status. </summary>
		Status,
		///<summary>StoreInformationId. </summary>
		StoreInformationId,
		///<summary>UserName. </summary>
		UserName,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Product.</summary>
	public enum ProductFieldIndex
	{
		///<summary>AddedDate. </summary>
		AddedDate,
		///<summary>BrandId. </summary>
		BrandId,
		///<summary>CategoryId. </summary>
		CategoryId,
		///<summary>DetailDescription. </summary>
		DetailDescription,
		///<summary>Id. </summary>
		Id,
		///<summary>IsFreeShipping. </summary>
		IsFreeShipping,
		///<summary>IsNewItem. </summary>
		IsNewItem,
		///<summary>IsSliderProduct. </summary>
		IsSliderProduct,
		///<summary>IsSpeacialProduct. </summary>
		IsSpeacialProduct,
		///<summary>Price. </summary>
		Price,
		///<summary>RedirectUrl. </summary>
		RedirectUrl,
		///<summary>Status. </summary>
		Status,
		///<summary>StoreId. </summary>
		StoreId,
		///<summary>Title. </summary>
		Title,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductKeyword.</summary>
	public enum ProductKeywordFieldIndex
	{
		///<summary>KeywordId. </summary>
		KeywordId,
		///<summary>ProductId. </summary>
		ProductId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductPhoto.</summary>
	public enum ProductPhotoFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>UniqueName. </summary>
		UniqueName,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductSpecification.</summary>
	public enum ProductSpecificationFieldIndex
	{
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>SpecificationName. </summary>
		SpecificationName,
		///<summary>SpecificationValue. </summary>
		SpecificationValue,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Rate.</summary>
	public enum RateFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Value. </summary>
		Value,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Store.</summary>
	public enum StoreFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>MembershipId. </summary>
		MembershipId,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: StoreInformation.</summary>
	public enum StoreInformationFieldIndex
	{
		///<summary>Address. </summary>
		Address,
		///<summary>AuthorizedName. </summary>
		AuthorizedName,
		///<summary>CityId. </summary>
		CityId,
		///<summary>Email. </summary>
		Email,
		///<summary>Id. </summary>
		Id,
		///<summary>Telephone. </summary>
		Telephone,
		///<summary>WebAddress. </summary>
		WebAddress,
		/// <summary></summary>
		AmountOfFields
	}



	/// <summary>Enum definition for all the entity types defined in this namespace. Used by the entityfields factory.</summary>
	public enum EntityType
	{
		///<summary>Brand</summary>
		BrandEntity,
		///<summary>Category</summary>
		CategoryEntity,
		///<summary>City</summary>
		CityEntity,
		///<summary>Comment</summary>
		CommentEntity,
		///<summary>Keyword</summary>
		KeywordEntity,
		///<summary>Membership</summary>
		MembershipEntity,
		///<summary>Product</summary>
		ProductEntity,
		///<summary>ProductKeyword</summary>
		ProductKeywordEntity,
		///<summary>ProductPhoto</summary>
		ProductPhotoEntity,
		///<summary>ProductSpecification</summary>
		ProductSpecificationEntity,
		///<summary>Rate</summary>
		RateEntity,
		///<summary>Store</summary>
		StoreEntity,
		///<summary>StoreInformation</summary>
		StoreInformationEntity
	}


	#region Custom ConstantsEnums Code
	
	// __LLBLGENPRO_USER_CODE_REGION_START CustomUserConstants
	// __LLBLGENPRO_USER_CODE_REGION_END
	#endregion

	#region Included code

	#endregion
}

