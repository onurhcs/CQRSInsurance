using CQRSInsurance.Context;
using CQRSInsurance.ModeiatorDesignPattern.Commands.FaqCommand;
using MediatR;

namespace CQRSInsurance.ModeiatorDesignPattern.Handlers.FaqHandlers
{
    public class UpdateFaqCommandHandler : IRequestHandler<UpdateFaqCommand>
    {
        CQRSContext _context = new CQRSContext();

        public UpdateFaqCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateFaqCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Faqs.FindAsync(request.FaqId);
            value.Question = request.Question;
            value.Answer = request.Answer;
            value.Icon = request.Icon;
            value.IsActive = request.IsActive;
            await _context.SaveChangesAsync();
        }
    }
}
