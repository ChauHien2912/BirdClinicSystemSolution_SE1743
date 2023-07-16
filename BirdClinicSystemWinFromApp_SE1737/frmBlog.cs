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
    public partial class frmBlog : Form
    {
        IBlogRepository blogRepository = new BlogRepository();
        public frmBlog()
        {
            InitializeComponent();
            LoadBlogs();
            if(Properties.Settings.Default.MyRole == 3) 
            {
                btnAdd.Visible = false;
                btnRemove.Visible = false;
                btnUpdate.Visible = false;
            }
        }
        #region Methods
        private void LoadBlogs()
        {
            flBlog.Controls.Clear();
            var blogs = blogRepository.GetBlogs();
            Random random = new Random();
            foreach (var blog in blogs)
            {
                Button btnBlog = new Button
                {
                    Width = 120,
                    Height = 100,
                    BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point),
                    Tag = blog.GetType().GetProperty("BlogId").GetValue(blog),
                    Text = blog.GetType().GetProperty("Title").GetValue(blog).ToString(),
                };
                btnBlog.MouseDown += btnBlog_DoubleClick;
                flBlog.Controls.Add(btnBlog);
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
        private DateTime lastClickTime = DateTime.Now;
        private void btnBlog_DoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Button btnBlog = (Button)sender;
                txtBlogID.Text = btnBlog.Tag.ToString();
                TimeSpan timeSinceLastClick = DateTime.Now - lastClickTime;
                if (timeSinceLastClick.TotalMilliseconds < SystemInformation.DoubleClickTime)
                {
                    frmBlogDetail frmBlogDetail = new frmBlogDetail(Convert.ToInt32(txtBlogID.Text));
                    frmBlogDetail.ShowDialog();
                }
                lastClickTime = DateTime.Now;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmBlogAction frmBlogAction = new frmBlogAction();
            frmBlogAction.ShowDialog();
            LoadBlogs();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBlogID.Text != "")
            {
                frmBlogAction frmBlogAction = new frmBlogAction(Convert.ToInt32(txtBlogID.Text));
                frmBlogAction.ShowDialog();
                LoadBlogs();
            }
            else
            {
                MessageBox.Show("Please pick the blog to update!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }

        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBoxQuestion("Do you want to delete the blog"))
            {
                blogRepository.RemoveBlog(Convert.ToInt32(txtBlogID.Text));
                txtBlogID.Text = "";
                LoadBlogs();
            }
        }
        #endregion




    }
}
