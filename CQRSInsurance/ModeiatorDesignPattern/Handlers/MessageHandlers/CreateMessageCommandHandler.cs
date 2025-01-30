using CQRSInsurance.Context;
using CQRSInsurance.Entities;
using CQRSInsurance.ModeiatorDesignPattern.Commands.MessageCommand;
using MediatR;

namespace CQRSInsurance.ModeiatorDesignPattern.Handlers.MessageHandlers
{
    public class CreateMessageCommandHandler : IRequestHandler<CreateMessageCommand>
    {
        private readonly CQRSContext _context;
        public CreateMessageCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateMessageCommand request, CancellationToken cancellationToken)
        {
            _context.Messages.Add(new Message
            {
                Name = request.Name,
                Email = request.Email,
                Phone = request.Phone,
                Project = request.Project,
                Subject = request.Subject,
                MessageText = request.MessageText,
            });
            await _context.SaveChangesAsync();
        }
    }
}
