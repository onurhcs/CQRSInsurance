using CQRSInsurance.ModeiatorDesignPattern.Results.FaqResults;
using MediatR;

namespace CQRSInsurance.ModeiatorDesignPattern.Queries.FaqQueries
{
    public class GetFaqByIdQuery : IRequest<GetFaqByIdQueryResult>
    {
        public GetFaqByIdQuery(int FaqId)
        {
            FaqId = FaqId;
        }

        public int FaqId { get; set; }

    }
}
