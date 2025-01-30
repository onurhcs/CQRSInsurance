using CQRSInsurance.Context;
using CQRSInsurance.CQRSDesignPattern.Command.ServiceCommands;

namespace CQRSInsurance.CQRSDesignPattern.Handlers.ServiceHandlers
{
    public class UpdateServiceCommandHandler
    {
        private readonly CQRSContext _context;

        public UpdateServiceCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateServiceCommand commad)
        {
            var values = await _context.Services.FindAsync(commad.ServiceId);
            values.Title = commad.Title;
            values.Description = commad.Description;
            values.Image = commad.Image;
            values.ButtonText = commad.ButtonText;
            values.ButtonLink = commad.ButtonLink;
            await _context.SaveChangesAsync();
        }
    }
}
