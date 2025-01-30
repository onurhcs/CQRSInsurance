namespace CQRSInsurance.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string CustomerName { get; set; }
        public string JobTitle { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
    }
}
