﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class TblRole
    {
        public TblRole()
        {
            TblUsers = new HashSet<TblUser>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<TblUser> TblUsers { get; set; }
    }
}
