namespace CQRSInsurance.CQRSDesignPattern.Command.TestimonialCommands
{
    public class RemoveTestimonialCommand
    {
        public RemoveTestimonialCommand(int testimonialId)
        {
            TestimonialId = testimonialId;
        }

        public int TestimonialId { get; set; }
    }
}
