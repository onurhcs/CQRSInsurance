using CQRSInsurance.Context;
using CQRSInsurance.CQRSDesignPattern.Results.FeatureResults;
using Microsoft.EntityFrameworkCore;

namespace CQRSInsurance.CQRSDesignPattern.Handlers.FeatureHandlers
{
    public class GetFeatureQueryHandler
    {
        private readonly CQRSContext _context;

        public GetFeatureQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task<List<GetFeatureQueryResult>> Handle()
        {
            var values = await _context.Features.ToListAsync();
            return values.Select(x => new GetFeatureQueryResult
            {
                FeatureId = x.FeatureId,
                Icon = x.Icon,
                Title = x.Title,
                Description = x.Description,
                ButtonText = x.ButtonText,
                ButtonLink = x.ButtonLink
            }).ToList();
        }
    }
}
