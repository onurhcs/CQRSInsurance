namespace CQRSInsurance.CQRSDesignPattern.Command.TestimonialCommands
{
    public class CreateTestimonialCommand
    {
        public string CustomerName { get; set; }
        public string JobTitle { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
    }
}
