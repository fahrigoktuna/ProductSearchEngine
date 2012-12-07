using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductSearchEngine.CMS
{
    public partial class CommentList : BaseTypes.AdminType
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadData();
        }

        private void LoadData()
        {
            CommentListRepeater.DataSource = new ProductSearchEngine.Business.Adapters.CommentAdapter().GetCommentList();
            CommentListRepeater.DataBind();
        }

        protected void RemoveLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton lnkButton = sender as LinkButton;
            new ProductSearchEngine.Business.Adapters.CommentAdapter().RemoveComment(int.Parse(lnkButton.CommandArgument));

            LoadData();
        }
        protected void ChangeStatusLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton lnkButton = sender as LinkButton;
            new ProductSearchEngine.Business.Adapters.CommentAdapter().ChangeStatusComment(lnkButton.Text=="Add List" ? true : false,int.Parse(lnkButton.CommandArgument));

            LoadData();
        }
    }
}