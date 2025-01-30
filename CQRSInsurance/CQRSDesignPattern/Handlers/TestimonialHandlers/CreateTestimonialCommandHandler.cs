using CQRSInsurance.Context;
using CQRSInsurance.CQRSDesignPattern.Command.TestimonialCommands;
using CQRSInsurance.Entities;

namespace CQRSInsurance.CQRSDesignPattern.Handlers.TestimonialHandlers
{
    public class CreateTestimonialCommandHandler
    {
        private readonly CQRSContext _context;

        public CreateTestimonialCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateTestimonialCommand commad)
        {
            _context.Testimonials.Add(new Testimonial()
            {
                CustomerName = commad.CustomerName,
                JobTitle = commad.JobTitle,
                Rating = commad.Rating,
                Comment = commad.Comment,
                Image = commad.Image,
            });
            await _context.SaveChangesAsync();
        }
    }
}
