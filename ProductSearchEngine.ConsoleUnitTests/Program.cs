using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ProductSearchEngine.ConsoleUnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductSearchEngineWCFService.ProductServiceClient client = new ProductSearchEngineWCFService.ProductServiceClient();

            List<ProductSearchEngineWCFService.Product> products = client.GetSliderProducts();
        }
    }
}
