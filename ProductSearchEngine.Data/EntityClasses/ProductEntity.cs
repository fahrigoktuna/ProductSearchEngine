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
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Data;
using System.Xml.Serialization;
using ProductSearchEngine;
using ProductSearchEngine.FactoryClasses;
using ProductSearchEngine.DaoClasses;
using ProductSearchEngine.RelationClasses;
using ProductSearchEngine.HelperClasses;
using ProductSearchEngine.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ProductSearchEngine.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'Product'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class ProductEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ProductSearchEngine.CollectionClasses.CommentCollection	_comments;
		private bool	_alwaysFetchComments, _alreadyFetchedComments;
		private ProductSearchEngine.CollectionClasses.LastViewedProductCollection	_lastViewedProducts;
		private bool	_alwaysFetchLastViewedProducts, _alreadyFetchedLastViewedProducts;
		private ProductSearchEngine.CollectionClasses.ProductKeywordCollection	_productKeywords;
		private bool	_alwaysFetchProductKeywords, _alreadyFetchedProductKeywords;
		private ProductSearchEngine.CollectionClasses.ProductPhotoCollection	_productPhotos;
		private bool	_alwaysFetchProductPhotos, _alreadyFetchedProductPhotos;
		private ProductSearchEngine.CollectionClasses.ProductSpecificationCollection	_productSpecifications;
		private bool	_alwaysFetchProductSpecifications, _alreadyFetchedProductSpecifications;
		private BrandEntity _brand;
		private bool	_alwaysFetchBrand, _alreadyFetchedBrand, _brandReturnsNewIfNotFound;
		private CategoryEntity _category;
		private bool	_alwaysFetchCategory, _alreadyFetchedCategory, _categoryReturnsNewIfNotFound;
		private StoreEntity _store;
		private bool	_alwaysFetchStore, _alreadyFetchedStore, _storeReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Brand</summary>
			public static readonly string Brand = "Brand";
			/// <summary>Member name Category</summary>
			public static readonly string Category = "Category";
			/// <summary>Member name Store</summary>
			public static readonly string Store = "Store";
			/// <summary>Member name Comments</summary>
			public static readonly string Comments = "Comments";
			/// <summary>Member name LastViewedProducts</summary>
			public static readonly string LastViewedProducts = "LastViewedProducts";
			/// <summary>Member name ProductKeywords</summary>
			public static readonly string ProductKeywords = "ProductKeywords";
			/// <summary>Member name ProductPhotos</summary>
			public static readonly string ProductPhotos = "ProductPhotos";
			/// <summary>Member name ProductSpecifications</summary>
			public static readonly string ProductSpecifications = "ProductSpecifications";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ProductEntity() : base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="id">PK value for Product which data should be fetched into this Product object</param>
		public ProductEntity(System.Int32 id)
		{
			InitClassFetch(id, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ProductEntity(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(id, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The custom validator object for this ProductEntity</param>
		public ProductEntity(System.Int32 id, IValidator validator)
		{
			InitClassFetch(id, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_comments = (ProductSearchEngine.CollectionClasses.CommentCollection)info.GetValue("_comments", typeof(ProductSearchEngine.CollectionClasses.CommentCollection));
			_alwaysFetchComments = info.GetBoolean("_alwaysFetchComments");
			_alreadyFetchedComments = info.GetBoolean("_alreadyFetchedComments");

			_lastViewedProducts = (ProductSearchEngine.CollectionClasses.LastViewedProductCollection)info.GetValue("_lastViewedProducts", typeof(ProductSearchEngine.CollectionClasses.LastViewedProductCollection));
			_alwaysFetchLastViewedProducts = info.GetBoolean("_alwaysFetchLastViewedProducts");
			_alreadyFetchedLastViewedProducts = info.GetBoolean("_alreadyFetchedLastViewedProducts");

			_productKeywords = (ProductSearchEngine.CollectionClasses.ProductKeywordCollection)info.GetValue("_productKeywords", typeof(ProductSearchEngine.CollectionClasses.ProductKeywordCollection));
			_alwaysFetchProductKeywords = info.GetBoolean("_alwaysFetchProductKeywords");
			_alreadyFetchedProductKeywords = info.GetBoolean("_alreadyFetchedProductKeywords");

			_productPhotos = (ProductSearchEngine.CollectionClasses.ProductPhotoCollection)info.GetValue("_productPhotos", typeof(ProductSearchEngine.CollectionClasses.ProductPhotoCollection));
			_alwaysFetchProductPhotos = info.GetBoolean("_alwaysFetchProductPhotos");
			_alreadyFetchedProductPhotos = info.GetBoolean("_alreadyFetchedProductPhotos");

			_productSpecifications = (ProductSearchEngine.CollectionClasses.ProductSpecificationCollection)info.GetValue("_productSpecifications", typeof(ProductSearchEngine.CollectionClasses.ProductSpecificationCollection));
			_alwaysFetchProductSpecifications = info.GetBoolean("_alwaysFetchProductSpecifications");
			_alreadyFetchedProductSpecifications = info.GetBoolean("_alreadyFetchedProductSpecifications");
			_brand = (BrandEntity)info.GetValue("_brand", typeof(BrandEntity));
			if(_brand!=null)
			{
				_brand.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_brandReturnsNewIfNotFound = info.GetBoolean("_brandReturnsNewIfNotFound");
			_alwaysFetchBrand = info.GetBoolean("_alwaysFetchBrand");
			_alreadyFetchedBrand = info.GetBoolean("_alreadyFetchedBrand");

			_category = (CategoryEntity)info.GetValue("_category", typeof(CategoryEntity));
			if(_category!=null)
			{
				_category.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_categoryReturnsNewIfNotFound = info.GetBoolean("_categoryReturnsNewIfNotFound");
			_alwaysFetchCategory = info.GetBoolean("_alwaysFetchCategory");
			_alreadyFetchedCategory = info.GetBoolean("_alreadyFetchedCategory");

			_store = (StoreEntity)info.GetValue("_store", typeof(StoreEntity));
			if(_store!=null)
			{
				_store.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_storeReturnsNewIfNotFound = info.GetBoolean("_storeReturnsNewIfNotFound");
			_alwaysFetchStore = info.GetBoolean("_alwaysFetchStore");
			_alreadyFetchedStore = info.GetBoolean("_alreadyFetchedStore");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ProductFieldIndex)fieldIndex)
			{
				case ProductFieldIndex.BrandId:
					DesetupSyncBrand(true, false);
					_alreadyFetchedBrand = false;
					break;
				case ProductFieldIndex.CategoryId:
					DesetupSyncCategory(true, false);
					_alreadyFetchedCategory = false;
					break;
				case ProductFieldIndex.StoreId:
					DesetupSyncStore(true, false);
					_alreadyFetchedStore = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedComments = (_comments.Count > 0);
			_alreadyFetchedLastViewedProducts = (_lastViewedProducts.Count > 0);
			_alreadyFetchedProductKeywords = (_productKeywords.Count > 0);
			_alreadyFetchedProductPhotos = (_productPhotos.Count > 0);
			_alreadyFetchedProductSpecifications = (_productSpecifications.Count > 0);
			_alreadyFetchedBrand = (_brand != null);
			_alreadyFetchedCategory = (_category != null);
			_alreadyFetchedStore = (_store != null);
		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Brand":
					toReturn.Add(Relations.BrandEntityUsingBrandId);
					break;
				case "Category":
					toReturn.Add(Relations.CategoryEntityUsingCategoryId);
					break;
				case "Store":
					toReturn.Add(Relations.StoreEntityUsingStoreId);
					break;
				case "Comments":
					toReturn.Add(Relations.CommentEntityUsingProductId);
					break;
				case "LastViewedProducts":
					toReturn.Add(Relations.LastViewedProductEntityUsingProductId);
					break;
				case "ProductKeywords":
					toReturn.Add(Relations.ProductKeywordEntityUsingProductId);
					break;
				case "ProductPhotos":
					toReturn.Add(Relations.ProductPhotoEntityUsingProductId);
					break;
				case "ProductSpecifications":
					toReturn.Add(Relations.ProductSpecificationEntityUsingProductId);
					break;
				default:
					break;				
			}
			return toReturn;
		}



		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_comments", (!this.MarkedForDeletion?_comments:null));
			info.AddValue("_alwaysFetchComments", _alwaysFetchComments);
			info.AddValue("_alreadyFetchedComments", _alreadyFetchedComments);
			info.AddValue("_lastViewedProducts", (!this.MarkedForDeletion?_lastViewedProducts:null));
			info.AddValue("_alwaysFetchLastViewedProducts", _alwaysFetchLastViewedProducts);
			info.AddValue("_alreadyFetchedLastViewedProducts", _alreadyFetchedLastViewedProducts);
			info.AddValue("_productKeywords", (!this.MarkedForDeletion?_productKeywords:null));
			info.AddValue("_alwaysFetchProductKeywords", _alwaysFetchProductKeywords);
			info.AddValue("_alreadyFetchedProductKeywords", _alreadyFetchedProductKeywords);
			info.AddValue("_productPhotos", (!this.MarkedForDeletion?_productPhotos:null));
			info.AddValue("_alwaysFetchProductPhotos", _alwaysFetchProductPhotos);
			info.AddValue("_alreadyFetchedProductPhotos", _alreadyFetchedProductPhotos);
			info.AddValue("_productSpecifications", (!this.MarkedForDeletion?_productSpecifications:null));
			info.AddValue("_alwaysFetchProductSpecifications", _alwaysFetchProductSpecifications);
			info.AddValue("_alreadyFetchedProductSpecifications", _alreadyFetchedProductSpecifications);
			info.AddValue("_brand", (!this.MarkedForDeletion?_brand:null));
			info.AddValue("_brandReturnsNewIfNotFound", _brandReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchBrand", _alwaysFetchBrand);
			info.AddValue("_alreadyFetchedBrand", _alreadyFetchedBrand);
			info.AddValue("_category", (!this.MarkedForDeletion?_category:null));
			info.AddValue("_categoryReturnsNewIfNotFound", _categoryReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCategory", _alwaysFetchCategory);
			info.AddValue("_alreadyFetchedCategory", _alreadyFetchedCategory);
			info.AddValue("_store", (!this.MarkedForDeletion?_store:null));
			info.AddValue("_storeReturnsNewIfNotFound", _storeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchStore", _alwaysFetchStore);
			info.AddValue("_alreadyFetchedStore", _alreadyFetchedStore);

			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntityProperty(string propertyName, IEntity entity)
		{
			switch(propertyName)
			{
				case "Brand":
					_alreadyFetchedBrand = true;
					this.Brand = (BrandEntity)entity;
					break;
				case "Category":
					_alreadyFetchedCategory = true;
					this.Category = (CategoryEntity)entity;
					break;
				case "Store":
					_alreadyFetchedStore = true;
					this.Store = (StoreEntity)entity;
					break;
				case "Comments":
					_alreadyFetchedComments = true;
					if(entity!=null)
					{
						this.Comments.Add((CommentEntity)entity);
					}
					break;
				case "LastViewedProducts":
					_alreadyFetchedLastViewedProducts = true;
					if(entity!=null)
					{
						this.LastViewedProducts.Add((LastViewedProductEntity)entity);
					}
					break;
				case "ProductKeywords":
					_alreadyFetchedProductKeywords = true;
					if(entity!=null)
					{
						this.ProductKeywords.Add((ProductKeywordEntity)entity);
					}
					break;
				case "ProductPhotos":
					_alreadyFetchedProductPhotos = true;
					if(entity!=null)
					{
						this.ProductPhotos.Add((ProductPhotoEntity)entity);
					}
					break;
				case "ProductSpecifications":
					_alreadyFetchedProductSpecifications = true;
					if(entity!=null)
					{
						this.ProductSpecifications.Add((ProductSpecificationEntity)entity);
					}
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "Brand":
					SetupSyncBrand(relatedEntity);
					break;
				case "Category":
					SetupSyncCategory(relatedEntity);
					break;
				case "Store":
					SetupSyncStore(relatedEntity);
					break;
				case "Comments":
					_comments.Add((CommentEntity)relatedEntity);
					break;
				case "LastViewedProducts":
					_lastViewedProducts.Add((LastViewedProductEntity)relatedEntity);
					break;
				case "ProductKeywords":
					_productKeywords.Add((ProductKeywordEntity)relatedEntity);
					break;
				case "ProductPhotos":
					_productPhotos.Add((ProductPhotoEntity)relatedEntity);
					break;
				case "ProductSpecifications":
					_productSpecifications.Add((ProductSpecificationEntity)relatedEntity);
					break;
				default:
					break;
			}
		}
		
		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "Brand":
					DesetupSyncBrand(false, true);
					break;
				case "Category":
					DesetupSyncCategory(false, true);
					break;
				case "Store":
					DesetupSyncStore(false, true);
					break;
				case "Comments":
					this.PerformRelatedEntityRemoval(_comments, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "LastViewedProducts":
					this.PerformRelatedEntityRemoval(_lastViewedProducts, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductKeywords":
					this.PerformRelatedEntityRemoval(_productKeywords, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductPhotos":
					this.PerformRelatedEntityRemoval(_productPhotos, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductSpecifications":
					this.PerformRelatedEntityRemoval(_productSpecifications, relatedEntity, signalRelatedEntityManyToOne);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			if(_brand!=null)
			{
				toReturn.Add(_brand);
			}
			if(_category!=null)
			{
				toReturn.Add(_category);
			}
			if(_store!=null)
			{
				toReturn.Add(_store);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_comments);
			toReturn.Add(_lastViewedProducts);
			toReturn.Add(_productKeywords);
			toReturn.Add(_productPhotos);
			toReturn.Add(_productSpecifications);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Product which data should be fetched into this Product object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id)
		{
			return FetchUsingPK(id, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(id, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.Id, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new ProductRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'CommentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CommentEntity'</returns>
		public ProductSearchEngine.CollectionClasses.CommentCollection GetMultiComments(bool forceFetch)
		{
			return GetMultiComments(forceFetch, _comments.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CommentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'CommentEntity'</returns>
		public ProductSearchEngine.CollectionClasses.CommentCollection GetMultiComments(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiComments(forceFetch, _comments.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'CommentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ProductSearchEngine.CollectionClasses.CommentCollection GetMultiComments(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiComments(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CommentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductSearchEngine.CollectionClasses.CommentCollection GetMultiComments(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedComments || forceFetch || _alwaysFetchComments) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_comments);
				_comments.SuppressClearInGetMulti=!forceFetch;
				_comments.EntityFactoryToUse = entityFactoryToUse;
				_comments.GetMultiManyToOne(this, null, filter);
				_comments.SuppressClearInGetMulti=false;
				_alreadyFetchedComments = true;
			}
			return _comments;
		}

		/// <summary> Sets the collection parameters for the collection for 'Comments'. These settings will be taken into account
		/// when the property Comments is requested or GetMultiComments is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersComments(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_comments.SortClauses=sortClauses;
			_comments.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'LastViewedProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'LastViewedProductEntity'</returns>
		public ProductSearchEngine.CollectionClasses.LastViewedProductCollection GetMultiLastViewedProducts(bool forceFetch)
		{
			return GetMultiLastViewedProducts(forceFetch, _lastViewedProducts.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'LastViewedProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'LastViewedProductEntity'</returns>
		public ProductSearchEngine.CollectionClasses.LastViewedProductCollection GetMultiLastViewedProducts(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiLastViewedProducts(forceFetch, _lastViewedProducts.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'LastViewedProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ProductSearchEngine.CollectionClasses.LastViewedProductCollection GetMultiLastViewedProducts(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiLastViewedProducts(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'LastViewedProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductSearchEngine.CollectionClasses.LastViewedProductCollection GetMultiLastViewedProducts(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedLastViewedProducts || forceFetch || _alwaysFetchLastViewedProducts) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_lastViewedProducts);
				_lastViewedProducts.SuppressClearInGetMulti=!forceFetch;
				_lastViewedProducts.EntityFactoryToUse = entityFactoryToUse;
				_lastViewedProducts.GetMultiManyToOne(this, filter);
				_lastViewedProducts.SuppressClearInGetMulti=false;
				_alreadyFetchedLastViewedProducts = true;
			}
			return _lastViewedProducts;
		}

		/// <summary> Sets the collection parameters for the collection for 'LastViewedProducts'. These settings will be taken into account
		/// when the property LastViewedProducts is requested or GetMultiLastViewedProducts is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersLastViewedProducts(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_lastViewedProducts.SortClauses=sortClauses;
			_lastViewedProducts.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductKeywordEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductKeywordEntity'</returns>
		public ProductSearchEngine.CollectionClasses.ProductKeywordCollection GetMultiProductKeywords(bool forceFetch)
		{
			return GetMultiProductKeywords(forceFetch, _productKeywords.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductKeywordEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductKeywordEntity'</returns>
		public ProductSearchEngine.CollectionClasses.ProductKeywordCollection GetMultiProductKeywords(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductKeywords(forceFetch, _productKeywords.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductKeywordEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ProductSearchEngine.CollectionClasses.ProductKeywordCollection GetMultiProductKeywords(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductKeywords(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductKeywordEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductSearchEngine.CollectionClasses.ProductKeywordCollection GetMultiProductKeywords(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductKeywords || forceFetch || _alwaysFetchProductKeywords) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_productKeywords);
				_productKeywords.SuppressClearInGetMulti=!forceFetch;
				_productKeywords.EntityFactoryToUse = entityFactoryToUse;
				_productKeywords.GetMultiManyToOne(null, this, filter);
				_productKeywords.SuppressClearInGetMulti=false;
				_alreadyFetchedProductKeywords = true;
			}
			return _productKeywords;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductKeywords'. These settings will be taken into account
		/// when the property ProductKeywords is requested or GetMultiProductKeywords is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductKeywords(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productKeywords.SortClauses=sortClauses;
			_productKeywords.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductPhotoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductPhotoEntity'</returns>
		public ProductSearchEngine.CollectionClasses.ProductPhotoCollection GetMultiProductPhotos(bool forceFetch)
		{
			return GetMultiProductPhotos(forceFetch, _productPhotos.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductPhotoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductPhotoEntity'</returns>
		public ProductSearchEngine.CollectionClasses.ProductPhotoCollection GetMultiProductPhotos(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductPhotos(forceFetch, _productPhotos.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductPhotoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ProductSearchEngine.CollectionClasses.ProductPhotoCollection GetMultiProductPhotos(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductPhotos(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductPhotoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductSearchEngine.CollectionClasses.ProductPhotoCollection GetMultiProductPhotos(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductPhotos || forceFetch || _alwaysFetchProductPhotos) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_productPhotos);
				_productPhotos.SuppressClearInGetMulti=!forceFetch;
				_productPhotos.EntityFactoryToUse = entityFactoryToUse;
				_productPhotos.GetMultiManyToOne(this, filter);
				_productPhotos.SuppressClearInGetMulti=false;
				_alreadyFetchedProductPhotos = true;
			}
			return _productPhotos;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductPhotos'. These settings will be taken into account
		/// when the property ProductPhotos is requested or GetMultiProductPhotos is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductPhotos(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productPhotos.SortClauses=sortClauses;
			_productPhotos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductSpecificationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductSpecificationEntity'</returns>
		public ProductSearchEngine.CollectionClasses.ProductSpecificationCollection GetMultiProductSpecifications(bool forceFetch)
		{
			return GetMultiProductSpecifications(forceFetch, _productSpecifications.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductSpecificationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductSpecificationEntity'</returns>
		public ProductSearchEngine.CollectionClasses.ProductSpecificationCollection GetMultiProductSpecifications(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductSpecifications(forceFetch, _productSpecifications.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductSpecificationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ProductSearchEngine.CollectionClasses.ProductSpecificationCollection GetMultiProductSpecifications(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductSpecifications(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductSpecificationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductSearchEngine.CollectionClasses.ProductSpecificationCollection GetMultiProductSpecifications(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductSpecifications || forceFetch || _alwaysFetchProductSpecifications) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_productSpecifications);
				_productSpecifications.SuppressClearInGetMulti=!forceFetch;
				_productSpecifications.EntityFactoryToUse = entityFactoryToUse;
				_productSpecifications.GetMultiManyToOne(this, filter);
				_productSpecifications.SuppressClearInGetMulti=false;
				_alreadyFetchedProductSpecifications = true;
			}
			return _productSpecifications;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductSpecifications'. These settings will be taken into account
		/// when the property ProductSpecifications is requested or GetMultiProductSpecifications is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductSpecifications(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productSpecifications.SortClauses=sortClauses;
			_productSpecifications.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'BrandEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'BrandEntity' which is related to this entity.</returns>
		public BrandEntity GetSingleBrand()
		{
			return GetSingleBrand(false);
		}

		/// <summary> Retrieves the related entity of type 'BrandEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'BrandEntity' which is related to this entity.</returns>
		public virtual BrandEntity GetSingleBrand(bool forceFetch)
		{
			if( ( !_alreadyFetchedBrand || forceFetch || _alwaysFetchBrand) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.BrandEntityUsingBrandId);
				BrandEntity newEntity = new BrandEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.BrandId.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (BrandEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_brandReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Brand = newEntity;
				_alreadyFetchedBrand = fetchResult;
			}
			return _brand;
		}


		/// <summary> Retrieves the related entity of type 'CategoryEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CategoryEntity' which is related to this entity.</returns>
		public CategoryEntity GetSingleCategory()
		{
			return GetSingleCategory(false);
		}

		/// <summary> Retrieves the related entity of type 'CategoryEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CategoryEntity' which is related to this entity.</returns>
		public virtual CategoryEntity GetSingleCategory(bool forceFetch)
		{
			if( ( !_alreadyFetchedCategory || forceFetch || _alwaysFetchCategory) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.CategoryEntityUsingCategoryId);
				CategoryEntity newEntity = new CategoryEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.CategoryId.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (CategoryEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_categoryReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Category = newEntity;
				_alreadyFetchedCategory = fetchResult;
			}
			return _category;
		}


		/// <summary> Retrieves the related entity of type 'StoreEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'StoreEntity' which is related to this entity.</returns>
		public StoreEntity GetSingleStore()
		{
			return GetSingleStore(false);
		}

		/// <summary> Retrieves the related entity of type 'StoreEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'StoreEntity' which is related to this entity.</returns>
		public virtual StoreEntity GetSingleStore(bool forceFetch)
		{
			if( ( !_alreadyFetchedStore || forceFetch || _alwaysFetchStore) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.StoreEntityUsingStoreId);
				StoreEntity newEntity = new StoreEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.StoreId.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (StoreEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_storeReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Store = newEntity;
				_alreadyFetchedStore = fetchResult;
			}
			return _store;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Brand", _brand);
			toReturn.Add("Category", _category);
			toReturn.Add("Store", _store);
			toReturn.Add("Comments", _comments);
			toReturn.Add("LastViewedProducts", _lastViewedProducts);
			toReturn.Add("ProductKeywords", _productKeywords);
			toReturn.Add("ProductPhotos", _productPhotos);
			toReturn.Add("ProductSpecifications", _productSpecifications);
			return toReturn;
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		private void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			this.Fields = CreateFields();
			this.Validator = validatorToUse;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="id">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The validator object for this ProductEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 id, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(id, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_comments = new ProductSearchEngine.CollectionClasses.CommentCollection();
			_comments.SetContainingEntityInfo(this, "Product");

			_lastViewedProducts = new ProductSearchEngine.CollectionClasses.LastViewedProductCollection();
			_lastViewedProducts.SetContainingEntityInfo(this, "Product");

			_productKeywords = new ProductSearchEngine.CollectionClasses.ProductKeywordCollection();
			_productKeywords.SetContainingEntityInfo(this, "Product");

			_productPhotos = new ProductSearchEngine.CollectionClasses.ProductPhotoCollection();
			_productPhotos.SetContainingEntityInfo(this, "Product");

			_productSpecifications = new ProductSearchEngine.CollectionClasses.ProductSpecificationCollection();
			_productSpecifications.SetContainingEntityInfo(this, "Product");
			_brandReturnsNewIfNotFound = false;
			_categoryReturnsNewIfNotFound = false;
			_storeReturnsNewIfNotFound = false;
			PerformDependencyInjection();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AddedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BrandId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CategoryId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DetailDescription", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsFreeShipping", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsNewItem", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsSliderProduct", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsSpeacialProduct", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Price", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RedirectUrl", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Status", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StoreId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Title", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _brand</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncBrand(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _brand, new PropertyChangedEventHandler( OnBrandPropertyChanged ), "Brand", ProductSearchEngine.RelationClasses.StaticProductRelations.BrandEntityUsingBrandIdStatic, true, signalRelatedEntity, "Products", resetFKFields, new int[] { (int)ProductFieldIndex.BrandId } );		
			_brand = null;
		}
		
		/// <summary> setups the sync logic for member _brand</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncBrand(IEntity relatedEntity)
		{
			if(_brand!=relatedEntity)
			{		
				DesetupSyncBrand(true, true);
				_brand = (BrandEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _brand, new PropertyChangedEventHandler( OnBrandPropertyChanged ), "Brand", ProductSearchEngine.RelationClasses.StaticProductRelations.BrandEntityUsingBrandIdStatic, true, ref _alreadyFetchedBrand, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnBrandPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _category</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCategory(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _category, new PropertyChangedEventHandler( OnCategoryPropertyChanged ), "Category", ProductSearchEngine.RelationClasses.StaticProductRelations.CategoryEntityUsingCategoryIdStatic, true, signalRelatedEntity, "Products", resetFKFields, new int[] { (int)ProductFieldIndex.CategoryId } );		
			_category = null;
		}
		
		/// <summary> setups the sync logic for member _category</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCategory(IEntity relatedEntity)
		{
			if(_category!=relatedEntity)
			{		
				DesetupSyncCategory(true, true);
				_category = (CategoryEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _category, new PropertyChangedEventHandler( OnCategoryPropertyChanged ), "Category", ProductSearchEngine.RelationClasses.StaticProductRelations.CategoryEntityUsingCategoryIdStatic, true, ref _alreadyFetchedCategory, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCategoryPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _store</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncStore(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _store, new PropertyChangedEventHandler( OnStorePropertyChanged ), "Store", ProductSearchEngine.RelationClasses.StaticProductRelations.StoreEntityUsingStoreIdStatic, true, signalRelatedEntity, "Products", resetFKFields, new int[] { (int)ProductFieldIndex.StoreId } );		
			_store = null;
		}
		
		/// <summary> setups the sync logic for member _store</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncStore(IEntity relatedEntity)
		{
			if(_store!=relatedEntity)
			{		
				DesetupSyncStore(true, true);
				_store = (StoreEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _store, new PropertyChangedEventHandler( OnStorePropertyChanged ), "Store", ProductSearchEngine.RelationClasses.StaticProductRelations.StoreEntityUsingStoreIdStatic, true, ref _alreadyFetchedStore, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnStorePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="id">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)ProductFieldIndex.Id].ForcedCurrentValueWrite(id);
				CreateDAOInstance().FetchExisting(this, this.Transaction, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (this.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}

		/// <summary> Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateProductDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ProductEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ProductRelations Relations
		{
			get	{ return new ProductRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Comment' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathComments
		{
			get { return new PrefetchPathElement(new ProductSearchEngine.CollectionClasses.CommentCollection(), (IEntityRelation)GetRelationsForField("Comments")[0], (int)ProductSearchEngine.EntityType.ProductEntity, (int)ProductSearchEngine.EntityType.CommentEntity, 0, null, null, null, "Comments", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'LastViewedProduct' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathLastViewedProducts
		{
			get { return new PrefetchPathElement(new ProductSearchEngine.CollectionClasses.LastViewedProductCollection(), (IEntityRelation)GetRelationsForField("LastViewedProducts")[0], (int)ProductSearchEngine.EntityType.ProductEntity, (int)ProductSearchEngine.EntityType.LastViewedProductEntity, 0, null, null, null, "LastViewedProducts", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductKeyword' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductKeywords
		{
			get { return new PrefetchPathElement(new ProductSearchEngine.CollectionClasses.ProductKeywordCollection(), (IEntityRelation)GetRelationsForField("ProductKeywords")[0], (int)ProductSearchEngine.EntityType.ProductEntity, (int)ProductSearchEngine.EntityType.ProductKeywordEntity, 0, null, null, null, "ProductKeywords", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductPhoto' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductPhotos
		{
			get { return new PrefetchPathElement(new ProductSearchEngine.CollectionClasses.ProductPhotoCollection(), (IEntityRelation)GetRelationsForField("ProductPhotos")[0], (int)ProductSearchEngine.EntityType.ProductEntity, (int)ProductSearchEngine.EntityType.ProductPhotoEntity, 0, null, null, null, "ProductPhotos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductSpecification' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductSpecifications
		{
			get { return new PrefetchPathElement(new ProductSearchEngine.CollectionClasses.ProductSpecificationCollection(), (IEntityRelation)GetRelationsForField("ProductSpecifications")[0], (int)ProductSearchEngine.EntityType.ProductEntity, (int)ProductSearchEngine.EntityType.ProductSpecificationEntity, 0, null, null, null, "ProductSpecifications", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Brand'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBrand
		{
			get	{ return new PrefetchPathElement(new ProductSearchEngine.CollectionClasses.BrandCollection(), (IEntityRelation)GetRelationsForField("Brand")[0], (int)ProductSearchEngine.EntityType.ProductEntity, (int)ProductSearchEngine.EntityType.BrandEntity, 0, null, null, null, "Brand", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Category'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCategory
		{
			get	{ return new PrefetchPathElement(new ProductSearchEngine.CollectionClasses.CategoryCollection(), (IEntityRelation)GetRelationsForField("Category")[0], (int)ProductSearchEngine.EntityType.ProductEntity, (int)ProductSearchEngine.EntityType.CategoryEntity, 0, null, null, null, "Category", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Store'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStore
		{
			get	{ return new PrefetchPathElement(new ProductSearchEngine.CollectionClasses.StoreCollection(), (IEntityRelation)GetRelationsForField("Store")[0], (int)ProductSearchEngine.EntityType.ProductEntity, (int)ProductSearchEngine.EntityType.StoreEntity, 0, null, null, null, "Store", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override string LLBLGenProEntityName
		{
			get { return "ProductEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The AddedDate property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."AddedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> AddedDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)ProductFieldIndex.AddedDate, false); }
			set	{ SetValue((int)ProductFieldIndex.AddedDate, value, true); }
		}

		/// <summary> The BrandId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."BrandId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> BrandId
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.BrandId, false); }
			set	{ SetValue((int)ProductFieldIndex.BrandId, value, true); }
		}

		/// <summary> The CategoryId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."CategoryId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> CategoryId
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.CategoryId, false); }
			set	{ SetValue((int)ProductFieldIndex.CategoryId, value, true); }
		}

		/// <summary> The DetailDescription property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."DetailDescription"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String DetailDescription
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.DetailDescription, true); }
			set	{ SetValue((int)ProductFieldIndex.DetailDescription, value, true); }
		}

		/// <summary> The Id property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)ProductFieldIndex.Id, true); }
			set	{ SetValue((int)ProductFieldIndex.Id, value, true); }
		}

		/// <summary> The IsFreeShipping property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."IsFreeShipping"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> IsFreeShipping
		{
			get { return (Nullable<System.Boolean>)GetValue((int)ProductFieldIndex.IsFreeShipping, false); }
			set	{ SetValue((int)ProductFieldIndex.IsFreeShipping, value, true); }
		}

		/// <summary> The IsNewItem property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."IsNewItem"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> IsNewItem
		{
			get { return (Nullable<System.Boolean>)GetValue((int)ProductFieldIndex.IsNewItem, false); }
			set	{ SetValue((int)ProductFieldIndex.IsNewItem, value, true); }
		}

		/// <summary> The IsSliderProduct property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."IsSliderProduct"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> IsSliderProduct
		{
			get { return (Nullable<System.Boolean>)GetValue((int)ProductFieldIndex.IsSliderProduct, false); }
			set	{ SetValue((int)ProductFieldIndex.IsSliderProduct, value, true); }
		}

		/// <summary> The IsSpeacialProduct property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."IsSpeacialProduct"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> IsSpeacialProduct
		{
			get { return (Nullable<System.Boolean>)GetValue((int)ProductFieldIndex.IsSpeacialProduct, false); }
			set	{ SetValue((int)ProductFieldIndex.IsSpeacialProduct, value, true); }
		}

		/// <summary> The Price property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Price"<br/>
		/// Table field type characteristics (type, precision, scale, length): Float, 38, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Double> Price
		{
			get { return (Nullable<System.Double>)GetValue((int)ProductFieldIndex.Price, false); }
			set	{ SetValue((int)ProductFieldIndex.Price, value, true); }
		}

		/// <summary> The RedirectUrl property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."RedirectUrl"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String RedirectUrl
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.RedirectUrl, true); }
			set	{ SetValue((int)ProductFieldIndex.RedirectUrl, value, true); }
		}

		/// <summary> The Status property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Status"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Status
		{
			get { return (Nullable<System.Boolean>)GetValue((int)ProductFieldIndex.Status, false); }
			set	{ SetValue((int)ProductFieldIndex.Status, value, true); }
		}

		/// <summary> The StoreId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."StoreId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> StoreId
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.StoreId, false); }
			set	{ SetValue((int)ProductFieldIndex.StoreId, value, true); }
		}

		/// <summary> The Title property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Title"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Title, true); }
			set	{ SetValue((int)ProductFieldIndex.Title, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'CommentEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiComments()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ProductSearchEngine.CollectionClasses.CommentCollection Comments
		{
			get	{ return GetMultiComments(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Comments. When set to true, Comments is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Comments is accessed. You can always execute/ a forced fetch by calling GetMultiComments(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchComments
		{
			get	{ return _alwaysFetchComments; }
			set	{ _alwaysFetchComments = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Comments already has been fetched. Setting this property to false when Comments has been fetched
		/// will clear the Comments collection well. Setting this property to true while Comments hasn't been fetched disables lazy loading for Comments</summary>
		[Browsable(false)]
		public bool AlreadyFetchedComments
		{
			get { return _alreadyFetchedComments;}
			set 
			{
				if(_alreadyFetchedComments && !value && (_comments != null))
				{
					_comments.Clear();
				}
				_alreadyFetchedComments = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'LastViewedProductEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiLastViewedProducts()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ProductSearchEngine.CollectionClasses.LastViewedProductCollection LastViewedProducts
		{
			get	{ return GetMultiLastViewedProducts(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for LastViewedProducts. When set to true, LastViewedProducts is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time LastViewedProducts is accessed. You can always execute/ a forced fetch by calling GetMultiLastViewedProducts(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchLastViewedProducts
		{
			get	{ return _alwaysFetchLastViewedProducts; }
			set	{ _alwaysFetchLastViewedProducts = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property LastViewedProducts already has been fetched. Setting this property to false when LastViewedProducts has been fetched
		/// will clear the LastViewedProducts collection well. Setting this property to true while LastViewedProducts hasn't been fetched disables lazy loading for LastViewedProducts</summary>
		[Browsable(false)]
		public bool AlreadyFetchedLastViewedProducts
		{
			get { return _alreadyFetchedLastViewedProducts;}
			set 
			{
				if(_alreadyFetchedLastViewedProducts && !value && (_lastViewedProducts != null))
				{
					_lastViewedProducts.Clear();
				}
				_alreadyFetchedLastViewedProducts = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductKeywordEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductKeywords()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ProductSearchEngine.CollectionClasses.ProductKeywordCollection ProductKeywords
		{
			get	{ return GetMultiProductKeywords(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductKeywords. When set to true, ProductKeywords is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductKeywords is accessed. You can always execute/ a forced fetch by calling GetMultiProductKeywords(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductKeywords
		{
			get	{ return _alwaysFetchProductKeywords; }
			set	{ _alwaysFetchProductKeywords = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductKeywords already has been fetched. Setting this property to false when ProductKeywords has been fetched
		/// will clear the ProductKeywords collection well. Setting this property to true while ProductKeywords hasn't been fetched disables lazy loading for ProductKeywords</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductKeywords
		{
			get { return _alreadyFetchedProductKeywords;}
			set 
			{
				if(_alreadyFetchedProductKeywords && !value && (_productKeywords != null))
				{
					_productKeywords.Clear();
				}
				_alreadyFetchedProductKeywords = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductPhotoEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductPhotos()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ProductSearchEngine.CollectionClasses.ProductPhotoCollection ProductPhotos
		{
			get	{ return GetMultiProductPhotos(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductPhotos. When set to true, ProductPhotos is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductPhotos is accessed. You can always execute/ a forced fetch by calling GetMultiProductPhotos(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductPhotos
		{
			get	{ return _alwaysFetchProductPhotos; }
			set	{ _alwaysFetchProductPhotos = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductPhotos already has been fetched. Setting this property to false when ProductPhotos has been fetched
		/// will clear the ProductPhotos collection well. Setting this property to true while ProductPhotos hasn't been fetched disables lazy loading for ProductPhotos</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductPhotos
		{
			get { return _alreadyFetchedProductPhotos;}
			set 
			{
				if(_alreadyFetchedProductPhotos && !value && (_productPhotos != null))
				{
					_productPhotos.Clear();
				}
				_alreadyFetchedProductPhotos = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductSpecificationEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductSpecifications()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ProductSearchEngine.CollectionClasses.ProductSpecificationCollection ProductSpecifications
		{
			get	{ return GetMultiProductSpecifications(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductSpecifications. When set to true, ProductSpecifications is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductSpecifications is accessed. You can always execute/ a forced fetch by calling GetMultiProductSpecifications(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductSpecifications
		{
			get	{ return _alwaysFetchProductSpecifications; }
			set	{ _alwaysFetchProductSpecifications = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductSpecifications already has been fetched. Setting this property to false when ProductSpecifications has been fetched
		/// will clear the ProductSpecifications collection well. Setting this property to true while ProductSpecifications hasn't been fetched disables lazy loading for ProductSpecifications</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductSpecifications
		{
			get { return _alreadyFetchedProductSpecifications;}
			set 
			{
				if(_alreadyFetchedProductSpecifications && !value && (_productSpecifications != null))
				{
					_productSpecifications.Clear();
				}
				_alreadyFetchedProductSpecifications = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'BrandEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleBrand()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual BrandEntity Brand
		{
			get	{ return GetSingleBrand(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncBrand(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Products", "Brand", _brand, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Brand. When set to true, Brand is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Brand is accessed. You can always execute a forced fetch by calling GetSingleBrand(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchBrand
		{
			get	{ return _alwaysFetchBrand; }
			set	{ _alwaysFetchBrand = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Brand already has been fetched. Setting this property to false when Brand has been fetched
		/// will set Brand to null as well. Setting this property to true while Brand hasn't been fetched disables lazy loading for Brand</summary>
		[Browsable(false)]
		public bool AlreadyFetchedBrand
		{
			get { return _alreadyFetchedBrand;}
			set 
			{
				if(_alreadyFetchedBrand && !value)
				{
					this.Brand = null;
				}
				_alreadyFetchedBrand = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Brand is not found
		/// in the database. When set to true, Brand will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool BrandReturnsNewIfNotFound
		{
			get	{ return _brandReturnsNewIfNotFound; }
			set { _brandReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'CategoryEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCategory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CategoryEntity Category
		{
			get	{ return GetSingleCategory(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncCategory(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Products", "Category", _category, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Category. When set to true, Category is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Category is accessed. You can always execute a forced fetch by calling GetSingleCategory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCategory
		{
			get	{ return _alwaysFetchCategory; }
			set	{ _alwaysFetchCategory = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Category already has been fetched. Setting this property to false when Category has been fetched
		/// will set Category to null as well. Setting this property to true while Category hasn't been fetched disables lazy loading for Category</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCategory
		{
			get { return _alreadyFetchedCategory;}
			set 
			{
				if(_alreadyFetchedCategory && !value)
				{
					this.Category = null;
				}
				_alreadyFetchedCategory = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Category is not found
		/// in the database. When set to true, Category will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool CategoryReturnsNewIfNotFound
		{
			get	{ return _categoryReturnsNewIfNotFound; }
			set { _categoryReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'StoreEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleStore()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual StoreEntity Store
		{
			get	{ return GetSingleStore(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncStore(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Products", "Store", _store, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Store. When set to true, Store is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Store is accessed. You can always execute a forced fetch by calling GetSingleStore(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchStore
		{
			get	{ return _alwaysFetchStore; }
			set	{ _alwaysFetchStore = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Store already has been fetched. Setting this property to false when Store has been fetched
		/// will set Store to null as well. Setting this property to true while Store hasn't been fetched disables lazy loading for Store</summary>
		[Browsable(false)]
		public bool AlreadyFetchedStore
		{
			get { return _alreadyFetchedStore;}
			set 
			{
				if(_alreadyFetchedStore && !value)
				{
					this.Store = null;
				}
				_alreadyFetchedStore = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Store is not found
		/// in the database. When set to true, Store will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool StoreReturnsNewIfNotFound
		{
			get	{ return _storeReturnsNewIfNotFound; }
			set { _storeReturnsNewIfNotFound = value; }	
		}


		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary>Returns the ProductSearchEngine.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)ProductSearchEngine.EntityType.ProductEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
