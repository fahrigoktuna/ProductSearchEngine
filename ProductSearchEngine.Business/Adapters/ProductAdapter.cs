using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductSearchEngine.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using ProductSearchEngine.HelperClasses;
using ProductSearchEngine.EntityClasses;
using System.Collections;

namespace ProductSearchEngine.Business.Adapters
{
    public class ProductAdapter
    {
        public ProductAdapter() { }

        public ProductCollection GetSpeacialProducts()
        {
            ProductCollection specialProducts = new ProductCollection();
            PredicateExpression filter = new PredicateExpression(ProductFields.IsSpeacialProduct == true);
            filter.Add(ProductFields.Status == true);
            SortExpression sorter = new SortExpression();
            sorter.Add(ProductFields.AddedDate | SortOperator.Descending);

            specialProducts.GetMulti(filter,6,sorter);

            return specialProducts;

        }
        public ProductCollection GetLatestProducts()
        {
            ProductCollection specialProducts = new ProductCollection();
            PredicateExpression filter = new PredicateExpression();
            filter.Add(ProductFields.Status == true);

            SortExpression sorter = new SortExpression();
            sorter.Add(ProductFields.AddedDate | SortOperator.Descending);



            specialProducts.GetMulti(filter, 6, sorter);

            return specialProducts;
        }

        public ProductCollection GetSliderProducts()
        {
            ProductCollection sliderProducts = new ProductCollection();
            PredicateExpression filter = new PredicateExpression();
            IPrefetchPath prefetchPath = new PrefetchPath((int)EntityType.ProductEntity);
            IPrefetchPathElement path = prefetchPath.Add(ProductEntity.PrefetchPathComments);
            path.SubPath.Add(CommentEntity.PrefetchPathRate);


            filter.Add(ProductFields.IsSliderProduct == true);
            filter.Add(ProductFields.Status == true);
            sliderProducts.GetMulti(filter, prefetchPath);

            foreach (var item in sliderProducts)
            {
                int id = item.Id;
            }
            return sliderProducts;

        }

        public object GetSliderPhotos()
        {
            ProductPhotoCollection productPhotos = new ProductPhotoCollection();
            RelationCollection relationsToUse = new RelationCollection();
            relationsToUse.Add(ProductPhotoEntity.Relations.ProductEntityUsingProductId);


            IPredicateExpression selectFilter = new PredicateExpression();
            selectFilter.Add(ProductFields.IsSliderProduct == true);
            productPhotos.GetMulti(selectFilter, 0, null, relationsToUse);

            var productPhotosDistinct = productPhotos.GroupBy(p => p.ProductId).Select(g => g.First());

            return productPhotosDistinct;

        }

        public LastViewedProductCollection GetLast5ViewedProducts(int storeId)
        {
            LastViewedProductCollection lastViewedProducts = new LastViewedProductCollection();
            RelationCollection relationsToUse = new RelationCollection();
            relationsToUse.Add(LastViewedProductEntity.Relations.ProductEntityUsingProductId);
            relationsToUse.Add(ProductEntity.Relations.StoreEntityUsingStoreId);
            PrefetchPath prefetchPath = new PrefetchPath((int)EntityType.LastViewedProductEntity);
            prefetchPath.Add(LastViewedProductEntity.PrefetchPathProduct).SubPath.Add(ProductEntity.PrefetchPathStore);

            PredicateExpression filter = new PredicateExpression();
            filter.Add(StoreFields.Id == storeId);
            SortExpression sorter = new SortExpression();
            sorter.Add( LastViewedProductFields.ViewedTime | SortOperator.Descending);


            lastViewedProducts.GetMulti(filter, 5, sorter, relationsToUse, prefetchPath);

            return lastViewedProducts;
        }

