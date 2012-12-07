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
    public class BrandAdapter
    {
        public object GetBrandList()
        {
            BrandCollection brands = new BrandCollection();
            brands.GetMulti(null);
            return brands;
        }
        public BrandEntity GetBrandById(int bid)
        {
            return new BrandEntity(bid);
        }
        public bool RemoveBrand(int brandId)
        {
            BrandEntity brand = new BrandEntity(brandId);
            return brand.Delete();
        }
        public void AddBrand(string name)
        {
            BrandEntity brand = new BrandEntity();
            brand.Name = name;
            brand.Save();
        }
        public void UpdateBrand(int brandId, string name)
        {
            BrandEntity brand = new BrandEntity(brandId);
            brand.Name = name;
            brand.Save();
        }

    }
}
