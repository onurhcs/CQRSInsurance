using CQRSInsurance.Context;
using CQRSInsurance.ModeiatorDesignPattern.Commands.MessageCommand;
using MediatR;

namespace CQRSInsurance.ModeiatorDesignPattern.Handlers.MessageHandlers
{
    public class RemoveMessageCommandHandler : IRequestHandler<RemoveMessageCommand>
    {
        private readonly CQRSContext _context;
        public RemoveMessageCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public async Task Handle(RemoveMessageCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Messages.FindAsync(request.MessageId);
            _context.Messages.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
