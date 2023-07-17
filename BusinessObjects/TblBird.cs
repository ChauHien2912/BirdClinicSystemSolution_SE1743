using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class TblBird
    {
        public TblBird()
        {
            TblAppointments = new HashSet<TblAppointment>();
            TblMedicalRecords = new HashSet<TblMedicalRecord>();
        }

        public int BirdId { get; set; }
        public string Species { get; set; }
        public bool? Gender { get; set; }
        public int? Age { get; set; }
        public double? Weight { get; set; }
        public string Description { get; set; }
        public int? UserId { get; set; }
        public string Name { get; set; }

        public virtual TblUser User { get; set; }
        public virtual ICollection<TblAppointment> TblAppointments { get; set; }
        public virtual ICollection<TblMedicalRecord> TblMedicalRecords { get; set; }
    }
}
