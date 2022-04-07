using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarz.WebUI.Models.Entities
{
    public class ProductImages
    {
        public string ImagePath { get; set; }
        public int ProductId { get; set; }
        public Products Product { get; set; }
        public bool IsMain { get; set; }

    }
}
