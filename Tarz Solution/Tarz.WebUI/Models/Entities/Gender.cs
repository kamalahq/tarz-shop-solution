using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarz.WebUI.Models.Entities
{
    public class Gender : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<ProductSizeColorPrice> ProductSizeColorPrice { get; set; }
    }
}
