using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class BlogDAO
    {
        private static BlogDAO instance = null;
        private static readonly object instanceLock = new object();
        public static BlogDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BlogDAO();
                    }
                    return instance;
                }
            }
        }
        public List<object> GetPosts()
        {
            List<object> list = new List<object>();
            try
            {
                using(var context = new BirdClinicDBContext())
                {
                    var query = from p in context.TblBlogs
                                join u in context.TblUsers on p.AuthorId equals u.UserId
                                select new
                                {
                                    p.BlogId,
                                    u.FullName,
                                    p.Title,
                                    p.Content,
                                    p.DatePublished,
                                    p.Tag
                                };
                    foreach (var item in query)
                    {
                        list.Add(item);
                    }
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public List<object> ShowBlog(int id)
        {
            List<object> list = new List<object>();
            try
            {
                using(var context = new BirdClinicDBContext())
                {
                    var query = from p in context.TblBlogs
                                join u in context.TblUsers on p.AuthorId equals u.UserId
                                where p.BlogId == id
                                select new
                                {
                                    p.BlogId,
                                    u.FullName,
                                    p.Title,
                                    p.Content,
                                    p.DatePublished,
                                    p.Tag
                                };
                    foreach(var item in query)
                    {
                        list.Add(item);
                    }
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public TblBlog GetBlogById(int id)
        {
            TblBlog blog = null;
            try
            {
                using(var context = new BirdClinicDBContext())
                {
                    blog = context.TblBlogs.Include(b => b.Author).FirstOrDefault(b => b.BlogId == id);
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return blog;
        }
        public void UpdateBlog(int id, string title, string content, string tag, int author, DateTime datePublished)
        {
            try
            {
                using(var context = new BirdClinicDBContext())
                {
                    var blog = context.TblBlogs.Find(id);
                    if(blog != null)
                    {
                        blog.Title = title;
                        blog.Content = content;
                        blog.Tag = tag;
                        blog.AuthorId = author;
                        context.SaveChanges();
                    }
                }
            }catch(Exception ex )
            {
                throw new Exception(ex.Message);
            }
        }
        public List<TblUser> GetAuthors()
        {
            var list = new List<TblUser>();
            try
            {
                using(var context = new BirdClinicDBContext())
                {
                    var authors = context.TblUsers.Where(u => (u.RoleId == 2) || (u.RoleId == 4)).ToList();
                    foreach(var u in authors)
                    {
                        list.Add(u);
                    }
                }

            }catch(Exception ex )
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public void AddBlog(string title, string content, string tag, int author, DateTime datePublished)
        {
            try
            {
                using(var context = new BirdClinicDBContext())
                {
                    TblBlog blog = new TblBlog()
                    {
                        Title = title,
                        Content = content,
                        Tag = tag,
                        AuthorId = author,
                        DatePublished = datePublished
                    };
                    context.Add(blog);
                    context.SaveChanges();
                }
            }catch(Exception ex )
            {
                throw new Exception(ex.Message);
            }
        }
        public void RemoveBlog(int id)
        {
            try
            {
                using(var context = new BirdClinicDBContext())
                {
                    var blog = context.TblBlogs.FirstOrDefault(b => b.BlogId == id);
                    if (blog != null)
                    {
                        context.Remove(blog);
                        context.SaveChanges();
                    }
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
