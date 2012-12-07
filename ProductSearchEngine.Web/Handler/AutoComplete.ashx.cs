using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductSearchEngine.Business.Adapters;

namespace ProductSearchEngine.Web.Handler
{
    /// <summary>
    /// Summary description for AutoComplete
    /// </summary>
    public class AutoComplete : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string prefixText = context.Request.QueryString["q"];
            string keywordListText = new KeywordAdapter().GetKeywordListPrefix(prefixText);
            //context.Response.ContentType = "text/plain";
            context.Response.Write(keywordListText);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}