using CQRSInsurance.ModeiatorDesignPattern.Commands.MessageCommand;
using CQRSInsurance.ModeiatorDesignPattern.Queries.MessageQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSInsurance.Controllers
{
    public class MessageAdmınController : Controller
    {
        private readonly IMediator _mediator;

        public MessageAdmınController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> MessageList()
        {
            var values = await _mediator.Send(new GetMessageQuery());
            return View(values);
        }

        public IActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(CreateMessageCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("MessageList");
        }

        public async Task<IActionResult> DeleteMessage(int id)
        {
            await _mediator.Send(new RemoveMessageCommand(id));
            return RedirectToAction("MessageList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateMessage(int id)
        {
            var values = await _mediator.Send(new GetMessageByIdQuery(id));
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateMessage(UpdateMessageCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("MessageList");
        }
    }
}
