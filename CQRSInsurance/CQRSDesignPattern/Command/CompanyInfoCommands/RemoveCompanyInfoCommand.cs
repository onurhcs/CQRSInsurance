namespace CQRSInsurance.CQRSDesignPattern.Command.CompanyInfoCommands
{
    public class RemoveCompanyInfoCommand
    {
        public RemoveCompanyInfoCommand(int companyInfoId)
        {
            CompanyInfoId = companyInfoId;
        }

        public int CompanyInfoId { get; set; }
    }
}
