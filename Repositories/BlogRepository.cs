using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BlogRepository : IBlogRepository
    {
        public void AddBlog(string title, string content, string tag, int author, DateTime datePublished) => BlogDAO.Instance.AddBlog(title, content, tag, author, datePublished);  

        public IEnumerable GetAuhtors() => BlogDAO.Instance.GetAuthors();

        public TblBlog GetBlogById(int id) => BlogDAO.Instance.GetBlogById(id);

        public IEnumerable GetBlogs() => BlogDAO.Instance.GetPosts();

        public void RemoveBlog(int id) => BlogDAO.Instance.RemoveBlog(id);

        public dynamic ShowBlog(int id) => BlogDAO.Instance.ShowBlog(id);

        public void UpdateBlog(int id, string title, string content, string tag, int author, DateTime datePublished) => BlogDAO.Instance.UpdateBlog(id, title, content, tag, author, datePublished);
    }
}
