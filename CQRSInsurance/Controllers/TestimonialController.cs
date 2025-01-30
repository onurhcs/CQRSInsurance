using CQRSInsurance.CQRSDesignPattern.Command.TestimonialCommands;
using CQRSInsurance.CQRSDesignPattern.Handlers.TestimonialHandlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRSInsurance.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly CreateTestimonialCommandHandler _createTestimonialCommandHandler;
        private readonly UpdateTestimonialCommandHandler _updateTestimonialCommandHandler;
        private readonly RemoveTestimonialCommandHandler _removeTestimonialCommandHandler;
        private readonly GetTestimonialByIdQueryHandler _getTestimonialByIdQueryHandler;
        private readonly GetTestimonialQueryHandler _getTestimonialQueryHandler;

        public TestimonialController(CreateTestimonialCommandHandler createTestimonialCommandHandler,
            UpdateTestimonialCommandHandler updateTestimonialCommandHandler,
            RemoveTestimonialCommandHandler removeTestimonialCommandHandler,
            GetTestimonialByIdQueryHandler getTestimonialByIdQueryHandler,
            GetTestimonialQueryHandler getTestimonialQueryHandler)
        {
            _createTestimonialCommandHandler = createTestimonialCommandHandler;
            _updateTestimonialCommandHandler = updateTestimonialCommandHandler;
            _removeTestimonialCommandHandler = removeTestimonialCommandHandler;
            _getTestimonialByIdQueryHandler = getTestimonialByIdQueryHandler;
            _getTestimonialQueryHandler = getTestimonialQueryHandler;
        }

        public async Task<IActionResult> TestimonialList()
        {
            var values = await _getTestimonialQueryHandler.Handle();
            return View(values);
        }
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommand command)
        {
            await _createTestimonialCommandHandler.Handle(command);
            return RedirectToAction("TestimonialList");
        }


        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            await _removeTestimonialCommandHandler.Handle(new RemoveTestimonialCommand(id));
            return RedirectToAction("TestimonialList");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialCommand command)
        {
            await _updateTestimonialCommandHandler.Handle(command);
            return RedirectToAction("TestimonialList");
        }
    }
}
