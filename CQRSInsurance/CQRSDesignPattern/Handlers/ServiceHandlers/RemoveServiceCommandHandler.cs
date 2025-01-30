using CQRSInsurance.Context;
using CQRSInsurance.CQRSDesignPattern.Command.ServiceCommands;

namespace CQRSInsurance.CQRSDesignPattern.Handlers.ServiceHandlers
{
    public class RemoveServiceCommandHandler
    {
        private readonly CQRSContext _context;

        public RemoveServiceCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveServiceCommand commad)
        {
            var values = await _context.Services.FindAsync(commad.ServiceId);
            _context.Services.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
