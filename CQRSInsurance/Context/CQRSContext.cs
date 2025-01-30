using CQRSInsurance.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Globalization;

namespace CQRSInsurance.Context
{
    public class CQRSContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=OnurHcs;initial catalog=InsuranceDb;integrated security=true");


        }
      
        
         
        


        //Case Göre Yapılanlar
        public DbSet<Feature> Features { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<CompanyInfo> CompanyInfos { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Statistic> Statistics{ get; set; }
        public DbSet<BlogPost> BlogPosts{ get; set; }
        public DbSet<Team> Teams{ get; set; }
        public DbSet<Message> Messages{ get; set; }
        public DbSet<Faq> Faqs { get; set; }
    }
}
