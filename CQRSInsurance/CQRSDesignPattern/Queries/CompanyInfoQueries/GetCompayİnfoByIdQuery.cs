namespace CQRSInsurance.CQRSDesignPattern.Queries.CompanyInfoQueries
{
    public class GetCompayİnfoByIdQuery
    {
        public GetCompayİnfoByIdQuery(int companyInfoId)
        {
            CompanyInfoId = companyInfoId;
        }

        public int CompanyInfoId { get; set; }
    }
}
