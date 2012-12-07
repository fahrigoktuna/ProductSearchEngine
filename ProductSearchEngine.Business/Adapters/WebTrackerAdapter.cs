using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductSearchEngine.EntityClasses;
using ProductSearchEngine.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using ProductSearchEngine.HelperClasses;
using ProductSearchEngine.DaoClasses;
using System.Data;
using System.Data.SqlClient;

namespace ProductSearchEngine.Business.Adapters
{
    public class WebTrackerAdapter
    {
        public void AddTracking(DateTime date,string ipAddress,string browser)
        {
            WebTrackerEntity webTacker = new WebTrackerEntity();
            webTacker.VisitTime = DateTime.Parse(date.ToShortDateString());
            webTacker.IpAddress = ipAddress;
            webTacker.Browser = browser;
            webTacker.Save();
        }

        public string GetTotalVisit()
        {
            WebTrackerCollection trackers = new WebTrackerCollection();
            trackers.GetMulti(null);
            return trackers.Count.ToString();
        }
        public string GetTodayVisit()
        {
            WebTrackerCollection trackers = new WebTrackerCollection();
            PredicateExpression filter = new PredicateExpression();
            filter.Add(WebTrackerFields.VisitTime == DateTime.Parse(DateTime.Now.ToShortDateString()));
            trackers.GetMulti(filter);
            return trackers.Count.ToString();
        }
        public string GetMostVisitedIP()
        {
            SqlConnection con = new SqlConnection("data source=46.235.15.92;initial catalog=ProductSearchEngine;User ID=kaan;Password=241312;persist security info=False;packet size=4096");
            con.Open();
            SqlCommand com = new SqlCommand("SELECT IpAddress,count(*) as amount FROM [ProductSearchEngine].[dbo].[WebTracker] group by IpAddress order by amount desc", con);
            SqlDataReader dr = com.ExecuteReader();

            string amount="";
            if (dr.Read())
            {
                amount = dr[0].ToString();
            }
            con.Close();
            return amount;
        }
        public string GetMostVisitedBrowser()
        {
            SqlConnection con = new SqlConnection("data source=46.235.15.92;initial catalog=ProductSearchEngine;User ID=kaan;Password=241312;persist security info=False;packet size=4096");
            con.Open();
            SqlCommand com = new SqlCommand("SELECT Browser,count(*) as amount FROM [ProductSearchEngine].[dbo].[WebTracker] group by Browser order by amount desc", con);
            SqlDataReader dr = com.ExecuteReader();
            string amount = "";
            if (dr.Read())
            {
                amount = dr[0].ToString();
            }
            con.Close();
            return amount;
        }

        
    }
}
