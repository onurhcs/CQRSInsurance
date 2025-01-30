using CQRSInsurance.Context;
using CQRSInsurance.CQRSDesignPattern.Results.TestimonialResults;

namespace CQRSInsurance.CQRSDesignPattern.Handlers.TestimonialHandlers
{
    public class GetTestimonialByIdQueryHandler
    {
        private readonly CQRSContext _context;
        public GetTestimonialByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialQueryResult query)
        {
            var values = await _context.Testimonials.FindAsync(query.TestimonialId);
            return new GetTestimonialByIdQueryResult
            {
                TestimonialId = values.TestimonialId,
                CustomerName = values.CustomerName,
                JobTitle = values.JobTitle,
                Rating = values.Rating,
                Comment = values.Comment,
                Image = values.Image,
            };
        }
    }
}
