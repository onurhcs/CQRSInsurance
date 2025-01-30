using MediatR;

namespace CQRSInsurance.ModeiatorDesignPattern.Commands.FaqCommand
{
    public class CreateFaqCommand : IRequest
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Icon { get; set; }
        public bool IsActive { get; set; }
    }
}
