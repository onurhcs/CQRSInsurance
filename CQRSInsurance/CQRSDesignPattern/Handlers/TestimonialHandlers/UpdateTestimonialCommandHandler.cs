using CQRSInsurance.Context;
using CQRSInsurance.CQRSDesignPattern.Command.TestimonialCommands;

namespace CQRSInsurance.CQRSDesignPattern.Handlers.TestimonialHandlers
{
    public class UpdateTestimonialCommandHandler
    {
        private readonly CQRSContext _context;

        public UpdateTestimonialCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateTestimonialCommand commad)
        {
            var values = await _context.Testimonials.FindAsync(commad.TestimonialId);
            values.CustomerName = commad.CustomerName;
            values.JobTitle = commad.JobTitle;
            values.Rating = commad.Rating;
            values.Comment = commad.Comment;
            values.Image = commad.Image;
            await _context.SaveChangesAsync();
        }
    }
}
