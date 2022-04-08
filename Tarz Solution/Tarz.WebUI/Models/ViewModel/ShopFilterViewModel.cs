using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarz.WebUI.Models.Entities;

namespace Tarz.WebUI.Models.ViewModel
{
    public class ShopFilterViewModel
    {
        public List <Brand> Brands { get; set; }
        public List<Color> Colors { get; set; }
        public List<ProductSize> Sizes { get; set; }
        public List<Category> Categories { get; set; }
    }
}