        public ProductCollection GetRelatedProducts(int pid)
        {
            ProductEntity product = new ProductEntity(pid);

            ProductKeywordCollection productKeywords = new ProductKeywordCollection();
            productKeywords.GetMulti(null);
            List<int> keywordIds = new List<int>();

            foreach (ProductKeywordEntity item in product.ProductKeywords)
            {
                keywordIds.Add(item.KeywordId);
            }
            //var relatedProductIds = from rp in productKeywords
            //                        group rp by new { ProductID = rp.ProductId, KeywordID = rp.KeywordId } into g
            //                        where keywordIds.Contains(g.Key.KeywordID) && g.Key.KeywordID != 2
            //                        select new
            //                        {
            //                            Key = g.Key
            //                            ,
            //                            Count = g.Select(p => p.ProductId).Count()
            //                        }; // into g  //select new {RCount=g.Key //where keywordIds.Contains(rp.KeywordId) && rp.ProductId != 2 select new { rp.ProductId };


            var relatedProductIds = productKeywords.Where(p => keywordIds.Contains(p.KeywordId) && p.ProductId != pid).GroupBy(g => g.ProductId).Select(gr => new
            {
                ProductId = gr.Key,
                RelatedKeywordCount = gr.Count()
            }).OrderByDescending(f => f.RelatedKeywordCount).Take(5);


            ArrayList ids = new ArrayList();
            foreach (var item in relatedProductIds)
            {
                ids.Add(item.ProductId);
            }

            //Related Products
            ProductCollection productList = new ProductCollection();
            PredicateExpression filter = new PredicateExpression();
            filter.Add(new FieldCompareRangePredicate(ProductFields.Id, ids));
            filter.Add(ProductFields.Status == true);
            productList.GetMulti(filter);

            return productList;
        }

        public object GetProductsByBrandId(int bid)
        {
            ProductCollection productList = new ProductCollection();
            RelationCollection relation = new RelationCollection();
            relation.Add(ProductEntity.Relations.BrandEntityUsingBrandId);
            IPrefetchPath prefatchPath = new PrefetchPath((int)EntityType.ProductEntity);
            prefatchPath.Add(ProductEntity.PrefetchPathBrand);
            PredicateExpression filter = new PredicateExpression();
            filter.Add(BrandFields.Id == bid);

            productList.GetMulti(filter, 0, null, relation, prefatchPath);

            return productList;
        }

        public object GetLastAddedProducts(int topSelect)
        {
            ProductCollection productList = new ProductCollection();
            SortExpression sorter = new SortExpression();
            sorter.Add(ProductFields.AddedDate | SortOperator.Descending);
            PredicateExpression filter = new PredicateExpression();
            
            filter.Add(ProductFields.Status == true);
            productList.GetMulti(filter, topSelect, sorter);

            return productList;
        }

        public string GetProductPhotoUniqueName(int id)
        {
            ProductPhotoEntity pp = new ProductPhotoEntity(id);

            return pp.UniqueName;
        }

        public ProductCollection GetDetailedProduct(int pid)
        {
            IPrefetchPath prefatchPath = new PrefetchPath(EntityType.ProductEntity);
            prefatchPath.Add(ProductEntity.PrefetchPathComments).Filter.Add(CommentFields.Status == true);
            prefatchPath.Add(ProductEntity.PrefetchPathProductKeywords);
            prefatchPath.Add(ProductEntity.PrefetchPathProductSpecifications);
            prefatchPath.Add(ProductEntity.PrefetchPathProductPhotos);
            ProductEntity p = new ProductEntity(pid, prefatchPath);
            ProductCollection col = new ProductCollection();
            col.Add(p);
            return col;
        }

        public ProductCollection GetProductsByCategoryId(int catId)
        {
            int categoryId = catId;

            ProductCollection productList = new ProductCollection();
            IPredicateExpression filter = new PredicateExpression();
            IPrefetchPath prefetchPath = new PrefetchPath((int)EntityType.ProductEntity);
            prefetchPath.Add(ProductEntity.PrefetchPathCategory);
            RelationCollection relation = new RelationCollection();
            relation.Add(ProductEntity.Relations.CategoryEntityUsingCategoryId);
            filter.Add(CategoryFields.Id == categoryId);

            productList.GetMulti(filter, 0, null, relation, prefetchPath);

            return productList;
        }
        public ProductCollection GetProductsByMainCategoryId(int baseCatId)
        {
            int baseCategoryId = baseCatId;
            ProductCollection productList = new ProductCollection();
            IPredicateExpression filter = new PredicateExpression();
            IPrefetchPath prefetchPath = new PrefetchPath((int)EntityType.ProductEntity);
            prefetchPath.Add(ProductEntity.PrefetchPathCategory);
            RelationCollection relation = new RelationCollection();
            relation.Add(ProductEntity.Relations.CategoryEntityUsingCategoryId);
            filter.Add(CategoryFields.BaseCategoryId == baseCategoryId);

            productList.GetMulti(filter, 0, null, relation, prefetchPath);

            return productList;
        }
        public ProductCollection GetProductsByStoreId(int storeId)
        {
            int strId = storeId;
            ProductCollection productList = new ProductCollection();
            IPredicateExpression filter = new PredicateExpression();
            IPrefetchPath prefetchPath = new PrefetchPath((int)EntityType.ProductEntity);
            prefetchPath.Add(ProductEntity.PrefetchPathStore);
            RelationCollection relation = new RelationCollection();
            relation.Add(ProductEntity.Relations.StoreEntityUsingStoreId);
            filter.Add(StoreFields.Id == strId);

            productList.GetMulti(filter, 0, null, relation, prefetchPath);

            return productList;
        }

