using MediatR;

namespace CQRSInsurance.ModeiatorDesignPattern.Commands.MessageCommand
{
    public class RemoveMessageCommand : IRequest
    {
        public RemoveMessageCommand(int messageId)
        {
            MessageId = messageId;
        }

        public int MessageId { get; set; }
    }
}
