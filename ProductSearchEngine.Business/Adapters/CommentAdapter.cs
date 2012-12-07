using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductSearchEngine.CollectionClasses;
using ProductSearchEngine.EntityClasses;

namespace ProductSearchEngine.Business.Adapters
{
    public class CommentAdapter
    {
        public CommentCollection GetCommentList()
        {
            CommentCollection commentList = new CommentCollection();
            commentList.GetMulti(null);
            return commentList;
        }
        public string GetTotalCommentCount()
        {
            CommentCollection commentList = new CommentCollection();
            commentList.GetMulti(null);
            return commentList.Count.ToString();
        }
        public bool RemoveComment(int id)
        {
            CommentEntity comment = new CommentEntity(id);
            return comment.Delete();
        }
        public void ChangeStatusComment(bool status, int id)
        {
            CommentEntity comment = new CommentEntity(id);
            comment.Status = status;
            comment.Save();
        }
    }
}
