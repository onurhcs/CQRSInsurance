using CQRSInsurance.Context;
using CQRSInsurance.CQRSDesignPattern.Command.CompanyInfoCommands;
using CQRSInsurance.Entities;

namespace CQRSInsurance.CQRSDesignPattern.Handlers.CompanyInfoHandlers
{
    public class CreateCompanyInfoCommandHandler
    {
        private readonly CQRSContext _context;

        public CreateCompanyInfoCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateComponyInfoCommand commad)
        {
            _context.CompanyInfos.Add(new CompanyInfo()
            {
                Title = commad.Title,
                Description = commad.Description,
                ButtonText = commad.ButtonText,
                ButtonLink = commad.ButtonLink,
            });
            await _context.SaveChangesAsync();
        }
    }
}
