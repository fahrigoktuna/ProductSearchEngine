using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductSearchEngine.CollectionClasses;
using ProductSearchEngine.EntityClasses;

namespace ProductSearchEngine.Business.Adapters
{
    public class StoreAdapter
    {
        public StoreCollection GetAllStores()
        {
            StoreCollection stores = new StoreCollection();
            
            stores.GetMulti(null);

            return stores;
        }

        public bool DeleteStore(int storeId)
        {
            StoreEntity store = new StoreEntity(storeId);
 
            return  store.Delete();
        }

        public void AddStore(string name,string userName,string password,bool status,int roleId)
        {
            StoreEntity store = new StoreEntity();
            store.Name = name;
            store.Membership = new MembershipEntity();

            store.Membership.UserName = userName;
            store.Membership.Password = password;
            store.Membership.Status = status;
            store.Membership.RoleId = roleId;
            store.Membership.Save();
            store.Save();
        }
        public void ChangeStoreStatus(int id,bool status)
        {
            MembershipEntity membership = new MembershipEntity(id);
            membership.Status = status;

            membership.Save();
        }
    }
}
