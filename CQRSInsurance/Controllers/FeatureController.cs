using CQRSInsurance.CQRSDesignPattern.Command.FeatureCommands;
using CQRSInsurance.CQRSDesignPattern.Handlers.FeatureHandlers;
using CQRSInsurance.CQRSDesignPattern.Queries.FeatureQueries;
using Microsoft.AspNetCore.Mvc;

namespace CQRSInsurance.Controllers
{
    public class FeatureController : Controller
    {
        private readonly CreateFeatureCommandHandler _createFeatureCommandHandler;
        private readonly UpdateFeatureCommandHandler _updateFeatureCommandHandler;
        private readonly RemoveFeatureCommandHandler _removeFeatureCommandHandler;
        private readonly GetFeatureByIdQueryHandler _getFeatureByIdQueryHandler;
        private readonly GetFeatureQueryHandler _getFeatureQueryHandler;

        public FeatureController(CreateFeatureCommandHandler createFeatureCommandHandler,
            UpdateFeatureCommandHandler updateFeatureCommandHandler,
            RemoveFeatureCommandHandler removeFeatureCommandHandler,
            GetFeatureByIdQueryHandler getFeatureByIdQueryHandler,
            GetFeatureQueryHandler getFeatureQueryHandler)
        {
            _createFeatureCommandHandler = createFeatureCommandHandler;
            _updateFeatureCommandHandler = updateFeatureCommandHandler;
            _removeFeatureCommandHandler = removeFeatureCommandHandler;
            _getFeatureByIdQueryHandler = getFeatureByIdQueryHandler;
            _getFeatureQueryHandler = getFeatureQueryHandler;
        }

        public async Task<IActionResult> FeatureList()
        {
            var values = await _getFeatureQueryHandler.Handle();
            return View(values);
        }
        public IActionResult CreateFeature()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureCommand command)
        {
            await _createFeatureCommandHandler.Handle(command);
            return RedirectToAction("FeatureList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateFeature(int id)
        {
            var values = await _getFeatureByIdQueryHandler.Handle(new GetFeatureByIdQuery(id));
            return View(values);
        }

        public async Task<IActionResult> DeleteFeature(int id)
        {
            await _removeFeatureCommandHandler.Handle(new RemoveFeatureCommand(id));
            return RedirectToAction("FeatureList");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureCommand command)
        {
            await _updateFeatureCommandHandler.Handle(command);
            return RedirectToAction("FeatureList");
        }
    }
}
