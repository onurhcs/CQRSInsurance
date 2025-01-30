using CQRSInsurance.Context;
using CQRSInsurance.CQRSDesignPattern.Command.TestimonialCommands;

namespace CQRSInsurance.CQRSDesignPattern.Handlers.TestimonialHandlers
{
    public class RemoveTestimonialCommandHandler
    {
        private readonly CQRSContext _context;

        public RemoveTestimonialCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveTestimonialCommand commad)
        {
            var values = await _context.Testimonials.FindAsync(commad.TestimonialId);
            _context.Testimonials.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
