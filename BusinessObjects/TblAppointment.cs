using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class TblAppointment
    {
        public TblAppointment()
        {
            TblFeedbacks = new HashSet<TblFeedback>();
        }

        public int AppointmentId { get; set; }
        public int? UserId { get; set; }
        public int? BirdId { get; set; }
        public int? StaffId { get; set; }
        public int? DoctorId { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public TimeSpan? AppointmentTime { get; set; }
        public int? Status { get; set; }
        public int? ServiceId { get; set; }

        public virtual TblBird Bird { get; set; }
        public virtual TblUser Doctor { get; set; }
        public virtual TblService Service { get; set; }
        public virtual TblUser Staff { get; set; }
        public virtual TblUser User { get; set; }
        public virtual ICollection<TblFeedback> TblFeedbacks { get; set; }
    }
}
