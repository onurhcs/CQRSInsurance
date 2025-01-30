namespace CQRSInsurance.CQRSDesignPattern.Command.FeatureCommands
{
    public class RemoveFeatureCommand
    {
        public RemoveFeatureCommand(int featureId)
        {
            FeatureId = featureId;
        }

        public int FeatureId { get; set; }
    }
}
