using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using ProductSearchEngine.Surragates;

namespace ProductSearchEngine.WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductService" in both code and config file together.
    [ServiceContract(Namespace = "http://192.168.2.2/ProductService.svc")]
    public interface IProductService
    {
        [OperationContract]
        [WebGet(
            UriTemplate = "/GetSliderProducts",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat= WebMessageFormat.Json)]
        IList<Product> GetSliderProducts();

        [OperationContract]
        [WebGet(
            UriTemplate = "/GetProductsByKeyword",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        IList<Product> GetProductsByKeyword(string keyword);

        [OperationContract]
        [WebGet(
            UriTemplate = "/GetProductById",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        Product GetProductById(int id);
    }
}
