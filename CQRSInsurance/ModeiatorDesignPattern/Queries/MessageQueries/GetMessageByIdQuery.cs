using CQRSInsurance.ModeiatorDesignPattern.Results.MessageResults;
using MediatR;

namespace CQRSInsurance.ModeiatorDesignPattern.Queries.MessageQueries
{
    public class GetMessageByIdQuery : IRequest<GetMessageByIdQueryResult>
    {
        public GetMessageByIdQuery(int messageId)
        {
            MessageId = messageId;
        }

        public int MessageId { get; set; }

    }
}
