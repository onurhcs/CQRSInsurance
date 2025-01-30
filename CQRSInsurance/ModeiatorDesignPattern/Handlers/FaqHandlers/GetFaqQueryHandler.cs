using CQRSInsurance.Context;
using CQRSInsurance.ModeiatorDesignPattern.Queries.FaqQueries;
using CQRSInsurance.ModeiatorDesignPattern.Results.FaqResults;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRSInsurance.ModeiatorDesignPattern.Handlers.FaqHandlers
{
    public class GetFaqQueryHandler : IRequestHandler<GetFaqQuery, List<GetFaqQueryResult>>
    {
        private readonly CQRSContext _context;
        public GetFaqQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public async Task<List<GetFaqQueryResult>> Handle(GetFaqQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Faqs.ToListAsync();
            return values.Select(x => new GetFaqQueryResult
            {
                FaqId = x.FaqId,
                Question = x.Question,
                Answer = x.Answer,
                Icon = x.Icon,
                IsActive = x.IsActive
            }).ToList();
        }
    }
}
