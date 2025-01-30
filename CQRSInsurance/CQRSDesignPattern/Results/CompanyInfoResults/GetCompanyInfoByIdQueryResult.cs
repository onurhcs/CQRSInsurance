namespace CQRSInsurance.CQRSDesignPattern.Results.CompanyInfoResults
{
    public class GetCompanyInfoByIdQueryResult
    {
        public int CompanyInfoId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ButtonText { get; set; }
        public string ButtonLink { get; set; }
    }
}
