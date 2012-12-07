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
using System.Collections.Generic;
using ProductSearchEngine.HelperClasses;

using ProductSearchEngine.EntityClasses;
using ProductSearchEngine.RelationClasses;
using ProductSearchEngine.DaoClasses;
using ProductSearchEngine.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ProductSearchEngine.FactoryClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>general base class for the generated factories</summary>
	[Serializable]
	public partial class EntityFactoryBase : EntityFactoryCore
	{
		private readonly ProductSearchEngine.EntityType _typeOfEntity;
		
		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		public EntityFactoryBase(string entityName, ProductSearchEngine.EntityType typeOfEntity) : base(entityName)
		{
			_typeOfEntity = typeOfEntity;
		}

		/// <summary>Creates a new entity instance using the GeneralEntityFactory in the generated code, using the passed in entitytype value</summary>
		/// <param name="entityTypeValue">The entity type value of the entity to create an instance for.</param>
		/// <returns>new IEntity instance</returns>
		public override IEntity CreateEntityFromEntityTypeValue(int entityTypeValue)
		{
			return GeneralEntityFactory.Create((ProductSearchEngine.EntityType)entityTypeValue);
		}
		
		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public override IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(_typeOfEntity);
		}

		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <param name="objectAlias">The object alias to use for the elements in the relations.</param>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public override IRelationCollection CreateHierarchyRelations(string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetHierarchyRelations(ForEntityName, objectAlias);
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public override IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return (IEntityFactory)InheritanceInfoProviderSingleton.GetInstance().GetEntityFactory(ForEntityName, fieldValues, entityFieldStartIndexesPerEntity) ?? this;
		}
						
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public override IEntityCollection CreateEntityCollection()
		{
			return GeneralEntityCollectionFactory.Create(_typeOfEntity);
		}
	}
	
	/// <summary>Factory to create new, empty BrandEntity objects.</summary>
	[Serializable]
	public partial class BrandEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public BrandEntityFactory() : base("BrandEntity", ProductSearchEngine.EntityType.BrandEntity) { }

		/// <summary>Creates a new, empty BrandEntity object.</summary>
		/// <returns>A new, empty BrandEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new BrandEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBrand
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CategoryEntity objects.</summary>
	[Serializable]
	public partial class CategoryEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CategoryEntityFactory() : base("CategoryEntity", ProductSearchEngine.EntityType.CategoryEntity) { }

		/// <summary>Creates a new, empty CategoryEntity object.</summary>
		/// <returns>A new, empty CategoryEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CategoryEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCategory
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CityEntity objects.</summary>
	[Serializable]
	public partial class CityEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CityEntityFactory() : base("CityEntity", ProductSearchEngine.EntityType.CityEntity) { }

		/// <summary>Creates a new, empty CityEntity object.</summary>
		/// <returns>A new, empty CityEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CityEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCity
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CommentEntity objects.</summary>
	[Serializable]
	public partial class CommentEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CommentEntityFactory() : base("CommentEntity", ProductSearchEngine.EntityType.CommentEntity) { }

		/// <summary>Creates a new, empty CommentEntity object.</summary>
		/// <returns>A new, empty CommentEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CommentEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewComment
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty KeywordEntity objects.</summary>
	[Serializable]
	public partial class KeywordEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public KeywordEntityFactory() : base("KeywordEntity", ProductSearchEngine.EntityType.KeywordEntity) { }

		/// <summary>Creates a new, empty KeywordEntity object.</summary>
		/// <returns>A new, empty KeywordEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new KeywordEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewKeyword
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty LastViewedProductEntity objects.</summary>
	[Serializable]
	public partial class LastViewedProductEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public LastViewedProductEntityFactory() : base("LastViewedProductEntity", ProductSearchEngine.EntityType.LastViewedProductEntity) { }

		/// <summary>Creates a new, empty LastViewedProductEntity object.</summary>
		/// <returns>A new, empty LastViewedProductEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new LastViewedProductEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLastViewedProduct
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty MembershipEntity objects.</summary>
	[Serializable]
	public partial class MembershipEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public MembershipEntityFactory() : base("MembershipEntity", ProductSearchEngine.EntityType.MembershipEntity) { }

		/// <summary>Creates a new, empty MembershipEntity object.</summary>
		/// <returns>A new, empty MembershipEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new MembershipEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMembership
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductEntity objects.</summary>
	[Serializable]
	public partial class ProductEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ProductEntityFactory() : base("ProductEntity", ProductSearchEngine.EntityType.ProductEntity) { }

		/// <summary>Creates a new, empty ProductEntity object.</summary>
		/// <returns>A new, empty ProductEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ProductEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProduct
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductKeywordEntity objects.</summary>
	[Serializable]
	public partial class ProductKeywordEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ProductKeywordEntityFactory() : base("ProductKeywordEntity", ProductSearchEngine.EntityType.ProductKeywordEntity) { }

		/// <summary>Creates a new, empty ProductKeywordEntity object.</summary>
		/// <returns>A new, empty ProductKeywordEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ProductKeywordEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductKeyword
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductPhotoEntity objects.</summary>
	[Serializable]
	public partial class ProductPhotoEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ProductPhotoEntityFactory() : base("ProductPhotoEntity", ProductSearchEngine.EntityType.ProductPhotoEntity) { }

		/// <summary>Creates a new, empty ProductPhotoEntity object.</summary>
		/// <returns>A new, empty ProductPhotoEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ProductPhotoEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductPhoto
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductSpecificationEntity objects.</summary>
	[Serializable]
	public partial class ProductSpecificationEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ProductSpecificationEntityFactory() : base("ProductSpecificationEntity", ProductSearchEngine.EntityType.ProductSpecificationEntity) { }

		/// <summary>Creates a new, empty ProductSpecificationEntity object.</summary>
		/// <returns>A new, empty ProductSpecificationEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ProductSpecificationEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductSpecification
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty RateEntity objects.</summary>
	[Serializable]
	public partial class RateEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public RateEntityFactory() : base("RateEntity", ProductSearchEngine.EntityType.RateEntity) { }

		/// <summary>Creates a new, empty RateEntity object.</summary>
		/// <returns>A new, empty RateEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new RateEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRate
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty RoleEntity objects.</summary>
	[Serializable]
	public partial class RoleEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public RoleEntityFactory() : base("RoleEntity", ProductSearchEngine.EntityType.RoleEntity) { }

		/// <summary>Creates a new, empty RoleEntity object.</summary>
		/// <returns>A new, empty RoleEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new RoleEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRole
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty StoreEntity objects.</summary>
	[Serializable]
	public partial class StoreEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public StoreEntityFactory() : base("StoreEntity", ProductSearchEngine.EntityType.StoreEntity) { }

		/// <summary>Creates a new, empty StoreEntity object.</summary>
		/// <returns>A new, empty StoreEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new StoreEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewStore
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty StoreInformationEntity objects.</summary>
	[Serializable]
	public partial class StoreInformationEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public StoreInformationEntityFactory() : base("StoreInformationEntity", ProductSearchEngine.EntityType.StoreInformationEntity) { }

		/// <summary>Creates a new, empty StoreInformationEntity object.</summary>
		/// <returns>A new, empty StoreInformationEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new StoreInformationEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewStoreInformation
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty WebTrackerEntity objects.</summary>
	[Serializable]
	public partial class WebTrackerEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public WebTrackerEntityFactory() : base("WebTrackerEntity", ProductSearchEngine.EntityType.WebTrackerEntity) { }

		/// <summary>Creates a new, empty WebTrackerEntity object.</summary>
		/// <returns>A new, empty WebTrackerEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new WebTrackerEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewWebTracker
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}


		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new entity collection objects</summary>
	[Serializable]
	public partial class GeneralEntityCollectionFactory
	{
		/// <summary>Creates a new entity collection</summary>
		/// <param name="typeToUse">The entity type to create the collection for.</param>
		/// <returns>A new entity collection object.</returns>
		public static IEntityCollection Create(ProductSearchEngine.EntityType typeToUse)
		{
			switch(typeToUse)
			{
				case ProductSearchEngine.EntityType.BrandEntity:
					return new BrandCollection();
				case ProductSearchEngine.EntityType.CategoryEntity:
					return new CategoryCollection();
				case ProductSearchEngine.EntityType.CityEntity:
					return new CityCollection();
				case ProductSearchEngine.EntityType.CommentEntity:
					return new CommentCollection();
				case ProductSearchEngine.EntityType.KeywordEntity:
					return new KeywordCollection();
				case ProductSearchEngine.EntityType.LastViewedProductEntity:
					return new LastViewedProductCollection();
				case ProductSearchEngine.EntityType.MembershipEntity:
					return new MembershipCollection();
				case ProductSearchEngine.EntityType.ProductEntity:
					return new ProductCollection();
				case ProductSearchEngine.EntityType.ProductKeywordEntity:
					return new ProductKeywordCollection();
				case ProductSearchEngine.EntityType.ProductPhotoEntity:
					return new ProductPhotoCollection();
				case ProductSearchEngine.EntityType.ProductSpecificationEntity:
					return new ProductSpecificationCollection();
				case ProductSearchEngine.EntityType.RateEntity:
					return new RateCollection();
				case ProductSearchEngine.EntityType.RoleEntity:
					return new RoleCollection();
				case ProductSearchEngine.EntityType.StoreEntity:
					return new StoreCollection();
				case ProductSearchEngine.EntityType.StoreInformationEntity:
					return new StoreInformationCollection();
				case ProductSearchEngine.EntityType.WebTrackerEntity:
					return new WebTrackerCollection();
				default:
					return null;
			}
		}		
	}
	
	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses entity specific factory objects</summary>
	[Serializable]
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity Create(ProductSearchEngine.EntityType entityTypeToCreate)
		{
			IEntityFactory factoryToUse = null;
			switch(entityTypeToCreate)
			{
				case ProductSearchEngine.EntityType.BrandEntity:
					factoryToUse = new BrandEntityFactory();
					break;
				case ProductSearchEngine.EntityType.CategoryEntity:
					factoryToUse = new CategoryEntityFactory();
					break;
				case ProductSearchEngine.EntityType.CityEntity:
					factoryToUse = new CityEntityFactory();
					break;
				case ProductSearchEngine.EntityType.CommentEntity:
					factoryToUse = new CommentEntityFactory();
					break;
				case ProductSearchEngine.EntityType.KeywordEntity:
					factoryToUse = new KeywordEntityFactory();
					break;
				case ProductSearchEngine.EntityType.LastViewedProductEntity:
					factoryToUse = new LastViewedProductEntityFactory();
					break;
				case ProductSearchEngine.EntityType.MembershipEntity:
					factoryToUse = new MembershipEntityFactory();
					break;
				case ProductSearchEngine.EntityType.ProductEntity:
					factoryToUse = new ProductEntityFactory();
					break;
				case ProductSearchEngine.EntityType.ProductKeywordEntity:
					factoryToUse = new ProductKeywordEntityFactory();
					break;
				case ProductSearchEngine.EntityType.ProductPhotoEntity:
					factoryToUse = new ProductPhotoEntityFactory();
					break;
				case ProductSearchEngine.EntityType.ProductSpecificationEntity:
					factoryToUse = new ProductSpecificationEntityFactory();
					break;
				case ProductSearchEngine.EntityType.RateEntity:
					factoryToUse = new RateEntityFactory();
					break;
				case ProductSearchEngine.EntityType.RoleEntity:
					factoryToUse = new RoleEntityFactory();
					break;
				case ProductSearchEngine.EntityType.StoreEntity:
					factoryToUse = new StoreEntityFactory();
					break;
				case ProductSearchEngine.EntityType.StoreInformationEntity:
					factoryToUse = new StoreInformationEntityFactory();
					break;
				case ProductSearchEngine.EntityType.WebTrackerEntity:
					factoryToUse = new WebTrackerEntityFactory();
					break;
			}
			IEntity toReturn = null;
			if(factoryToUse != null)
			{
				toReturn = factoryToUse.Create();
			}
			return toReturn;
		}		
	}
	
	/// <summary>Class which is used to obtain the entity factory based on the .NET type of the entity. </summary>
	[Serializable]
	public static class EntityFactoryFactory
	{
#if CF
		/// <summary>Gets the factory of the entity with the ProductSearchEngine.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(ProductSearchEngine.EntityType typeOfEntity)
		{
			return GeneralEntityFactory.Create(typeOfEntity).GetEntityFactory();
		}
#else
		private static readonly Dictionary<Type, IEntityFactory> _factoryPerType = new Dictionary<Type, IEntityFactory>();

		/// <summary>Initializes the <see cref="EntityFactoryFactory"/> class.</summary>
		static EntityFactoryFactory()
		{
			Array entityTypeValues = Enum.GetValues(typeof(ProductSearchEngine.EntityType));
			foreach(int entityTypeValue in entityTypeValues)
			{
				IEntity dummy = GeneralEntityFactory.Create((ProductSearchEngine.EntityType)entityTypeValue);
				_factoryPerType.Add(dummy.GetType(), dummy.GetEntityFactory());
			}
		}

		/// <summary>Gets the factory of the entity with the .NET type specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(Type typeOfEntity)
		{
			IEntityFactory toReturn = null;
			_factoryPerType.TryGetValue(typeOfEntity, out toReturn);
			return toReturn;
		}

		/// <summary>Gets the factory of the entity with the ProductSearchEngine.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(ProductSearchEngine.EntityType typeOfEntity)
		{
			return GetFactory(GeneralEntityFactory.Create(typeOfEntity).GetType());
		}
#endif
	}
	
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class ElementCreator : ElementCreatorBase, IElementCreator
	{
		/// <summary>Gets the factory of the Entity type with the ProductSearchEngine.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory GetFactory(int entityTypeValue)
		{
			return (IEntityFactory)this.GetFactoryImpl(entityTypeValue);
		}

		/// <summary>Gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory GetFactory(Type typeOfEntity)
		{
			return (IEntityFactory)this.GetFactoryImpl(typeOfEntity);
		}

		/// <summary>Creates a new resultset fields object with the number of field slots reserved as specified</summary>
		/// <param name="numberOfFields">The number of fields.</param>
		/// <returns>ready to use resultsetfields object</returns>
		public IEntityFields CreateResultsetFields(int numberOfFields)
		{
			return new ResultsetFields(numberOfFields);
		}
		
		/// <summary>Gets an instance of the TypedListDAO class to execute dynamic lists and projections.</summary>
		/// <returns>ready to use typedlistDAO</returns>
		public IDao GetTypedListDao()
		{
			return new TypedListDAO();
		}
		
		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand)
		{
			return new DynamicRelation(leftOperand);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (ProductSearchEngine.EntityType)Enum.Parse(typeof(ProductSearchEngine.EntityType), rightOperandEntityName, false), aliasRightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperandEntityName">Name of the entity which is used as the left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(string leftOperandEntityName, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation((ProductSearchEngine.EntityType)Enum.Parse(typeof(ProductSearchEngine.EntityType), leftOperandEntityName, false), joinType, (ProductSearchEngine.EntityType)Enum.Parse(typeof(ProductSearchEngine.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
				
		/// <summary>Obtains the inheritance info provider instance from the singleton </summary>
		/// <returns>The singleton instance of the inheritance info provider</returns>
		public override IInheritanceInfoProvider ObtainInheritanceInfoProviderInstance()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}

		/// <summary>Implementation of the routine which gets the factory of the Entity type with the ProductSearchEngine.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue)
		{
			return EntityFactoryFactory.GetFactory((ProductSearchEngine.EntityType)entityTypeValue);
		}
#if !CF		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(Type typeOfEntity)
		{
			return EntityFactoryFactory.GetFactory(typeOfEntity);
		}
#endif
	}
}
