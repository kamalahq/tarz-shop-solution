using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarz.WebUI.Models.Entities;

namespace Tarz.WebUI.Models.DataContexts
{
    public class TarzDbContext : DbContext
    {
        public TarzDbContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AppInfo> AppInfos { get; set; }
        public DbSet<ProductSize> Sizes { get; set; }
        public DbSet<ProductSizeColorPrice> ProductSizeColorPrices { get; set; }
        public DbSet<Gender> Genders { get; set; }

    }
}
