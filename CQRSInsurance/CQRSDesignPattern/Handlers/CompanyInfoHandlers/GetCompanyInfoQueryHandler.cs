using CQRSInsurance.Context;
using CQRSInsurance.CQRSDesignPattern.Results.CompanyInfoResults;
using Microsoft.EntityFrameworkCore;

namespace CQRSInsurance.CQRSDesignPattern.Handlers.CompanyInfoHandlers
{
    public class GetCompanyInfoQueryHandler
    {
        private readonly CQRSContext _context;

        public GetCompanyInfoQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task<List<GetCompanyInfoQueryResult>> Handle()
        {
            var values = await _context.CompanyInfos.ToListAsync();
            return values.Select(x => new GetCompanyInfoQueryResult
            {

                Title = x.Title,
                Description = x.Description,
                ButtonText = x.ButtonText,
                ButtonLink = x.ButtonLink
            }).ToList();
        }
    }
}
