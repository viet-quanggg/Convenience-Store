using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Category
    {
        public Category()
        {
            Merchandises = new HashSet<Merchandise>();
        }

        public int IdCategory { get; set; }
        public string NameCateGory { get; set; }

        public virtual ICollection<Merchandise> Merchandises { get; set; }
    }
}
