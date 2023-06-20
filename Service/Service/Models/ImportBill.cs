using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class ImportBill
    {
        public int ImId { get; set; }
        public string ImName { get; set; }
        public string ImProvider { get; set; }
        public DateTime ImDate { get; set; }
        public int MerId { get; set; }
        public int ProId { get; set; }

        public virtual Merchandise Mer { get; set; }
        public virtual Provider Pro { get; set; }
    }
}
