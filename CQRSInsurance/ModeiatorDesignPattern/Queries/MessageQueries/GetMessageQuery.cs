using CQRSInsurance.ModeiatorDesignPattern.Results.MessageResults;
using MediatR;

namespace CQRSInsurance.ModeiatorDesignPattern.Queries.MessageQueries
{
    public class GetMessageQuery : IRequest<List<GetMessageQueryResult>>
    {
    }
}
