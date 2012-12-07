using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductSearchEngine.EntityClasses;
using ProductSearchEngine.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using ProductSearchEngine.HelperClasses;

namespace ProductSearchEngine.Business.Adapters
{
    public class MemberShipAdapter
    {
        public MembershipEntity GetMember(string uName, string password)
        {
            MembershipCollection memberships = new MembershipCollection();
            PredicateExpression filter = new PredicateExpression();
            filter.AddWithAnd(MembershipFields.UserName == uName);
            filter.AddWithAnd(MembershipFields.Password == Business.Encryption.SHA1Encryption.EncryptMessage(password));
            filter.AddWithAnd(MembershipFields.Status == true);
            memberships.GetMulti(filter);
            if (memberships.Count > 0)
                return memberships.FirstOrDefault();
            else
                return null;
        }

        public MembershipEntity UpdateMember(MembershipEntity member)
        {
            member.Save();
            return member;
        }
    }
}
