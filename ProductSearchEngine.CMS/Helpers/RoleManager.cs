using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductSearchEngine.EntityClasses;
using System.Web.UI.WebControls;
using ProductSearchEngine.CMS.Control;

namespace ProductSearchEngine.CMS.Helpers
{
    public class RoleManager
    {
        public void SetRole(Panel AdminPanel,Panel StorePanel,object m)
        {
            MembershipEntity member = (MembershipEntity)m;

            if (member.RoleId == (int)Enums.MembershipRoles.Admin)
            {
                AdminPanel.Visible = true;
                StorePanel.Visible = false;
            }
            else
            {
                AdminPanel.Visible = false;
                StorePanel.Visible = true;
            }
        }

       

        public void SetRole(object m, params System.Web.UI.UserControl[] userControls)
        {
            MembershipEntity member = (MembershipEntity)m;

            if (member.RoleId == (int)Enums.MembershipRoles.Admin)
            {
                foreach (System.Web.UI.UserControl item in userControls)
                {
                    switch (item.ID)
                    {
                        case "StoreInformationUserControl":
                            StoreInformation StoreInformation = (StoreInformation)item;
                            StoreInformation.IsLoad = false;
                            StoreInformation.Visible = false;
                            break;
                        case "StoreListUserControl":
                            Control.StoreList StoreList = (Control.StoreList)item;
                           
                            StoreList.IsLoad = true;
                            break;
                        case "Last5AddedProductsUserControl":
                            Control.Last5AddedProducts Last5AddedProducts = (Control.Last5AddedProducts)item;
                            Last5AddedProducts.IsLoad = false;
                            Last5AddedProducts.Visible = false;
                            break;
                        case "Last10AddedProductsUserControl":
                            Last10AddedProducts Last10AddedProducts = (Last10AddedProducts)item;
                            Last10AddedProducts.IsLoad = true;
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                foreach (var item in userControls)
                {
                    switch (item.ID)
                    {
                        case "StoreInformationUserControl":
                            StoreInformation StoreInformation = (StoreInformation)item;
                            StoreInformation.IsLoad = true;
                            break;
                        case "StoreListUserControl":
                            Control.StoreList StoreList = (Control.StoreList)item;
                            StoreList.IsLoad = false;
                            StoreList.Visible = false;
                            break;
                        case "Last5AddedProductsUserControl":
                            Control.Last5AddedProducts Last5AddedProducts = (Control.Last5AddedProducts)item;
                            Last5AddedProducts.IsLoad = true;
                            
                            break;
                        case "Last10AddedProductsUserControl":
                            Last10AddedProducts Last10AddedProducts = (Last10AddedProducts)item;
                            Last10AddedProducts.IsLoad = false;
                            Last10AddedProducts.Visible = false;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}