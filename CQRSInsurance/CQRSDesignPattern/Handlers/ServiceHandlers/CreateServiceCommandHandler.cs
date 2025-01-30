using CQRSInsurance.Context;
using CQRSInsurance.CQRSDesignPattern.Command.ServiceCommands;
using CQRSInsurance.Entities;

namespace CQRSInsurance.CQRSDesignPattern.Handlers.ServiceHandlers
{
    public class CreateServiceCommandHandler
    {
        private readonly CQRSContext _context;

        public CreateServiceCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateServiceCommand commad)
        {
            _context.Services.Add(new Service()
            {
                Title = commad.Title,
                Description = commad.Description,
                Image = commad.Image,
                ButtonText = commad.ButtonText,
                ButtonLink = commad.ButtonLink,
            });
            await _context.SaveChangesAsync();
        }
    }
}
