using CQRSInsurance.ModeiatorDesignPattern.Results.FaqResults;
using MediatR;

namespace CQRSInsurance.ModeiatorDesignPattern.Queries.FaqQueries
{
    public class GetFaqQuery : IRequest<List<GetFaqQueryResult>>
    {
    }
}