        public ProductEntity GetProductById(int id)
        {
            return new ProductEntity(id);
        }

        public ProductCollection GetProductsByKeyword(string keyword)
        {
            ProductCollection productList = new ProductCollection();
            IPredicateExpression filter = new PredicateExpression();
            RelationCollection relations = new RelationCollection();
            relations.Add(ProductEntity.Relations.ProductKeywordEntityUsingProductId);
            relations.Add(KeywordEntity.Relations.ProductKeywordEntityUsingKeywordId);
            filter.Add(new FieldLikePredicate(KeywordFields.Keyword, null, "%" + keyword + "%"));

            productList.GetMulti(filter, 0, null, relations);

            return productList;
        }

        public ProductCollection GetProductsByKeywordAndBaseCatId(string keyword, int baseCatId)
        {
            int baseCategoryId = baseCatId;

            ProductCollection productList = new ProductCollection();
            IPrefetchPath prefetchCategory = new
                PrefetchPath((int)EntityType.ProductEntity);
            prefetchCategory.Add(ProductEntity.PrefetchPathCategory);
            RelationCollection relations = new RelationCollection();
            relations.Add(ProductEntity.Relations.CategoryEntityUsingCategoryId);
            relations.Add(ProductEntity.Relations.ProductKeywordEntityUsingProductId);
            relations.Add(KeywordEntity.Relations.ProductKeywordEntityUsingKeywordId);

            IPredicateExpression filter = new
                PredicateExpression();

            filter.Add(new FieldLikePredicate(KeywordFields.Keyword, null, "%" + keyword + "%"));
            filter.Add(CategoryFields.BaseCategoryId == baseCategoryId);

            productList.GetMulti(filter, 0, null, relations, prefetchCategory);

            return productList;
        }

        public string GetTotalProducts()
        {
            ProductCollection productList = new ProductCollection();
            productList.GetMulti(null);
            return productList.Count.ToString();
        }

        public ProductCollection SortProductsByTitle(ProductCollection productList, bool isAscending)
        {
            productList.Sort((int)ProductFieldIndex.Title, isAscending ? System.ComponentModel.ListSortDirection.Ascending : System.ComponentModel.ListSortDirection.Descending);
            return productList;
        }
        public ProductCollection SortProductsByPrice(ProductCollection productList, bool isAscending)
        {
            productList.Sort((int)ProductFieldIndex.Price, isAscending ? System.ComponentModel.ListSortDirection.Ascending : System.ComponentModel.ListSortDirection.Descending);
            return productList;
        }
        //public ProductCollection SortProductsByRate(ProductCollection productList, bool isAscending)
        //{

        //}

        public ProductCollection GetLast5AddedProducts(object m)
        {
            MembershipEntity member = new MembershipEntity(3);
            ProductCollection products = new ProductCollection();
            RelationCollection relations = new RelationCollection();
            relations.Add(ProductEntity.Relations.StoreEntityUsingStoreId);
            relations.Add(StoreEntity.Relations.MembershipEntityUsingMembershipId);

            IPrefetchPath prefatchPath = new PrefetchPath((int)EntityType.ProductEntity);
            prefatchPath.Add(ProductEntity.PrefetchPathStore).SubPath.Add(StoreEntity.PrefetchPathMembership);

            PredicateExpression filter = new PredicateExpression();

            filter.Add(MembershipFields.Id == member.Id);

            SortExpression sorter = new SortExpression();

            sorter.Add(ProductFields.AddedDate | SortOperator.Descending);
            products.GetMulti(filter, 5, sorter, relations, prefatchPath);

            return products;
        }
        public ProductCollection GetLast10AddedProducts()
        {

            ProductCollection products = new ProductCollection();

            SortExpression sorter = new SortExpression();

            sorter.Add(ProductFields.AddedDate | SortOperator.Descending);
            products.GetMulti(null, 10,sorter);

            return products;
        }

        public ProductCollection GetAllProducts()
        {
            ProductCollection products = new ProductCollection();

            products.GetMulti(null);

            return products;
        }


