using CQRSInsurance.Context;
using CQRSInsurance.ModeiatorDesignPattern.Commands.FaqCommand;
using MediatR;

namespace CQRSInsurance.ModeiatorDesignPattern.Handlers.FaqHandlers
{
    public class RemoveFaqCommandHandler : IRequestHandler<RemoveFaqCommand>
    {
        private readonly CQRSContext _context;
        public RemoveFaqCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public async Task Handle(RemoveFaqCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Faqs.FindAsync(request.FaqId);
            _context.Faqs.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
