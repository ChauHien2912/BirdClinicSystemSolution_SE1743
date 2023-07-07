using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class TblBlog
    {
        public int BlogId { get; set; }
        public int? AuthorId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? DatePublished { get; set; }
        public string Tag { get; set; }

        public virtual TblUser Author { get; set; }
    }
}
