namespace CQRSInsurance.CQRSDesignPattern.Results.FeatureResults
{
    public class GetFeatureByIdQueryResult
    {
        public int FeatureId { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ButtonText { get; set; }
        public string ButtonLink { get; set; }
    }
}
