namespace CQRSInsurance.ModeiatorDesignPattern.Results.FaqResults
{
    public class GetFaqQueryResult
    {
        public int FaqId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Icon { get; set; }
        public bool IsActive { get; set; }
    }
}
