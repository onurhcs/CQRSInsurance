using CQRSInsurance.Context;
using CQRSInsurance.CQRSDesignPattern.Results.CompanyInfoResults;

namespace CQRSInsurance.CQRSDesignPattern.Handlers.CompanyInfoHandlers
{
    public class GetCompanyInfoByIdQueryHandler
    {
        private readonly CQRSContext _context;
        public GetCompanyInfoByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public async Task<GetCompanyInfoByIdQueryResult> Handle(GetCompanyInfoQueryResult query)
        {
            var values = await _context.CompanyInfos.FindAsync(query.CompanyInfoId);
            return new GetCompanyInfoByIdQueryResult
            {
                CompanyInfoId = values.CompanyInfoId,
                Title = values.Title,
                Description = values.Description,
                ButtonText = values.ButtonText,
                ButtonLink = values.ButtonLink
            };
        }
    }
}
