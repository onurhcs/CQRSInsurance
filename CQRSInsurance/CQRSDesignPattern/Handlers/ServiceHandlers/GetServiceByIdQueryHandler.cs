using CQRSInsurance.Context;
using CQRSInsurance.CQRSDesignPattern.Results.ServiceResults;

namespace CQRSInsurance.CQRSDesignPattern.Handlers.ServiceHandlers
{
    public class GetServiceByIdQueryHandler
    {
        private readonly CQRSContext _context;
        public GetServiceByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public async Task<GetServiceByIdQueryResult> Handle(GetServiceQueryResult query)
        {
            var values = await _context.Services.FindAsync(query.ServiceId);
            return new GetServiceByIdQueryResult
            {
                ServiceId = values.ServiceId,
                Title = values.Title,
                Description = values.Description,
                ButtonText = values.ButtonText,
                ButtonLink = values.ButtonLink
            };
        }
    }
}
