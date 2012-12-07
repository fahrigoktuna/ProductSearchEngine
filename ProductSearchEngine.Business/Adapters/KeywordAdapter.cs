using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductSearchEngine.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using ProductSearchEngine.HelperClasses;

namespace ProductSearchEngine.Business.Adapters
{
    public class KeywordAdapter
    {
        public string GetKeywordListPrefix(string prefix)
        {
            KeywordCollection keywords = new KeywordCollection();
            PredicateExpression filter = new PredicateExpression();
           
            filter.Add(new FieldLikePredicate(KeywordFields.Keyword, null, prefix + "%"));

            keywords.GetMulti(filter);

            StringBuilder sb = new StringBuilder();

            foreach (var item in keywords)
            {
                sb.Append(item.Keyword).Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}
