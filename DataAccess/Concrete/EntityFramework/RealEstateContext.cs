using Core.Entities.Concrete;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class RealEstateContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=127.0.0.1;port=3306;database=realestate;uid=root;");
        }
        public DbSet<Advert> adverts { get; set; }
        public DbSet<AdvertCategory> advert_categories { get; set; }
        public DbSet<AdvertImage> advert_images { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<BlogImage> blogs_image { get; set; }
        public DbSet<BlogCategory> blog_categories { get; set; }
        public DbSet<Contact> contact { get; set; }
        public DbSet<Subscriber> subscribers { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<UserOperationClaim> user_operation_claims { get; set; }
        public DbSet<OperationClaim> operation_claims { get; set; }
    }
}
