using CQRSInsurance.Context;
using CQRSInsurance.CQRSDesignPattern.Results.ServiceResults;
using Microsoft.EntityFrameworkCore;

namespace CQRSInsurance.CQRSDesignPattern.Handlers.ServiceHandlers
{
    public class GetServiceQueryHandler
    {
        private readonly CQRSContext _context;

        public GetServiceQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task<List<GetServiceQueryResult>> Handle()
        {
            var values = await _context.Services.ToListAsync();
            return values.Select(x => new GetServiceQueryResult
            {
                ServiceId = x.ServiceId,
                Title = x.Title,
                Description = x.Description,
                Image = x.Image,
                ButtonText = x.ButtonText,
                ButtonLink = x.ButtonLink
            }).ToList();
        }
    }
}
