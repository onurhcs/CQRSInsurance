using CQRSInsurance.Context;
using CQRSInsurance.ModeiatorDesignPattern.Queries.MessageQueries;
using CQRSInsurance.ModeiatorDesignPattern.Results.MessageResults;
using MediatR;

namespace CQRSInsurance.ModeiatorDesignPattern.Handlers.MessageHandlers
{
    public class GetMessageByIdQueryHandler : IRequestHandler<GetMessageByIdQuery, GetMessageByIdQueryResult>
    {
        private readonly CQRSContext _context;

        public GetMessageByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task<GetMessageByIdQueryResult> Handle(GetMessageByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Messages.FindAsync(request.MessageId);
            return new GetMessageByIdQueryResult
            {
                MessageId = values.MessageId,
                Name = values.Name,
                Email = values.Email,
                Phone = values.Phone,
                Project = values.Project,
                Subject = values.Subject,
                MessageText = values.MessageText
            };
        }
    }
}
