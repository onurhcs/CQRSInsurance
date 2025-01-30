using CQRSInsurance.Context;
using CQRSInsurance.ModeiatorDesignPattern.Queries.FaqQueries;
using CQRSInsurance.ModeiatorDesignPattern.Results.FaqResults;
using MediatR;

namespace CQRSInsurance.ModeiatorDesignPattern.Handlers.FaqHandlers
{
    public class GetFaqByIdQueryHandler : IRequestHandler<GetFaqByIdQuery, GetFaqByIdQueryResult>
    {
        private readonly CQRSContext _context;

        public GetFaqByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task<GetFaqByIdQueryResult> Handle(GetFaqByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Faqs.FindAsync(request.FaqId);
            return new GetFaqByIdQueryResult
            {
                Question = values.Question,
                FaqId = values.FaqId,
                Answer = values.Answer,
                Icon = values.Icon,
                IsActive = values.IsActive
            };
        }
    }
}
