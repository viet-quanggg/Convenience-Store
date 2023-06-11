using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Account
    {
        public Account()
        {
            Bills = new HashSet<Bill>();
            ExportBills = new HashSet<ExportBill>();
        }

        public int AccId { get; set; }
        public string AccName { get; set; }
        public string AccPass { get; set; }
        public DateTime AccCreatedTime { get; set; }
        public DateTime AccDob { get; set; }
        public string AccPhone { get; set; }
        public int AccRole { get; set; }
        public string AccAddress { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<ExportBill> ExportBills { get; set; }
    }
}