        public bool DeleteProductSpecification(int productId, string SpecificationName)
        {
            ProductEntity product = new ProductEntity(productId);

            return product.ProductSpecifications.Where<ProductSpecificationEntity>(p => p.ProductId == productId && p.SpecificationName == SpecificationName).FirstOrDefault().Delete();
        }
        public bool DeleteProductKeyword(int productId, int keywordId)
        {
            ProductKeywordEntity pk = new ProductKeywordEntity(keywordId, productId);
            return pk.Delete();
        }
        public bool DeleteProductPhoto(int id)
        {
            ProductPhotoEntity pp = new ProductPhotoEntity(id);
            return pp.Delete();
        }
        public void AddProductKeyword(int productId, string keyword)
        {
            ProductEntity p = new ProductEntity(productId);
            KeywordCollection keywords = new KeywordCollection();
            keywords.GetMulti(null);

            if (keywords.Any(pr => pr.Keyword == keyword))
            {
                int keywordId = keywords.Where<KeywordEntity>(f => f.Keyword == keyword).FirstOrDefault().Id;

                ProductKeywordEntity productKeyword = new ProductKeywordEntity();
                productKeyword.KeywordId = keywordId;
                productKeyword.ProductId = productId;
                productKeyword.Save();
            }
            else
            {
                KeywordEntity k = new KeywordEntity();
                k.Keyword = keyword;
                k.Save();

                ProductKeywordEntity newProductKeyword = new ProductKeywordEntity();
                newProductKeyword.KeywordId = k.Id;
                newProductKeyword.ProductId = productId;
                newProductKeyword.Save();

            }

        }

        public void AddProductSpecification(int productid, string name, string value)
        {
            ProductSpecificationEntity ps = new ProductSpecificationEntity() { SpecificationName = name, SpecificationValue = value, ProductId = productid };
            ps.Save();
        }

        public void AddProductPhoto(int productId, string photoUniqueName)
        {
            ProductPhotoEntity productPhoto = new ProductPhotoEntity();
            productPhoto.ProductId = productId;
            productPhoto.UniqueName = photoUniqueName;
            productPhoto.Save();
        }

        public ProductEntity AddProduct(string title, double price, string redirectUrl, int catId, int brandId, string detail, bool newItemStatus, bool freeShippingStatus, int storeId)
        {
            ProductEntity product = new ProductEntity();
            product.Title = title;
            product.Price = price;
            product.CategoryId = catId;
            product.BrandId = brandId;
            product.DetailDescription = detail;
            product.Status = false;
            product.StoreId = storeId;
            product.IsNewItem = newItemStatus;
            product.IsSliderProduct = false;
            product.IsSpeacialProduct = false;
            product.IsFreeShipping = freeShippingStatus;
            product.AddedDate = DateTime.Now;
            product.RedirectUrl = redirectUrl;

            product.Save();

            return product;
        }

        public void AddLastViewedProduct(int productId, DateTime time, string ipAdress)
        {
            DateTime t = DateTime.Parse(time.ToShortDateString());
            if (CheckViewList(productId, t, ipAdress))
            {
                LastViewedProductEntity lastViewedProduct = new LastViewedProductEntity();
                lastViewedProduct.ProductId = productId;
                lastViewedProduct.ViewedTime = t;
                lastViewedProduct.IpAdrees = ipAdress;
                lastViewedProduct.Save();
            }
        }
        public bool CheckViewList(int productId, DateTime time, string ipAdress)
        {
            LastViewedProductCollection lastViewedList = new LastViewedProductCollection();
            lastViewedList.GetMulti(null);
            if (lastViewedList.Any(p => p.ProductId == productId && p.ViewedTime == time && p.IpAdrees == ipAdress))
                return false;
            else
                return true;
        }

        public void UpdateProduct(int productId, string title, double price, string redirectUrl, int catId, int brandId, string detail, bool status, bool slideStatus
            , bool specialStatus, bool newItemStatus, bool freeShippingStatus)
        {
            ProductEntity product = new ProductEntity(productId);
            product.Title = title;
            product.Price = price;
            product.RedirectUrl = redirectUrl;
            product.CategoryId = catId;
            product.BrandId = brandId;
            product.DetailDescription = detail;
            product.Status = status;
            product.IsSliderProduct = slideStatus;
            product.IsSpeacialProduct = specialStatus;
            product.IsNewItem = newItemStatus;
            product.IsFreeShipping = freeShippingStatus;
            product.Save();
        }
    }
}
