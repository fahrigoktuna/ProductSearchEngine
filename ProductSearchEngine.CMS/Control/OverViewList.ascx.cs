using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductSearchEngine.CMS.Control
{
    public partial class OverViewList : System.Web.UI.UserControl
    {
        protected string TotalVisit{get;set;} 
						protected string	TodayVisit {get;set;}
						protected string	TotalComments{get;set;}
						protected string	TotalProducts {get;set;}
                       protected string     MostVisitedIp {get;set;}
                       protected string MostVisitedBrowser { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadData();
        }

        private void LoadData()
        {
            GetTotalVisitCount();
            GetTodayVisitCount();
            GetTotalComments();
            GetTotalProducts();
            GetMostVisitedIP();
            GetMostVisitedBrowser();
        }

        private void GetTotalVisitCount()
        {
            TotalVisit = new ProductSearchEngine.Business.Adapters.WebTrackerAdapter().GetTotalVisit();
        }

        private void GetTodayVisitCount()
        {
            TodayVisit = new ProductSearchEngine.Business.Adapters.WebTrackerAdapter().GetTodayVisit();
        }

        private void GetTotalComments()
        {
            TotalComments = new ProductSearchEngine.Business.Adapters.CommentAdapter().GetTotalCommentCount();
        }

        private void GetTotalProducts()
        {
            TotalProducts = new ProductSearchEngine.Business.Adapters.ProductAdapter().GetTotalProducts();
        }

        private void GetMostVisitedBrowser()
        {
            MostVisitedBrowser = new ProductSearchEngine.Business.Adapters.WebTrackerAdapter().GetMostVisitedBrowser();
        }

        private void GetMostVisitedIP()
        {
          MostVisitedIp =   new ProductSearchEngine.Business.Adapters.WebTrackerAdapter().GetMostVisitedIP();
        }
    }
}