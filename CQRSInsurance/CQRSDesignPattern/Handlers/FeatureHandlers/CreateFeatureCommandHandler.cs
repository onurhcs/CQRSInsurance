using CQRSInsurance.Context;
using CQRSInsurance.CQRSDesignPattern.Command.FeatureCommands;
using CQRSInsurance.Entities;

namespace CQRSInsurance.CQRSDesignPattern.Handlers.FeatureHandlers
{
    public class CreateFeatureCommandHandler
    {
        private readonly CQRSContext _context;

        public CreateFeatureCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateFeatureCommand commad)
        {
            _context.Features.Add(new Feature()
            {
                Icon = commad.Icon,
                Title = commad.Title,
                Description = commad.Description,
                ButtonText = commad.ButtonText,
                ButtonLink = commad.ButtonLink

            });
            await _context.SaveChangesAsync();
        }
    }
}
