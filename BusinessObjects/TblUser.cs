using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblAppointmentDoctors = new HashSet<TblAppointment>();
            TblAppointmentStaffs = new HashSet<TblAppointment>();
            TblAppointmentUsers = new HashSet<TblAppointment>();
            TblBirds = new HashSet<TblBird>();
            TblBlogs = new HashSet<TblBlog>();
            TblMedicalRecordDoctors = new HashSet<TblMedicalRecord>();
            TblMedicalRecordUsers = new HashSet<TblMedicalRecord>();
        }

        public int UserId { get; set; }
        public int? RoleId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool? Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public virtual TblRole Role { get; set; }
        public virtual ICollection<TblAppointment> TblAppointmentDoctors { get; set; }
        public virtual ICollection<TblAppointment> TblAppointmentStaffs { get; set; }
        public virtual ICollection<TblAppointment> TblAppointmentUsers { get; set; }
        public virtual ICollection<TblBird> TblBirds { get; set; }
        public virtual ICollection<TblBlog> TblBlogs { get; set; }
        public virtual ICollection<TblMedicalRecord> TblMedicalRecordDoctors { get; set; }
        public virtual ICollection<TblMedicalRecord> TblMedicalRecordUsers { get; set; }
    }
}
