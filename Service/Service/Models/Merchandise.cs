using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Merchandise
    {
        public Merchandise()
        {
            Bills = new HashSet<Bill>();
            ImportBills = new HashSet<ImportBill>();
        }

        public int MerId { get; set; }
        public string MerName { get; set; }
        public string MerDescription { get; set; }
        public double MerPrice { get; set; }
        public int MerQuantity { get; set; }
        public string MerUnit { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<ImportBill> ImportBills { get; set; }
    }
}
