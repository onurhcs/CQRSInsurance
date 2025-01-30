using CQRSInsurance.Context;
using CQRSInsurance.ModeiatorDesignPattern.Commands.MessageCommand;
using MediatR;

namespace CQRSInsurance.ModeiatorDesignPattern.Handlers.MessageHandlers
{
    public class UpdateMessageCommandHandler : IRequestHandler<UpdateMessageCommand>
    {
        private readonly CQRSContext _context;
        public UpdateMessageCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateMessageCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Messages.FindAsync(request.MessageId);
            value.Name = request.Name;
            value.Email = request.Email;
            value.Phone = request.Phone;
            value.Project = request.Project;
            value.Subject = request.Subject;
            value.MessageText = request.MessageText;
            await _context.SaveChangesAsync();
        }
    }
}
