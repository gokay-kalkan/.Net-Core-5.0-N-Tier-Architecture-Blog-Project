using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : CommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment p)
        {
            p.CommentDate = DateTime.Now;
            p.CommentStatus = true;
            p.CommentCheckStatus = false;
            
            _commentDal.Add(p);
        }

        public void CommentCheckUpdate(Comment p)
        {
            var comment = _commentDal.GetById(p.CommentId);
            comment.CommentCheckStatus = true;
            _commentDal.Update(comment);
        }

        public void Delete(Comment p)
        {
            _commentDal.Delete(p);
        }

        public Comment GetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> List()
        {
            return _commentDal.List();
        }

        public List<Comment> List(Expression<Func<Comment, bool>> filter)
        {
            return _commentDal.List(filter);
        }

        public void Update(Comment p)
        {
            
            _commentDal.Update(p);
        }
    }
}
