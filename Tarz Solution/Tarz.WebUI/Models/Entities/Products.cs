using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarz.WebUI.Models.Entities
{
    public class Products : BaseEntity
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
        public string Description { get; set; }

        public int GenderId { get; set; }
        public Gender Gender { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public virtual ICollection<ProductSizeColorPrice> ProductSizeColorPrice { get; set; }
        public virtual ICollection<ProductImages> ProductImages { get; set; }





    }
}
