using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lastochka.Data
{
    public partial class Category
    {
        public Category()
        {
            Offers = new HashSet<Offer>();
        }

        public int Id { get; set; }
        public string Text { get; set; }
        public int? ParentId { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }
    }
}