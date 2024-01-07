using Microsoft.EntityFrameworkCore;
using SignalR.EntityLayer.Entities;
using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Concrete
{
    public class SignalRContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SEDATBASKARPC\\SQLSEDAT;initial Catalog=SignalRDb;integrated Security=true");
        }

        public DbSet <About> Abouts { get; set; }
        public DbSet <Booking> Bookings { get; set; }
        public DbSet <Category> Categorys { get; set; }
        public DbSet <Contact> Contacts { get; set; }
        public DbSet <Discount> Discounts { get; set; }
        public DbSet <Feature> Featurees { get; set; }
        public DbSet <Product> Product { get; set; }
        public DbSet <SocialMedia> SocialMedias { get; set; }
        public DbSet <Testimonial> Testimonials { get; set; }
        public DbSet <Order> Orders { get; set; }
        public DbSet <OrderDetail> OrderDetails { get; set; }
        public DbSet <MoneyCase> MoneyCases { get; set; }
        public DbSet <MenuTable> MenuTables { get; set; }
        public DbSet <Slider> Sliders { get; set; }
        public DbSet <Basket> Baskets { get; set; }
    }
}
