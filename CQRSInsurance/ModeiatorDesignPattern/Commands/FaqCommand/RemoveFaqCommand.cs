using MediatR;

namespace CQRSInsurance.ModeiatorDesignPattern.Commands.FaqCommand
{
    public class RemoveFaqCommand : IRequest
    {
        public RemoveFaqCommand(int FaqId)
        {
            FaqId = FaqId;
        }

        public int FaqId { get; set; }
    }
}
