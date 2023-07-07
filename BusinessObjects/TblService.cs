using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class TblService
    {
        public TblService()
        {
            TblAppointments = new HashSet<TblAppointment>();
        }

        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int? Status { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }

        public virtual ICollection<TblAppointment> TblAppointments { get; set; }
    }
}
