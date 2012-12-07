using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ProductSearchEngine.Surragates
{
    [DataContract]
    public class Product
    {
        [DataMember(Name = "photoguid")]
        public string PhotoGuid
        {
            get;
            set;
        }
        [DataMember(Name = "id")]
        public int Id
        {
            get;
            set;
        }
        [DataMember(Name = "title")]
        public string Title
        {
            get;
            set;
        }
        [DataMember(Name = "price")]
        public double Price
        {
            get;
            set;
        }
        [DataMember(Name = "desc")]
        public string Description
        {
            get;
            set;
        }
    }
}
