using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarz.WebUI.Models.Entities
{
    public class Color
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string HexCode { get; set; }
        public string Description { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
