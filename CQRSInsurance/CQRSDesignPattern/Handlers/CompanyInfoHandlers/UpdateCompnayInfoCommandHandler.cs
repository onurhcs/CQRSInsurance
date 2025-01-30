using CQRSInsurance.Context;
using CQRSInsurance.CQRSDesignPattern.Command.CompanyInfoCommands;

namespace CQRSInsurance.CQRSDesignPattern.Handlers.CompanyInfoHandlers
{
    public class UpdateCompnayInfoCommandHandler
    {
        private readonly CQRSContext _context;

        public UpdateCompnayInfoCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateCompanyInfoCommand commad)
        {
            var values = await _context.CompanyInfos.FindAsync(commad.CompanyInfoId);
            values.Title = commad.Title;
            values.Description = commad.Description;
            values.ButtonText = commad.ButtonText;
            values.ButtonLink = commad.ButtonLink;
            await _context.SaveChangesAsync();
        }
    }
}
