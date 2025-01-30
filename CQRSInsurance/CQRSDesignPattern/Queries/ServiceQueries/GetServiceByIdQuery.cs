namespace CQRSInsurance.CQRSDesignPattern.Queries.ServiceQueries
{
    public class GetServiceByIdQuery
    {
        public GetServiceByIdQuery(int serviceId)
        {
            ServiceId = serviceId;
        }

        public int ServiceId { get; set; }
    }
}
