using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductSearchEngine.CollectionClasses;

namespace ProductSearchEngine.Business.Adapters
{
    public class CityAdapter
    {
        public CityCollection GetCities()
        {
            CityCollection cities = new CityCollection();

            cities.GetMulti(null);

            return cities;
        }
    }
}
