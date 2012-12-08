﻿///////////////////////////////////////////////////////////////
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

	/// <summary>Entity class which represents the entity 'StoreInformation'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class StoreInformationEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ProductSearchEngine.CollectionClasses.MembershipCollection	_memberships;
		private bool	_alwaysFetchMemberships, _alreadyFetchedMemberships;
		private CityEntity _city;
		private bool	_alwaysFetchCity, _alreadyFetchedCity, _cityReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name City</summary>
			public static readonly string City = "City";
			/// <summary>Member name Memberships</summary>
			public static readonly string Memberships = "Memberships";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static StoreInformationEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public StoreInformationEntity() : base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="id">PK value for StoreInformation which data should be fetched into this StoreInformation object</param>
		public StoreInformationEntity(System.Int32 id)
		{
			InitClassFetch(id, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for StoreInformation which data should be fetched into this StoreInformation object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public StoreInformationEntity(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(id, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for StoreInformation which data should be fetched into this StoreInformation object</param>
		/// <param name="validator">The custom validator object for this StoreInformationEntity</param>
		public StoreInformationEntity(System.Int32 id, IValidator validator)
		{
			InitClassFetch(id, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected StoreInformationEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_memberships = (ProductSearchEngine.CollectionClasses.MembershipCollection)info.GetValue("_memberships", typeof(ProductSearchEngine.CollectionClasses.MembershipCollection));
			_alwaysFetchMemberships = info.GetBoolean("_alwaysFetchMemberships");
			_alreadyFetchedMemberships = info.GetBoolean("_alreadyFetchedMemberships");
			_city = (CityEntity)info.GetValue("_city", typeof(CityEntity));
			if(_city!=null)
			{
				_city.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_cityReturnsNewIfNotFound = info.GetBoolean("_cityReturnsNewIfNotFound");
			_alwaysFetchCity = info.GetBoolean("_alwaysFetchCity");
			_alreadyFetchedCity = info.GetBoolean("_alreadyFetchedCity");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((StoreInformationFieldIndex)fieldIndex)
			{
				case StoreInformationFieldIndex.CityId:
					DesetupSyncCity(true, false);
					_alreadyFetchedCity = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedMemberships = (_memberships.Count > 0);
			_alreadyFetchedCity = (_city != null);
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
				case "City":
					toReturn.Add(Relations.CityEntityUsingCityId);
					break;
				case "Memberships":
					toReturn.Add(Relations.MembershipEntityUsingStoreInformationId);
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
			info.AddValue("_memberships", (!this.MarkedForDeletion?_memberships:null));
			info.AddValue("_alwaysFetchMemberships", _alwaysFetchMemberships);
			info.AddValue("_alreadyFetchedMemberships", _alreadyFetchedMemberships);
			info.AddValue("_city", (!this.MarkedForDeletion?_city:null));
			info.AddValue("_cityReturnsNewIfNotFound", _cityReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCity", _alwaysFetchCity);
			info.AddValue("_alreadyFetchedCity", _alreadyFetchedCity);

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
				case "City":
					_alreadyFetchedCity = true;
					this.City = (CityEntity)entity;
					break;
				case "Memberships":
					_alreadyFetchedMemberships = true;
					if(entity!=null)
					{
						this.Memberships.Add((MembershipEntity)entity);
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
				case "City":
					SetupSyncCity(relatedEntity);
					break;
				case "Memberships":
					_memberships.Add((MembershipEntity)relatedEntity);
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
				case "City":
					DesetupSyncCity(false, true);
					break;
				case "Memberships":
					this.PerformRelatedEntityRemoval(_memberships, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_city!=null)
			{
				toReturn.Add(_city);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_memberships);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for StoreInformation which data should be fetched into this StoreInformation object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id)
		{
			return FetchUsingPK(id, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for StoreInformation which data should be fetched into this StoreInformation object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for StoreInformation which data should be fetched into this StoreInformation object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for StoreInformation which data should be fetched into this StoreInformation object</param>
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
			return new StoreInformationRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'MembershipEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'MembershipEntity'</returns>
		public ProductSearchEngine.CollectionClasses.MembershipCollection GetMultiMemberships(bool forceFetch)
		{
			return GetMultiMemberships(forceFetch, _memberships.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'MembershipEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'MembershipEntity'</returns>
		public ProductSearchEngine.CollectionClasses.MembershipCollection GetMultiMemberships(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiMemberships(forceFetch, _memberships.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'MembershipEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ProductSearchEngine.CollectionClasses.MembershipCollection GetMultiMemberships(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiMemberships(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'MembershipEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductSearchEngine.CollectionClasses.MembershipCollection GetMultiMemberships(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedMemberships || forceFetch || _alwaysFetchMemberships) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_memberships);
				_memberships.SuppressClearInGetMulti=!forceFetch;
				_memberships.EntityFactoryToUse = entityFactoryToUse;
				_memberships.GetMultiManyToOne(null, this, filter);
				_memberships.SuppressClearInGetMulti=false;
				_alreadyFetchedMemberships = true;
			}
			return _memberships;
		}

		/// <summary> Sets the collection parameters for the collection for 'Memberships'. These settings will be taken into account
		/// when the property Memberships is requested or GetMultiMemberships is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersMemberships(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_memberships.SortClauses=sortClauses;
			_memberships.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'CityEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CityEntity' which is related to this entity.</returns>
		public CityEntity GetSingleCity()
		{
			return GetSingleCity(false);
		}

		/// <summary> Retrieves the related entity of type 'CityEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CityEntity' which is related to this entity.</returns>
		public virtual CityEntity GetSingleCity(bool forceFetch)
		{
			if( ( !_alreadyFetchedCity || forceFetch || _alwaysFetchCity) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.CityEntityUsingCityId);
				CityEntity newEntity = new CityEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.CityId.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (CityEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_cityReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.City = newEntity;
				_alreadyFetchedCity = fetchResult;
			}
			return _city;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("City", _city);
			toReturn.Add("Memberships", _memberships);
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
		/// <param name="id">PK value for StoreInformation which data should be fetched into this StoreInformation object</param>
		/// <param name="validator">The validator object for this StoreInformationEntity</param>
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

			_memberships = new ProductSearchEngine.CollectionClasses.MembershipCollection();
			_memberships.SetContainingEntityInfo(this, "StoreInformation");
			_cityReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("Address", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AuthorizedName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CityId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Email", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Telephone", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("WebAddress", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _city</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCity(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _city, new PropertyChangedEventHandler( OnCityPropertyChanged ), "City", ProductSearchEngine.RelationClasses.StaticStoreInformationRelations.CityEntityUsingCityIdStatic, true, signalRelatedEntity, "StoreInformations", resetFKFields, new int[] { (int)StoreInformationFieldIndex.CityId } );		
			_city = null;
		}
		
		/// <summary> setups the sync logic for member _city</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCity(IEntity relatedEntity)
		{
			if(_city!=relatedEntity)
			{		
				DesetupSyncCity(true, true);
				_city = (CityEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _city, new PropertyChangedEventHandler( OnCityPropertyChanged ), "City", ProductSearchEngine.RelationClasses.StaticStoreInformationRelations.CityEntityUsingCityIdStatic, true, ref _alreadyFetchedCity, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCityPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="id">PK value for StoreInformation which data should be fetched into this StoreInformation object</param>
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
				this.Fields[(int)StoreInformationFieldIndex.Id].ForcedCurrentValueWrite(id);
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
			return DAOFactory.CreateStoreInformationDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new StoreInformationEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static StoreInformationRelations Relations
		{
			get	{ return new StoreInformationRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Membership' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathMemberships
		{
			get { return new PrefetchPathElement(new ProductSearchEngine.CollectionClasses.MembershipCollection(), (IEntityRelation)GetRelationsForField("Memberships")[0], (int)ProductSearchEngine.EntityType.StoreInformationEntity, (int)ProductSearchEngine.EntityType.MembershipEntity, 0, null, null, null, "Memberships", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'City'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCity
		{
			get	{ return new PrefetchPathElement(new ProductSearchEngine.CollectionClasses.CityCollection(), (IEntityRelation)GetRelationsForField("City")[0], (int)ProductSearchEngine.EntityType.StoreInformationEntity, (int)ProductSearchEngine.EntityType.CityEntity, 0, null, null, null, "City", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override string LLBLGenProEntityName
		{
			get { return "StoreInformationEntity";}
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

		/// <summary> The Address property of the Entity StoreInformation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "StoreInformation"."Address"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address
		{
			get { return (System.String)GetValue((int)StoreInformationFieldIndex.Address, true); }
			set	{ SetValue((int)StoreInformationFieldIndex.Address, value, true); }
		}

		/// <summary> The AuthorizedName property of the Entity StoreInformation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "StoreInformation"."AuthorizedName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AuthorizedName
		{
			get { return (System.String)GetValue((int)StoreInformationFieldIndex.AuthorizedName, true); }
			set	{ SetValue((int)StoreInformationFieldIndex.AuthorizedName, value, true); }
		}

		/// <summary> The CityId property of the Entity StoreInformation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "StoreInformation"."CityId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> CityId
		{
			get { return (Nullable<System.Int32>)GetValue((int)StoreInformationFieldIndex.CityId, false); }
			set	{ SetValue((int)StoreInformationFieldIndex.CityId, value, true); }
		}

		/// <summary> The Email property of the Entity StoreInformation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "StoreInformation"."Email"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Email
		{
			get { return (System.String)GetValue((int)StoreInformationFieldIndex.Email, true); }
			set	{ SetValue((int)StoreInformationFieldIndex.Email, value, true); }
		}

		/// <summary> The Id property of the Entity StoreInformation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "StoreInformation"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)StoreInformationFieldIndex.Id, true); }
			set	{ SetValue((int)StoreInformationFieldIndex.Id, value, true); }
		}

		/// <summary> The Telephone property of the Entity StoreInformation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "StoreInformation"."Telephone"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Telephone
		{
			get { return (System.String)GetValue((int)StoreInformationFieldIndex.Telephone, true); }
			set	{ SetValue((int)StoreInformationFieldIndex.Telephone, value, true); }
		}

		/// <summary> The WebAddress property of the Entity StoreInformation<br/><br/></summary>
		/// <remarks>Mapped on  table field: "StoreInformation"."WebAddress"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String WebAddress
		{
			get { return (System.String)GetValue((int)StoreInformationFieldIndex.WebAddress, true); }
			set	{ SetValue((int)StoreInformationFieldIndex.WebAddress, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'MembershipEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMemberships()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ProductSearchEngine.CollectionClasses.MembershipCollection Memberships
		{
			get	{ return GetMultiMemberships(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Memberships. When set to true, Memberships is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Memberships is accessed. You can always execute/ a forced fetch by calling GetMultiMemberships(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchMemberships
		{
			get	{ return _alwaysFetchMemberships; }
			set	{ _alwaysFetchMemberships = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Memberships already has been fetched. Setting this property to false when Memberships has been fetched
		/// will clear the Memberships collection well. Setting this property to true while Memberships hasn't been fetched disables lazy loading for Memberships</summary>
		[Browsable(false)]
		public bool AlreadyFetchedMemberships
		{
			get { return _alreadyFetchedMemberships;}
			set 
			{
				if(_alreadyFetchedMemberships && !value && (_memberships != null))
				{
					_memberships.Clear();
				}
				_alreadyFetchedMemberships = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'CityEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCity()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CityEntity City
		{
			get	{ return GetSingleCity(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncCity(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "StoreInformations", "City", _city, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for City. When set to true, City is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time City is accessed. You can always execute a forced fetch by calling GetSingleCity(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCity
		{
			get	{ return _alwaysFetchCity; }
			set	{ _alwaysFetchCity = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property City already has been fetched. Setting this property to false when City has been fetched
		/// will set City to null as well. Setting this property to true while City hasn't been fetched disables lazy loading for City</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCity
		{
			get { return _alreadyFetchedCity;}
			set 
			{
				if(_alreadyFetchedCity && !value)
				{
					this.City = null;
				}
				_alreadyFetchedCity = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property City is not found
		/// in the database. When set to true, City will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool CityReturnsNewIfNotFound
		{
			get	{ return _cityReturnsNewIfNotFound; }
			set { _cityReturnsNewIfNotFound = value; }	
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
			get { return (int)ProductSearchEngine.EntityType.StoreInformationEntity; }
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
