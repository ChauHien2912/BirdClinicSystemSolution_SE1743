using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdClinicSystemWinFromApp_SE1737
{
    public partial class frmBlogDetail : Form
    {
        IBlogRepository blogRepository = new BlogRepository();
        public int Id { get; set; }
        public frmBlogDetail(int id)
        {
            InitializeComponent();
            this.Id = id;
            LoadBlog();
        }
        #region Methdos
        private void LoadBlog()
        {
            var blog = blogRepository.ShowBlog(Id);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = blog;

            lbTitle.DataBindings.Add("Text", bindingSource, "Title");
            txtContent.DataBindings.Add("Text", bindingSource, "Content");
            lbAuthor.DataBindings.Add("Text", bindingSource, "FullName");
            lbPublishDate.DataBindings.Add("Text", bindingSource, "DatePublished");
            txtContent.Enabled = false;
        }
        #endregion

        #region Events
        #endregion

    }
}
