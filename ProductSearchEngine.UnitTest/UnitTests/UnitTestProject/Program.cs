using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductSearchEngine.EntityClasses;
using ProductSearchEngine.CollectionClasses;
using ProductSearchEngine.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using ProductSearchEngine;
using System.Collections;
using System.Data;
using ProductSearchEngine.DaoClasses;
using System.Security.Cryptography;

namespace UnitTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Get Main Categories*/

            //CategoryCollection categories = new CategoryCollection();
            //PredicateExpression filter = new PredicateExpression();
            //filter.Add(new FieldCompareNullPredicate(CategoryFields.BaseCategoryId));
            //categories.GetMulti(filter);

            //Console.WriteLine(categories.Count);

            //foreach (var item in categories)
            //{
            //    Console.WriteLine(item.Name);
            //}

            /*Get Categories with Sub Cotegories*/

            //CategoryCollection categories = new CategoryCollection();
            //PredicateExpression filter = new PredicateExpression();
            //filter.Add(new FieldCompareNullPredicate(CategoryFields.BaseCategoryId));
            //categories.GetMulti(filter);

            //foreach (var item in categories)
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine("--Sub Categories--");
            //    foreach (var subCategory in item.Categories)
            //    {
            //        Console.WriteLine(subCategory.Name);
            //    }
            //    Console.WriteLine("**************************");
            //}

            /*Get Sub Categories with Main CategoryId*/

            //CategoryCollection subCategories = new CategoryCollection();
            //PredicateExpression filter = new PredicateExpression();
            //IPrefetchPath prefetchPath = new PrefetchPath((int)EntityType.CategoryEntity);
            //prefetchPath.Add(CategoryEntity.PrefetchPathCategories);
            //filter.Add(CategoryFields.BaseCategoryId == 1);
            //subCategories.GetMulti(filter, prefetchPath);

            //foreach (var item in subCategories)
            //{
            //    Console.WriteLine(item.Name);
            //    foreach (var sub in item.Categories)
            //    {
            //        Console.WriteLine(sub.Name);
            //    }
            //}

            /*Get Slider Product With Rating,Price,Title,Desc with SubString,Image.*/

            //ProductCollection sliderProducts = new ProductCollection();
            //PredicateExpression filter = new PredicateExpression();
            //IPrefetchPath prefetchPath = new PrefetchPath((int)EntityType.ProductEntity);
            //IPrefetchPathElement path = prefetchPath.Add(ProductEntity.PrefetchPathComments);
            //path.SubPath.Add(CommentEntity.PrefetchPathRate);


            //filter.Add(ProductFields.IsSliderProduct == true);
            //sliderProducts.GetMulti(filter, prefetchPath);


            //foreach (var item in sliderProducts)
            //{
            //    Console.WriteLine(item.Title);
            //    Console.WriteLine(item.Price + "TL");
            //    Console.WriteLine(item.DetailDescription.Substring(0,item.DetailDescription.Length/5)+"...");
            //    int rateCount = 0;
            //    int totalRate = 0;
            //    foreach (var itemComments in item.Comments)
            //    {
            //        rateCount++;
            //        totalRate += (int)itemComments.Rate.Value;
            //    }
            //    if(rateCount>0)
            //    Console.WriteLine("Rate :"+totalRate / rateCount);
            //    //Console.WriteLine("Photo :"+item.ProductPhotos.FirstOrDefault().UniqueName);
            //}

            /* Add Product Photos */
            //for (int i = 0; i < 4; i++)
            //{
            //    ProductEntity product = new ProductEntity(6);

            //    ProductPhotoEntity productPhotos = new ProductPhotoEntity();
            //    productPhotos.Product = product;

            //    productPhotos.UniqueName = Guid.NewGuid() + ".jpg";

            //    productPhotos.Save();


            //}

            /*Slider Products Photos*/
            //ProductPhotoCollection productPhotos = new ProductPhotoCollection();
            //RelationCollnection relationsToUse = new RelationCollection();
            //relationsToUse.Add(ProductPhotoEntity.Relations.ProductEntityUsingProductId);


            //IPredicateExpression selectFilter = new PredicateExpression();
            //selectFilter.Add(ProductFields.IsSliderProduct==true);
            //productPhotos.GetMulti(selectFilter, 0, null, relationsToUse);


            //var productPhotosDistinct = productPhotos.GroupBy(p => p.ProductId).Select(g => g.First());

            //foreach (var item in productPhotosDistinct)
            //{
            //    Console.WriteLine(item.ProductId +"  "+ item.UniqueName);
            //    Console.WriteLine("-------------------");
            //}

            /*Searching by Keywords*/
            //string keyword = "laptop";
            //ProductCollection productList = new ProductCollection();
            //IPredicateExpression filter = new PredicateExpression();
            //RelationCollection relations = new RelationCollection();
            //relations.Add(ProductEntity.Relations.ProductKeywordEntityUsingProductId);
            //relations.Add(KeywordEntity.Relations.ProductKeywordEntityUsingKeywordId);
            //filter.Add(new FieldLikePredicate(KeywordFields.Keyword,null,"%"+keyword+"%"));

            //productList.GetMulti(filter,0,null,relations);

            //foreach (var item in productList)
            //{
            //    Console.WriteLine(item.Title);
            //}


            /*Get Product with Category Id*/
            //int categoryId = 13;

            //ProductCollection productList = new ProductCollection();
            //IPredicateExpression filter = new PredicateExpression();
            //IPrefetchPath prefetchPath = new PrefetchPath((int)EntityType.ProductEntity);
            //prefetchPath.Add(ProductEntity.PrefetchPathCategory);
            //RelationCollection relation = new RelationCollection();
            //relation.Add(ProductEntity.Relations.CategoryEntityUsingCategoryId);
            //filter.Add(CategoryFields.Id == categoryId);

            //productList.GetMulti(filter, 0, null, relation,prefetchPath);

            //foreach (var item in productList)
            //{
            //    Console.WriteLine(item.Title);
            //    Console.WriteLine("Kategorisi: {0}",item.Category.Name);
            //}

            /*Get Product with BaseCategoryId*/
            //int baseCategoryId = 8; //Computer
            //ProductCollection productList = new ProductCollection();
            //IPredicateExpression filter = new PredicateExpression();
            //IPrefetchPath prefetchPath = new PrefetchPath((int)EntityType.ProductEntity);
            //prefetchPath.Add(ProductEntity.PrefetchPathCategory);
            //RelationCollection relation = new RelationCollection();
            //relation.Add(ProductEntity.Relations.CategoryEntityUsingCategoryId);
            //filter.Add(CategoryFields.BaseCategoryId == baseCategoryId);

            //productList.GetMulti(filter, 0, null, relation, prefetchPath);

            //foreach (var item in productList)
            //{
            //    Console.WriteLine(item.Title);
            //    Console.WriteLine("Kategorisi: {0}", item.Category.Name);
            //}

            /*Get Product with Keywrod and BaseCategoryId*/
            //int baseCategoryId = 8;
            //string keyword = "Laptop";
            //ProductCollection productList = new ProductCollection();
            //IPrefetchPath prefetchCategory = new
            //    PrefetchPath((int)EntityType.ProductEntity);
            //prefetchCategory.Add(ProductEntity.PrefetchPathCategory);
            //RelationCollection relations = new RelationCollection();
            //relations.Add(ProductEntity.Relations.CategoryEntityUsingCategoryId);
            //relations.Add(ProductEntity.Relations.ProductKeywordEntityUsingProductId);
            //relations.Add(KeywordEntity.Relations.ProductKeywordEntityUsingKeywordId);

            //IPredicateExpression filter = new
            //    PredicateExpression();

            //filter.Add(new FieldLikePredicate(KeywordFields.Keyword,null,"%"+keyword+"%"));
            //filter.Add(CategoryFields.BaseCategoryId == baseCategoryId);

            //productList.GetMulti(filter, 0, null, relations, prefetchCategory);

            ///* City Id'ye göre Düzenleme*/
            //List<ProductEntity> products = productList.Where(p => p.Store.Membership.StoreInformation.CityId == 7).ToList<ProductEntity>();
            //foreach (var item in products)
            //{
            //    Console.WriteLine(item.Title);
            //    Console.WriteLine("KAtegorisi : {0}",item.Category.Name);
            //    Console.WriteLine("Base Categoryisi {0}",
            //        item.Category.Category.Name);
            //}

            /*Get Related Products*/

            ProductEntity product = new ProductEntity(2);

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


            var relatedProductIds = productKeywords.Where(p => keywordIds.Contains(p.KeywordId) && p.ProductId != 2).GroupBy(g => g.ProductId).Select(gr => new
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

            productList.GetMulti(filter);

            /*Get Product List by Brand Id*/
            //ProductCollection productList = new ProductCollection();
            //RelationCollection relation = new RelationCollection();
            //relation.Add(ProductEntity.Relations.BrandEntityUsingBrandId);
            //IPrefetchPath prefatchPath = new PrefetchPath((int)EntityType.ProductEntity);
            //prefatchPath.Add(ProductEntity.PrefetchPathBrand);
            //PredicateExpression filter = new PredicateExpression();
            //filter.Add(BrandFields.Id == 2);

            //productList.GetMulti(filter,0,null,relation,prefatchPath);

            /*Get Last 3 Added Products*/
            //ProductCollection productList = new ProductCollection();
            //SortExpression sorter = new SortExpression();
            //sorter.Add(ProductFields.AddedDate | SortOperator.Descending);
            //productList.GetMulti(null, 3, sorter);

            /*Get Product Tags*/




            /* Get Detailed Product*/
            //IPrefetchPath prefatchPath = new PrefetchPath(EntityType.ProductEntity);
            //prefatchPath.Add(ProductEntity.PrefetchPathComments);
            //prefatchPath.Add(ProductEntity.PrefetchPathProductKeywords);
            //prefatchPath.Add(ProductEntity.PrefetchPathProductSpecifications);
            //prefatchPath.Add(ProductEntity.PrefetchPathProductPhotos);
            //ProductEntity p = new ProductEntity(2, prefatchPath);

            /*Sort Özellikleri*/
            //Sort By A-Z


            //ProductCollection productList = new ProductCollection();

            //RelationCollection relation = new RelationCollection();
            //relation.Add(ProductEntity.Relations.BrandEntityUsingBrandId);
            //relation.Add(ProductEntity.Relations.CommentEntityUsingProductId);
            //relation.Add(CommentEntity.Relations.RateEntityUsingRateId);

            ////IPrefetchPath prefatchPath = new PrefetchPath((int)EntityType.ProductEntity);
            ////prefatchPath.Add(ProductEntity.PrefetchPathBrand);
            ////prefatchPath.Add(ProductEntity.PrefetchPathComments).SubPath.Add(CommentEntity.PrefetchPathRate);
            //PredicateExpression filter = new PredicateExpression();
            //filter.Add(BrandFields.Id == 2);
            //productList.GetMulti(filter, 0, null, relation);
            //foreach (var item in productList)
            //{
            //    Console.WriteLine(item.Id + " " + item.Title);
            //}

            //productList.Sort((int)ProductFieldIndex.Price, System.ComponentModel.ListSortDirection.Ascending);

            ////SortExpression sorter = new SortExpression();
            ////sorter.Add(ProductFields.Id | SortOperator.Descending);
            ////productList.GetMulti(filter, 0, sorter, relation);

            //Console.WriteLine("***********************************");
            //foreach (var item in productList)
            //{
            //    Console.WriteLine(item.Id + " " + item.Title);

            //}

            /*Get Keywords by searching text*/
            //KeywordCollection keywords = new KeywordCollection();
            //PredicateExpression filter = new PredicateExpression();
            //string keyword = "ap";
            //filter.Add(new FieldLikePredicate(KeywordFields.Keyword,null,keyword+"%"));

            //keywords.GetMulti(filter);

            //foreach (var item in keywords)
            //{
            //    Console.WriteLine(item.Keyword);
            //}
            //Console.Read();

            /*Get Store Products*/

            //MembershipEntity member = new MembershipEntity(3);
            //ProductCollection products = new ProductCollection();
            //RelationCollection relations = new RelationCollection();
            //relations.Add(ProductEntity.Relations.StoreEntityUsingStoreId);
            //relations.Add(StoreEntity.Relations.MembershipEntityUsingMembershipId);

            //IPrefetchPath prefatchPath = new PrefetchPath((int)EntityType.ProductEntity);
            //prefatchPath.Add(ProductEntity.PrefetchPathStore).SubPath.Add(StoreEntity.PrefetchPathMembership);

            //PredicateExpression filter = new PredicateExpression();

            //filter.Add(MembershipFields.Id == member.Id);

            //SortExpression sorter = new SortExpression();

            //sorter.Add(ProductFields.AddedDate | SortOperator.Descending);
            //products.GetMulti(filter, 5,sorter,relations,prefatchPath);


            //ProductEntity product = new ProductEntity(6);

            //product.ProductSpecifications.Where<ProductSpecificationEntity>(p => p.ProductId == 6 && p.SpecificationName == "Color").FirstOrDefault().Delete();

            //ResultsetFields fields = new ResultsetFields(2);
            //fields.DefineField(WebTrackerFields.IpAddress, 0, "Id");
            //fields.DefineField(WebTrackerFields.Id, 1, "Amount");
            //fields[1].AggregateFunctionToApply = AggregateFunction.CountDistinct;

            //DataTable results = new DataTable();
            //TypedListDAO dao = new TypedListDAO();
            //dao.GetMultiAsDataTable(fields, results, 0, null, null, null, true, null, null, 0, 0);


            SHA1 sha = new SHA1CryptoServiceProvider();

            string SifrelenecekVeri = "123456";

            string SifrelenmisVeri = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(SifrelenecekVeri)));

            Console.WriteLine(SifrelenmisVeri);

            Console.ReadLine();


        }
    }
}
