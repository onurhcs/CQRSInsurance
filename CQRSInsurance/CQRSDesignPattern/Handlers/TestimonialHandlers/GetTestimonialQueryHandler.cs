using CQRSInsurance.Context;
using CQRSInsurance.CQRSDesignPattern.Results.TestimonialResults;
using Microsoft.EntityFrameworkCore;

namespace CQRSInsurance.CQRSDesignPattern.Handlers.TestimonialHandlers
{
    public class GetTestimonialQueryHandler
    {
        private readonly CQRSContext _context;

        public GetTestimonialQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task<List<GetTestimonialQueryResult>> Handle()
        {
            var values = await _context.Testimonials.ToListAsync();
            return values.Select(x => new GetTestimonialQueryResult
            {
                TestimonialId = x.TestimonialId,
                CustomerName = x.CustomerName,
                JobTitle = x.JobTitle,
                Rating = x.Rating,
                Comment = x.Comment,
                Image = x.Image,
            }).ToList();
        }
    }
}
