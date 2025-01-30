using CQRSInsurance.Context;
using CQRSInsurance.CQRSDesignPattern.Command.CompanyInfoCommands;

namespace CQRSInsurance.CQRSDesignPattern.Handlers.CompanyInfoHandlers
{
    public class RemoveCompanyInfoCommandHandler
    {
        private readonly CQRSContext _context;

        public RemoveCompanyInfoCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveCompanyInfoCommand commad)
        {
            var values = await _context.CompanyInfos.FindAsync(commad.CompanyInfoId);
            _context.CompanyInfos.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
