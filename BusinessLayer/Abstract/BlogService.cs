using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface BlogService:GenericService<Blog>
    {
        public void RestoreDeleted(Blog p);
        public void FullDelete(Blog p);
        public void BlogImageUpdate(Blog p);
      
        List<Blog> ThreeBlog();


    }
}
