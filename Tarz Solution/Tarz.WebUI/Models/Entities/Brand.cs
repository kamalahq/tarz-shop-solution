using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Tarz.WebUI.Migrations;

namespace Tarz.WebUI.Models.Entities
{
    public class Brand : BaseEntity
    {
       
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection <Product>  Products { get; set; }

    }
}
