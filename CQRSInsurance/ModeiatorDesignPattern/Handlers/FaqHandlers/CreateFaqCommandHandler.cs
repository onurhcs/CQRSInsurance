using CQRSInsurance.Context;
using CQRSInsurance.Entities;
using CQRSInsurance.ModeiatorDesignPattern.Commands.FaqCommand;
using MediatR;

namespace CQRSInsurance.ModeiatorDesignPattern.Handlers.FaqHandlers
{
    public class CreateFaqCommandHandler : IRequestHandler<CreateFaqCommand>
    {
        private readonly CQRSContext _context;
        public CreateFaqCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateFaqCommand request, CancellationToken cancellationToken)
        {
            _context.Faqs.Add(new Faq
            {
                Question = request.Question,
                Answer = request.Answer,
                Icon = request.Icon,
                IsActive = request.IsActive
            });
            await _context.SaveChangesAsync();
        }
    }
}
