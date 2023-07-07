using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class TblMedicalRecord
    {
        public int MedicalId { get; set; }
        public int? UserId { get; set; }
        public int? BirdId { get; set; }
        public int? DoctorId { get; set; }
        public DateTime? Date { get; set; }
        public string Diagnosis { get; set; }
        public string Intruction { get; set; }

        public virtual TblBird Bird { get; set; }
        public virtual TblUser Doctor { get; set; }
        public virtual TblUser User { get; set; }
    }
}
