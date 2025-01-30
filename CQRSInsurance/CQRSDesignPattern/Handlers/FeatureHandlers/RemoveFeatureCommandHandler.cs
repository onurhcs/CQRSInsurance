using CQRSInsurance.Context;
using CQRSInsurance.CQRSDesignPattern.Command.FeatureCommands;

namespace CQRSInsurance.CQRSDesignPattern.Handlers.FeatureHandlers
{
    public class RemoveFeatureCommandHandler
    {
        private readonly CQRSContext _context;

        public RemoveFeatureCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveFeatureCommand commad)
        {
            var values = await _context.Features.FindAsync(commad.FeatureId);
            _context.Features.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
