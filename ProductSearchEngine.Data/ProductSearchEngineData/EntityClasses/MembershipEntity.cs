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

	/// <summary>Entity class which represents the entity 'Membership'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class MembershipEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ProductSearchEngine.CollectionClasses.StoreCollection	_stores;
		private bool	_alwaysFetchStores, _alreadyFetchedStores;
		private StoreInformationEntity _storeInformation;
		private bool	_alwaysFetchStoreInformation, _alreadyFetchedStoreInformation, _storeInformationReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name StoreInformation</summary>
			public static readonly string StoreInformation = "StoreInformation";
			/// <summary>Member name Stores</summary>
			public static readonly string Stores = "Stores";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static MembershipEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public MembershipEntity() : base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="id">PK value for Membership which data should be fetched into this Membership object</param>
		public MembershipEntity(System.Int32 id)
		{
			InitClassFetch(id, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Membership which data should be fetched into this Membership object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public MembershipEntity(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(id, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Membership which data should be fetched into this Membership object</param>
		/// <param name="validator">The custom validator object for this MembershipEntity</param>
		public MembershipEntity(System.Int32 id, IValidator validator)
		{
			InitClassFetch(id, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected MembershipEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_stores = (ProductSearchEngine.CollectionClasses.StoreCollection)info.GetValue("_stores", typeof(ProductSearchEngine.CollectionClasses.StoreCollection));
			_alwaysFetchStores = info.GetBoolean("_alwaysFetchStores");
			_alreadyFetchedStores = info.GetBoolean("_alreadyFetchedStores");
			_storeInformation = (StoreInformationEntity)info.GetValue("_storeInformation", typeof(StoreInformationEntity));
			if(_storeInformation!=null)
			{
				_storeInformation.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_storeInformationReturnsNewIfNotFound = info.GetBoolean("_storeInformationReturnsNewIfNotFound");
			_alwaysFetchStoreInformation = info.GetBoolean("_alwaysFetchStoreInformation");
			_alreadyFetchedStoreInformation = info.GetBoolean("_alreadyFetchedStoreInformation");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((MembershipFieldIndex)fieldIndex)
			{
				case MembershipFieldIndex.StoreInformationId:
					DesetupSyncStoreInformation(true, false);
					_alreadyFetchedStoreInformation = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedStores = (_stores.Count > 0);
			_alreadyFetchedStoreInformation = (_storeInformation != null);
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
				case "StoreInformation":
					toReturn.Add(Relations.StoreInformationEntityUsingStoreInformationId);
					break;
				case "Stores":
					toReturn.Add(Relations.StoreEntityUsingMembershipId);
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
			info.AddValue("_stores", (!this.MarkedForDeletion?_stores:null));
			info.AddValue("_alwaysFetchStores", _alwaysFetchStores);
			info.AddValue("_alreadyFetchedStores", _alreadyFetchedStores);
			info.AddValue("_storeInformation", (!this.MarkedForDeletion?_storeInformation:null));
			info.AddValue("_storeInformationReturnsNewIfNotFound", _storeInformationReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchStoreInformation", _alwaysFetchStoreInformation);
			info.AddValue("_alreadyFetchedStoreInformation", _alreadyFetchedStoreInformation);

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
				case "StoreInformation":
					_alreadyFetchedStoreInformation = true;
					this.StoreInformation = (StoreInformationEntity)entity;
					break;
				case "Stores":
					_alreadyFetchedStores = true;
					if(entity!=null)
					{
						this.Stores.Add((StoreEntity)entity);
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
				case "StoreInformation":
					SetupSyncStoreInformation(relatedEntity);
					break;
				case "Stores":
					_stores.Add((StoreEntity)relatedEntity);
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
				case "StoreInformation":
					DesetupSyncStoreInformation(false, true);
					break;
				case "Stores":
					this.PerformRelatedEntityRemoval(_stores, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_storeInformation!=null)
			{
				toReturn.Add(_storeInformation);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_stores);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Membership which data should be fetched into this Membership object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id)
		{
			return FetchUsingPK(id, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Membership which data should be fetched into this Membership object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Membership which data should be fetched into this Membership object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Membership which data should be fetched into this Membership object</param>
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
			return new MembershipRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'StoreEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'StoreEntity'</returns>
		public ProductSearchEngine.CollectionClasses.StoreCollection GetMultiStores(bool forceFetch)
		{
			return GetMultiStores(forceFetch, _stores.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'StoreEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'StoreEntity'</returns>
		public ProductSearchEngine.CollectionClasses.StoreCollection GetMultiStores(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiStores(forceFetch, _stores.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'StoreEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ProductSearchEngine.CollectionClasses.StoreCollection GetMultiStores(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiStores(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'StoreEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductSearchEngine.CollectionClasses.StoreCollection GetMultiStores(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedStores || forceFetch || _alwaysFetchStores) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_stores);
				_stores.SuppressClearInGetMulti=!forceFetch;
				_stores.EntityFactoryToUse = entityFactoryToUse;
				_stores.GetMultiManyToOne(this, filter);
				_stores.SuppressClearInGetMulti=false;
				_alreadyFetchedStores = true;
			}
			return _stores;
		}

		/// <summary> Sets the collection parameters for the collection for 'Stores'. These settings will be taken into account
		/// when the property Stores is requested or GetMultiStores is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersStores(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_stores.SortClauses=sortClauses;
			_stores.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'StoreInformationEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'StoreInformationEntity' which is related to this entity.</returns>
		public StoreInformationEntity GetSingleStoreInformation()
		{
			return GetSingleStoreInformation(false);
		}

		/// <summary> Retrieves the related entity of type 'StoreInformationEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'StoreInformationEntity' which is related to this entity.</returns>
		public virtual StoreInformationEntity GetSingleStoreInformation(bool forceFetch)
		{
			if( ( !_alreadyFetchedStoreInformation || forceFetch || _alwaysFetchStoreInformation) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.StoreInformationEntityUsingStoreInformationId);
				StoreInformationEntity newEntity = new StoreInformationEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.StoreInformationId.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (StoreInformationEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_storeInformationReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.StoreInformation = newEntity;
				_alreadyFetchedStoreInformation = fetchResult;
			}
			return _storeInformation;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("StoreInformation", _storeInformation);
			toReturn.Add("Stores", _stores);
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
		/// <param name="id">PK value for Membership which data should be fetched into this Membership object</param>
		/// <param name="validator">The validator object for this MembershipEntity</param>
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

			_stores = new ProductSearchEngine.CollectionClasses.StoreCollection();
			_stores.SetContainingEntityInfo(this, "Membership");
			_storeInformationReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Password", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Status", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StoreInformationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UserName", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _storeInformation</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncStoreInformation(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _storeInformation, new PropertyChangedEventHandler( OnStoreInformationPropertyChanged ), "StoreInformation", ProductSearchEngine.RelationClasses.StaticMembershipRelations.StoreInformationEntityUsingStoreInformationIdStatic, true, signalRelatedEntity, "Memberships", resetFKFields, new int[] { (int)MembershipFieldIndex.StoreInformationId } );		
			_storeInformation = null;
		}
		
		/// <summary> setups the sync logic for member _storeInformation</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncStoreInformation(IEntity relatedEntity)
		{
			if(_storeInformation!=relatedEntity)
			{		
				DesetupSyncStoreInformation(true, true);
				_storeInformation = (StoreInformationEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _storeInformation, new PropertyChangedEventHandler( OnStoreInformationPropertyChanged ), "StoreInformation", ProductSearchEngine.RelationClasses.StaticMembershipRelations.StoreInformationEntityUsingStoreInformationIdStatic, true, ref _alreadyFetchedStoreInformation, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnStoreInformationPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="id">PK value for Membership which data should be fetched into this Membership object</param>
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
				this.Fields[(int)MembershipFieldIndex.Id].ForcedCurrentValueWrite(id);
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
			return DAOFactory.CreateMembershipDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new MembershipEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static MembershipRelations Relations
		{
			get	{ return new MembershipRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Store' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStores
		{
			get { return new PrefetchPathElement(new ProductSearchEngine.CollectionClasses.StoreCollection(), (IEntityRelation)GetRelationsForField("Stores")[0], (int)ProductSearchEngine.EntityType.MembershipEntity, (int)ProductSearchEngine.EntityType.StoreEntity, 0, null, null, null, "Stores", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'StoreInformation'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStoreInformation
		{
			get	{ return new PrefetchPathElement(new ProductSearchEngine.CollectionClasses.StoreInformationCollection(), (IEntityRelation)GetRelationsForField("StoreInformation")[0], (int)ProductSearchEngine.EntityType.MembershipEntity, (int)ProductSearchEngine.EntityType.StoreInformationEntity, 0, null, null, null, "StoreInformation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override string LLBLGenProEntityName
		{
			get { return "MembershipEntity";}
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

		/// <summary> The Id property of the Entity Membership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Membership"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)MembershipFieldIndex.Id, true); }
			set	{ SetValue((int)MembershipFieldIndex.Id, value, true); }
		}

		/// <summary> The Password property of the Entity Membership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Membership"."Password"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Password
		{
			get { return (System.String)GetValue((int)MembershipFieldIndex.Password, true); }
			set	{ SetValue((int)MembershipFieldIndex.Password, value, true); }
		}

		/// <summary> The Status property of the Entity Membership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Membership"."Status"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Status
		{
			get { return (Nullable<System.Boolean>)GetValue((int)MembershipFieldIndex.Status, false); }
			set	{ SetValue((int)MembershipFieldIndex.Status, value, true); }
		}

		/// <summary> The StoreInformationId property of the Entity Membership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Membership"."StoreInformationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> StoreInformationId
		{
			get { return (Nullable<System.Int32>)GetValue((int)MembershipFieldIndex.StoreInformationId, false); }
			set	{ SetValue((int)MembershipFieldIndex.StoreInformationId, value, true); }
		}

		/// <summary> The UserName property of the Entity Membership<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Membership"."UserName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String UserName
		{
			get { return (System.String)GetValue((int)MembershipFieldIndex.UserName, true); }
			set	{ SetValue((int)MembershipFieldIndex.UserName, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'StoreEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiStores()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ProductSearchEngine.CollectionClasses.StoreCollection Stores
		{
			get	{ return GetMultiStores(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Stores. When set to true, Stores is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Stores is accessed. You can always execute/ a forced fetch by calling GetMultiStores(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchStores
		{
			get	{ return _alwaysFetchStores; }
			set	{ _alwaysFetchStores = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Stores already has been fetched. Setting this property to false when Stores has been fetched
		/// will clear the Stores collection well. Setting this property to true while Stores hasn't been fetched disables lazy loading for Stores</summary>
		[Browsable(false)]
		public bool AlreadyFetchedStores
		{
			get { return _alreadyFetchedStores;}
			set 
			{
				if(_alreadyFetchedStores && !value && (_stores != null))
				{
					_stores.Clear();
				}
				_alreadyFetchedStores = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'StoreInformationEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleStoreInformation()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual StoreInformationEntity StoreInformation
		{
			get	{ return GetSingleStoreInformation(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncStoreInformation(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Memberships", "StoreInformation", _storeInformation, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for StoreInformation. When set to true, StoreInformation is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time StoreInformation is accessed. You can always execute a forced fetch by calling GetSingleStoreInformation(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchStoreInformation
		{
			get	{ return _alwaysFetchStoreInformation; }
			set	{ _alwaysFetchStoreInformation = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property StoreInformation already has been fetched. Setting this property to false when StoreInformation has been fetched
		/// will set StoreInformation to null as well. Setting this property to true while StoreInformation hasn't been fetched disables lazy loading for StoreInformation</summary>
		[Browsable(false)]
		public bool AlreadyFetchedStoreInformation
		{
			get { return _alreadyFetchedStoreInformation;}
			set 
			{
				if(_alreadyFetchedStoreInformation && !value)
				{
					this.StoreInformation = null;
				}
				_alreadyFetchedStoreInformation = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property StoreInformation is not found
		/// in the database. When set to true, StoreInformation will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool StoreInformationReturnsNewIfNotFound
		{
			get	{ return _storeInformationReturnsNewIfNotFound; }
			set { _storeInformationReturnsNewIfNotFound = value; }	
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
			get { return (int)ProductSearchEngine.EntityType.MembershipEntity; }
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
