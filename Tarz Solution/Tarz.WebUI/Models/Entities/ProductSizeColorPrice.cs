using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarz.WebUI.Models.Entities
{
    public class ProductSizeColorPrice : BaseEntity
    {
        public int ProductId { get; set; }
        public Products Product { get; set; }

        public int ColorId { get; set; }
        public Color Color  { get; set; }

        public int SizeId { get; set; }
        public ProductSize ProductSize { get; set; }

        public decimal Price { get; set; }
    }
}
