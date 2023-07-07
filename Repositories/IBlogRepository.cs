using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using BusinessObjects;

namespace Repositories
{
    public interface IBlogRepository
    {
        public IEnumerable GetBlogs();
        public dynamic ShowBlog(int id);
        public TblBlog GetBlogById(int id);
        public IEnumerable GetAuhtors();
        public void UpdateBlog(int id, string title, string content, string tag, int author, DateTime datePublished);
        public void AddBlog(string title, string content, string tag, int author, DateTime datePublished);
        public void RemoveBlog(int id);
    }
}
