using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ProductSearchEngine.Business;
using ProductSearchEngine.Surragates;
using ProductSearchEngine.CollectionClasses;

namespace ProductSearchEngine.WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in code, svc and config file together.
    public class ProductService : IProductService
    {

        public IList<Surragates.Product> GetSliderProducts()
        {
           ProductCollection LlblgenSliderProducts = new ProductSearchEngine.Business.Adapters.ProductAdapter().GetSliderProducts();

           IList<Product> returnProductList = new List<Product>();

           foreach (var item in LlblgenSliderProducts)
           {
               returnProductList.Add(new Product()
               {
                   Id = item.Id,
                   Description=item.DetailDescription,
                   Price =(double)item.Price,
                   Title=item.Title,
                   PhotoGuid="slider"+item.Id
                   //PhotoGuid = item.ProductPhotos.FirstOrDefault().UniqueName
               });
           }

           return returnProductList;
        }

        public IList<Product> GetProductsByKeyword(string keyword)
        {
            ProductCollection LlblgenKeywordProducts = new ProductSearchEngine.Business.Adapters.ProductAdapter().GetProductsByKeyword(keyword);

            IList<Product> returnProductList = new List<Product>();

            foreach (var item in LlblgenKeywordProducts)
            {
                returnProductList.Add(new Product()
                {
                    Id = item.Id,
                    Description = item.DetailDescription,
                    Price = (double)item.Price,
                    Title = item.Title,
                    PhotoGuid = "slider" + item.Id
                    //PhotoGuid = item.ProductPhotos.FirstOrDefault().UniqueName
                });
            }

            return returnProductList;
        }

        public Product GetProductById(int id)
        {
            ProductSearchEngine.EntityClasses.ProductEntity LlblgenProduct = new ProductSearchEngine.Business.Adapters.ProductAdapter().GetProductById(id);
            return new Product()
           {
               Id = LlblgenProduct.Id,
               Description = LlblgenProduct.DetailDescription,
               Price = (double)LlblgenProduct.Price,
               Title = LlblgenProduct.Title,
               PhotoGuid = "slider" + LlblgenProduct.Id
               //PhotoGuid = item.ProductPhotos.FirstOrDefault().UniqueName
           };      
        }   
    }
}
