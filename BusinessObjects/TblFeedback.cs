using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class TblFeedback
    {
        public int FeedbackId { get; set; }
        public int? AppointmentId { get; set; }
        public int? Rating { get; set; }
        public string Comment { get; set; }

        public virtual TblAppointment Appointment { get; set; }
    }
}
