using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductSearchEngine.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using ProductSearchEngine.HelperClasses;
using ProductSearchEngine.EntityClasses;

namespace ProductSearchEngine.Business.Adapters
{
    public class CategoryAdapter
    {
        public CategoryAdapter(){}

        public CategoryCollection GetMainCategories()
        {
            CategoryCollection categories = new CategoryCollection();
            PredicateExpression filter = new PredicateExpression();
            filter.Add(new FieldCompareNullPredicate(CategoryFields.BaseCategoryId));
            categories.GetMulti(filter);

            return categories;
        }
        public CategoryCollection GetSubCategories(int mainCatId)
        {
            CategoryCollection subCategories = new CategoryCollection();
            PredicateExpression filter = new PredicateExpression();
            IPrefetchPath prefetchPath = new PrefetchPath((int)EntityType.CategoryEntity);
            prefetchPath.Add(CategoryEntity.PrefetchPathCategories);
            filter.Add(CategoryFields.BaseCategoryId == mainCatId);
            subCategories.GetMulti(filter, prefetchPath);

            return subCategories;
        }

        public CategoryEntity GetCategoryById(int CatId)
        {
            return new CategoryEntity(CatId);
        }
        public int GetMainCatehoryIdBySubCategoryId(int subCatId)
        {
            CategoryEntity category = new CategoryEntity(subCatId);
            return category.Category.Id;
        }
        public CategoryCollection GetRelatedSubCategories(int subCatId)
        {
            CategoryEntity category = new CategoryEntity(subCatId);


            return GetSubCategories(category.Category.Id);
        }

        public bool DeleteCategory(int mainCategoryId)
        {
            CategoryEntity mainCategory = new CategoryEntity(mainCategoryId);
            foreach (CategoryEntity item in mainCategory.Categories)
            {
                item.Delete();
            }
            return mainCategory.Delete();
        }
        public bool DeleteSubCategory(int subCategoryId)
        {
            CategoryEntity subCategory = new CategoryEntity(subCategoryId);

            return subCategory.Delete();
        }
        public void AddMainCategory(string name)
        {
            CategoryEntity mainCategory = new CategoryEntity();
            mainCategory.Name = name;
            mainCategory.Save();
        }
        public void AddSubCategory(int mainCategoryId, string name)
        {
            CategoryEntity subCategory = new CategoryEntity();
            subCategory.BaseCategoryId = mainCategoryId;
            subCategory.Name = name;
            subCategory.Save();
        }
        
    }
}
