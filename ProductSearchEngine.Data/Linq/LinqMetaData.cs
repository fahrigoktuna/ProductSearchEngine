///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.1
// Code is generated on: 14 Ocak 2012 Cumartesi 02:54:11
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET35
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using ProductSearchEngine;
using ProductSearchEngine.DaoClasses;
using ProductSearchEngine.EntityClasses;
using ProductSearchEngine.FactoryClasses;
using ProductSearchEngine.HelperClasses;
using ProductSearchEngine.RelationClasses;

namespace ProductSearchEngine.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public partial class LinqMetaData : ILinqMetaData
	{
		#region Class Member Declarations
		private ITransaction _transactionToUse;
		private FunctionMappingStore _customFunctionMappings;
		private Context _contextToUse;
		#endregion
		
		/// <summary>CTor. Using this ctor will leave the transaction object to use empty. This is ok if you're not executing queries created with this
		/// meta data inside a transaction. If you're executing the queries created with this meta-data inside a transaction, either set the Transaction property
		/// on the IQueryable.Provider instance of the created LLBLGenProQuery object prior to execution or use the ctor which accepts a transaction object.</summary>
		public LinqMetaData() : this(null, null)
		{
		}
		
		/// <summary>CTor. If you're executing the queries created with this meta-data inside a transaction, pass a live ITransaction object to this ctor.</summary>
		/// <param name="transactionToUse">the transaction to use in queries created with this meta-data</param>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(ITransaction transactionToUse) : this(transactionToUse, null)
		{
		}
		
		/// <summary>CTor. If you're executing the queries created with this meta-data inside a transaction, pass a live ITransaction object to this ctor.</summary>
		/// <param name="transactionToUse">the transaction to use in queries created with this meta-data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(ITransaction transactionToUse, FunctionMappingStore customFunctionMappings)
		{
			_transactionToUse = transactionToUse;
			_customFunctionMappings = customFunctionMappings;
		}
		
		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
		/// <returns>the requested datasource</returns>
		public IDataSource GetQueryableForEntity(int typeOfEntity)
		{
			IDataSource toReturn = null;
			switch((ProductSearchEngine.EntityType)typeOfEntity)
			{
				case ProductSearchEngine.EntityType.BrandEntity:
					toReturn = this.Brand;
					break;
				case ProductSearchEngine.EntityType.CategoryEntity:
					toReturn = this.Category;
					break;
				case ProductSearchEngine.EntityType.CityEntity:
					toReturn = this.City;
					break;
				case ProductSearchEngine.EntityType.CommentEntity:
					toReturn = this.Comment;
					break;
				case ProductSearchEngine.EntityType.KeywordEntity:
					toReturn = this.Keyword;
					break;
				case ProductSearchEngine.EntityType.LastViewedProductEntity:
					toReturn = this.LastViewedProduct;
					break;
				case ProductSearchEngine.EntityType.MembershipEntity:
					toReturn = this.Membership;
					break;
				case ProductSearchEngine.EntityType.ProductEntity:
					toReturn = this.Product;
					break;
				case ProductSearchEngine.EntityType.ProductKeywordEntity:
					toReturn = this.ProductKeyword;
					break;
				case ProductSearchEngine.EntityType.ProductPhotoEntity:
					toReturn = this.ProductPhoto;
					break;
				case ProductSearchEngine.EntityType.ProductSpecificationEntity:
					toReturn = this.ProductSpecification;
					break;
				case ProductSearchEngine.EntityType.RateEntity:
					toReturn = this.Rate;
					break;
				case ProductSearchEngine.EntityType.RoleEntity:
					toReturn = this.Role;
					break;
				case ProductSearchEngine.EntityType.StoreEntity:
					toReturn = this.Store;
					break;
				case ProductSearchEngine.EntityType.StoreInformationEntity:
					toReturn = this.StoreInformation;
					break;
				case ProductSearchEngine.EntityType.WebTrackerEntity:
					toReturn = this.WebTracker;
					break;
				default:
					toReturn = null;
					break;
			}
			return toReturn;
		}

		/// <summary>returns the datasource to use in a Linq query when targeting BrandEntity instances in the database.</summary>
		public DataSource<BrandEntity> Brand
		{
			get { return new DataSource<BrandEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CategoryEntity instances in the database.</summary>
		public DataSource<CategoryEntity> Category
		{
			get { return new DataSource<CategoryEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CityEntity instances in the database.</summary>
		public DataSource<CityEntity> City
		{
			get { return new DataSource<CityEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CommentEntity instances in the database.</summary>
		public DataSource<CommentEntity> Comment
		{
			get { return new DataSource<CommentEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting KeywordEntity instances in the database.</summary>
		public DataSource<KeywordEntity> Keyword
		{
			get { return new DataSource<KeywordEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting LastViewedProductEntity instances in the database.</summary>
		public DataSource<LastViewedProductEntity> LastViewedProduct
		{
			get { return new DataSource<LastViewedProductEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting MembershipEntity instances in the database.</summary>
		public DataSource<MembershipEntity> Membership
		{
			get { return new DataSource<MembershipEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductEntity instances in the database.</summary>
		public DataSource<ProductEntity> Product
		{
			get { return new DataSource<ProductEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductKeywordEntity instances in the database.</summary>
		public DataSource<ProductKeywordEntity> ProductKeyword
		{
			get { return new DataSource<ProductKeywordEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductPhotoEntity instances in the database.</summary>
		public DataSource<ProductPhotoEntity> ProductPhoto
		{
			get { return new DataSource<ProductPhotoEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductSpecificationEntity instances in the database.</summary>
		public DataSource<ProductSpecificationEntity> ProductSpecification
		{
			get { return new DataSource<ProductSpecificationEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting RateEntity instances in the database.</summary>
		public DataSource<RateEntity> Rate
		{
			get { return new DataSource<RateEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting RoleEntity instances in the database.</summary>
		public DataSource<RoleEntity> Role
		{
			get { return new DataSource<RoleEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting StoreEntity instances in the database.</summary>
		public DataSource<StoreEntity> Store
		{
			get { return new DataSource<StoreEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting StoreInformationEntity instances in the database.</summary>
		public DataSource<StoreInformationEntity> StoreInformation
		{
			get { return new DataSource<StoreInformationEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting WebTrackerEntity instances in the database.</summary>
		public DataSource<WebTrackerEntity> WebTracker
		{
			get { return new DataSource<WebTrackerEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		#region Class Property Declarations
		/// <summary> Gets / sets the ITransaction to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public ITransaction TransactionToUse
		{
			get { return _transactionToUse;}
			set { _transactionToUse = value;}
		}

		/// <summary>Gets or sets the custom function mappings to use. These take higher precedence than the ones in the DQE to use</summary>
		public FunctionMappingStore CustomFunctionMappings
		{
			get { return _customFunctionMappings; }
			set { _customFunctionMappings = value; }
		}
		
		/// <summary>Gets or sets the Context instance to use for entity fetches.</summary>
		public Context ContextToUse
		{
			get { return _contextToUse;}
			set { _contextToUse = value;}
		}
		#endregion
	}
}