using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdClinicSystemWinFromApp_SE1737
{
    public partial class frmBlogAction : Form
    {
        IBlogRepository blogRepository = new BlogRepository();
        public int Id { get; set; }
        public frmBlogAction()
        {
            InitializeComponent();
            LoadAuthors();
            btnAction.Click += btnAdd_Click;
            btnAction.Text = "Add";
        }
        public frmBlogAction(int blogId)
        {
            InitializeComponent();
            this.Id = blogId;
            LoadAuthors();
            LoadBlog();
            btnAction.Click += btnUpdate_Click;
            btnAction.Text = "Update";
        }

        #region Methods
        public void LoadAuthors()
        {
            try
            {
                var authors = blogRepository.GetAuhtors();
                cbAuthors.DataSource = authors;
                cbAuthors.DisplayMember = "FullName";
                cbAuthors.ValueMember = "UserId";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void LoadBlog()
        {
            try
            {
                TblBlog blog = blogRepository.GetBlogById(Id);
                txtTitle.Text = blog.Title;
                txtContent.Text = blog.Content;
                cbAuthors.Text = blog.Author.FullName;
                txtTag.Text = blog.Tag;
                dtpDatePublish.Text = blog.DatePublished.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private bool MessageBoxQuestion(string content)
        {
            DialogResult d = MessageBox.Show(content, Text + " - Notification", MessageBoxButtons.OKCancel,
                                             MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Events
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Length != 0 && txtContent.Text.Length != 0)
            {
                if (MessageBoxQuestion("Do you want to update the blog?"))
                {
                    blogRepository.UpdateBlog(Id, txtTitle.Text, txtContent.Text, txtTag.Text, Convert.ToInt32(cbAuthors.SelectedValue.ToString()), Convert.ToDateTime(dtpDatePublish.Text));
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid input, Title and Context can not be empty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Length != 0 && txtContent.Text.Length != 0)
            {
                blogRepository.AddBlog(txtTitle.Text, txtContent.Text, txtTag.Text, Convert.ToInt32(cbAuthors.SelectedValue.ToString()), Convert.ToDateTime(dtpDatePublish.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid input, Title and Context can not be empty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
        #endregion
    }
}
