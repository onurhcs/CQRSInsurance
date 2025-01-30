namespace CQRSInsurance.CQRSDesignPattern.Queries.TestimonialQueries
{
    public class GetTestimonialByIdQuery
    {
        public GetTestimonialByIdQuery(int testimonialId)
        {
            TestimonialId = testimonialId;
        }

        public int TestimonialId { get; set; }
    }
}
