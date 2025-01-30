using CQRSInsurance.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSInsurance.Models
{
    public class IndexViewModel
    {
        public List<Feature> Features { get; set; }
        public List<Service> Services { get; set; }
        public List<Testimonial> Testimonials { get; set; }

        public List<CompanyInfo> CompanyInfos { get; set; }
        public List<Statistic> Statistics { get; set; }
        public List<BlogPost> BlogPosts { get; set; }
        public List<Team> Teams { get; set; }
        public List<Faq> Faqs { get; set; }

    }
}
