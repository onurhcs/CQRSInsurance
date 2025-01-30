namespace CQRSInsurance.CQRSDesignPattern.Command.ServiceCommands
{
    public class RemoveServiceCommand
    {
        public RemoveServiceCommand(int serviceId)
        {
            ServiceId = serviceId;
        }

        public int ServiceId { get; set; }
    }
}
