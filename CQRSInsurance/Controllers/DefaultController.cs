using CQRSInsurance.Context;
using CQRSInsurance.Entities;
using CQRSInsurance.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CQRSInsurance.Controllers
{
    public class DefaultController : Controller
    {
        private readonly CQRSContext _context;

        public DefaultController(CQRSContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = new IndexViewModel
            {
                BlogPosts = _context.BlogPosts.ToList(),
                CompanyInfos = _context.CompanyInfos.ToList(),
                Features = _context.Features.ToList(),
                Services = _context.Services.ToList(),
                Statistics = _context.Statistics.ToList(),
                Teams = _context.Teams.ToList(),
                Testimonials = _context.Testimonials.ToList()
            };

            return View(model); 
        }
        public PartialViewResult PartialHead() 
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar() 
        {
            return PartialView();
        }
        public PartialViewResult PartialSearch() 
        {
            return PartialView();
        }

        public PartialViewResult PartialCoursel() 
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            var values = _context.Features.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAbout() 
        {
            return PartialView();
        }
        public PartialViewResult PartialService() 
        {
            var values = _context.Services.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialBlog() 
        {
            var values = _context.BlogPosts.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTeam()
        {
            var values = _context.Teams.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonial() 
        {
            var values = _context.Testimonials.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();

        }
        public PartialViewResult PartialScript() 
        {
            return PartialView();

        }


        public PartialViewResult PartialContact()
        {
            return PartialView();

        }

        public PartialViewResult PartialOurService()
        {
            // Veritabanından verileri çekiyoruz (örnek)
            var testimonials = _context.Testimonials.ToList();
            var services = _context.Services.ToList();

            // ViewModel'e verileri ekliyoruz
            var viewModel = new IndexViewModel
            {
                Testimonials = testimonials,
                Services = services
            };

            return PartialView(viewModel);

        }

        public PartialViewResult PartialAbouts()
        {
            // Veritabanından verileri çekiyoruz (örnek)
            var testimonials = _context.Testimonials.ToList();
            var services = _context.Services.ToList();
            var faqs = _context.Faqs.ToList();
            
            var features = _context.Features.ToList();

            // ViewModel'e verileri ekliyoruz
            var viewModel = new IndexViewModel
            {
                Testimonials = testimonials,
                Faqs = faqs,
                Features = features,
                Services = services
            };

            return PartialView(viewModel);

        }

    }
}
