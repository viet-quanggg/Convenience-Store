using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class ImportBill
    {
        public ImportBill(int imId, string imName, string imProvider, DateTime imDate, int merId, int proId, Merchandise mer, Provider pro)
        {
            ImId = imId;
            ImName = imName;
            ImProvider = imProvider;
            ImDate = imDate;
            MerId = merId;
            ProId = proId;
            Mer = mer;
            Pro = pro;
        }

        public ImportBill()
        {
        }

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
