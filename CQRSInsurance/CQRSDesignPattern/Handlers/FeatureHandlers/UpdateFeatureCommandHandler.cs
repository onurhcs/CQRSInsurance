using CQRSInsurance.Context;
using CQRSInsurance.CQRSDesignPattern.Command.FeatureCommands;

namespace CQRSInsurance.CQRSDesignPattern.Handlers.FeatureHandlers
{
    public class UpdateFeatureCommandHandler
    {
        private readonly CQRSContext _context;

        public UpdateFeatureCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateFeatureCommand commad)
        {
            var values = await _context.Features.FindAsync(commad.FeatureId);
            values.Icon = commad.Icon;
            values.Title = commad.Title;
            values.Description = commad.Description;
            values.ButtonLink = commad.ButtonLink;
            values.ButtonText = commad.ButtonText;
            await _context.SaveChangesAsync();
        }
    }
}
