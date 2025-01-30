using CQRSInsurance.ModeiatorDesignPattern.Commands.FaqCommand;
using CQRSInsurance.ModeiatorDesignPattern.Queries.FaqQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSInsurance.Controllers
{
    public class FaqController : Controller
    {
        private readonly IMediator _mediator;

        public FaqController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> FaqList()
        {
            var values = await _mediator.Send(new GetFaqQuery());
            return View(values);
        }

        public IActionResult CreateFaq()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFaq(CreateFaqCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("FaqList");
        }

        public async Task<IActionResult> DeleteFaq(int id)
        {
            await _mediator.Send(new RemoveFaqCommand(id));
            return RedirectToAction("FaqList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateFaq(int id)
        {
            var values = await _mediator.Send(new GetFaqByIdQuery(id));
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFaq(UpdateFaqCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("FaqList");
        }
    }
}
