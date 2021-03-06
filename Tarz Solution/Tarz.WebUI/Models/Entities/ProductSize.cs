using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarz.WebUI.Models.Entities
{
    public class ProductSize : BaseEntity
    {

        public string Abbr { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ProductSizeColorPrice> ProductSizeColorPrice { get; set; }
    }
}
