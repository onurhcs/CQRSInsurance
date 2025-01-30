using CQRSInsurance.CQRSDesignPattern.Command.ServiceCommands;
using CQRSInsurance.CQRSDesignPattern.Handlers.ServiceHandlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRSInsurance.Controllers
{
    public class ServiceController : Controller
    {
        private readonly CreateServiceCommandHandler _createServiceCommandHandler;
        private readonly UpdateServiceCommandHandler _updateServiceCommandHandler;
        private readonly RemoveServiceCommandHandler _removeServiceCommandHandler;
        private readonly GetServiceByIdQueryHandler _getServiceByIdQueryHandler;
        private readonly GetServiceQueryHandler _getServiceQueryHandler;

        public ServiceController(CreateServiceCommandHandler createServiceCommandHandler,
            UpdateServiceCommandHandler updateServiceCommandHandler,
            RemoveServiceCommandHandler removeServiceCommandHandler,
            GetServiceByIdQueryHandler getServiceByIdQueryHandler,
            GetServiceQueryHandler getServiceQueryHandler)
        {
            _createServiceCommandHandler = createServiceCommandHandler;
            _updateServiceCommandHandler = updateServiceCommandHandler;
            _removeServiceCommandHandler = removeServiceCommandHandler;
            _getServiceByIdQueryHandler = getServiceByIdQueryHandler;
            _getServiceQueryHandler = getServiceQueryHandler;
        }

        public async Task<IActionResult> ServiceList()
        {
            var values = await _getServiceQueryHandler.Handle();
            return View(values);
        }
        public IActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceCommand command)
        {
            await _createServiceCommandHandler.Handle(command);
            return RedirectToAction("ServiceList");
        }

      

        public async Task<IActionResult> DeleteService(int id)
        {
            await _removeServiceCommandHandler.Handle(new RemoveServiceCommand(id));
            return RedirectToAction("ServiceList");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateService(UpdateServiceCommand command)
        {
            await _updateServiceCommandHandler.Handle(command);
            return RedirectToAction("ServiceList");
        }
    }
}
