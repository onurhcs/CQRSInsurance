namespace CQRSInsurance.CQRSDesignPattern.Queries.FeatureQueries
{
    public class GetFeatureByIdQuery
    {
        public GetFeatureByIdQuery(int featureId)
        {
            FeatureId = featureId;
        }

        public int FeatureId { get; set; }
    }
}
