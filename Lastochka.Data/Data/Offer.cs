using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lastochka.Data
{
    public partial class Offer
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int? Discount { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Available { get; set; }
        public string Picture { get; set; }
        public DateTime LastModified { get; set; }

        public virtual Category Category { get; set; }
    }
}