namespace CQRSInsurance.CQRSDesignPattern.Command.ServiceCommands
{
    public class UpdateServiceCommand
    {
        public int ServiceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string ButtonText { get; set; }
        public string ButtonLink { get; set; }
    }
}
