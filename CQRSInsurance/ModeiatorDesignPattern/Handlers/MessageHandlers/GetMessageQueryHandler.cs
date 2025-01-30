using CQRSInsurance.Context;
using CQRSInsurance.ModeiatorDesignPattern.Queries.MessageQueries;
using CQRSInsurance.ModeiatorDesignPattern.Results.MessageResults;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRSInsurance.ModeiatorDesignPattern.Handlers.MessageHandlers
{
    public class GetMessageQueryHandler : IRequestHandler<GetMessageQuery, List<GetMessageQueryResult>>
    {
        private readonly CQRSContext _context;
        public GetMessageQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public async Task<List<GetMessageQueryResult>> Handle(GetMessageQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Messages.ToListAsync();
            return values.Select(x => new GetMessageQueryResult
            {
                MessageId = x.MessageId,
                Name = x.Name,
                Email = x.Email,
                Phone = x.Phone,
                Project = x.Project,
                Subject = x.Subject,
                MessageText = x.MessageText
            }).ToList();
        }
    }
}
