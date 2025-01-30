using CQRSInsurance.Context;
using CQRSInsurance.CQRSDesignPattern.Queries.FeatureQueries;
using CQRSInsurance.CQRSDesignPattern.Results.FeatureResults;

namespace CQRSInsurance.CQRSDesignPattern.Handlers.FeatureHandlers
{
    public class GetFeatureByIdQueryHandler
    {
        private readonly CQRSContext _context;
        public GetFeatureByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public async Task<GetFeatureByIdQueryResult> Handle(GetFeatureByIdQuery query)
        {
            var values = await _context.Features.FindAsync(query.FeatureId);
            return new GetFeatureByIdQueryResult
            {
                FeatureId = values.FeatureId,
                Icon = values.Icon,
                Title = values.Title,
                Description = values.Description,
                ButtonText = values.ButtonText,
                ButtonLink = values.ButtonLink
            };
        }
    }
}
