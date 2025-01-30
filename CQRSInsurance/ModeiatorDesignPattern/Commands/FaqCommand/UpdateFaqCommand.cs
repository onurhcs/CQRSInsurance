using MediatR;

namespace CQRSInsurance.ModeiatorDesignPattern.Commands.FaqCommand
{
    public class UpdateFaqCommand : IRequest
    {
        public int FaqId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Icon { get; set; }
        public bool IsActive { get; set; }
    }
}
