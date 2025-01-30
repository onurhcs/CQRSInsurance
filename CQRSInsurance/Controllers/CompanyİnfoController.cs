using CQRSInsurance.CQRSDesignPattern.Command.CompanyInfoCommands;
using CQRSInsurance.CQRSDesignPattern.Handlers.CompanyInfoHandlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRSInsurance.Controllers
{
    public class CompanyİnfoController : Controller
    {
        private readonly CreateCompanyInfoCommandHandler _createCompanyInfoCommandHandler;
        private readonly UpdateCompnayInfoCommandHandler _updateCompanyInfoCommandHandler;
        private readonly RemoveCompanyInfoCommandHandler _removeCompanyInfoCommandHandler;
        private readonly GetCompanyInfoByIdQueryHandler _getCompanyInfoByIdQueryHandler;
        private readonly GetCompanyInfoQueryHandler _getCompanyInfoQueryHandler;

        public CompanyİnfoController(CreateCompanyInfoCommandHandler createCompanyInfoCommandHandler,
            UpdateCompnayInfoCommandHandler updateCompanyInfoCommandHandler,
            RemoveCompanyInfoCommandHandler removeCompanyInfoCommandHandler,
            GetCompanyInfoByIdQueryHandler getCompanyInfoByIdQueryHandler,
            GetCompanyInfoQueryHandler getCompanyInfoQueryHandler)
        {
            _createCompanyInfoCommandHandler = createCompanyInfoCommandHandler;
            _updateCompanyInfoCommandHandler = updateCompanyInfoCommandHandler;
            _removeCompanyInfoCommandHandler = removeCompanyInfoCommandHandler;
            _getCompanyInfoByIdQueryHandler = getCompanyInfoByIdQueryHandler;
            _getCompanyInfoQueryHandler = getCompanyInfoQueryHandler;
        }

        public async Task<IActionResult> CompanyInfoList()
        {
            var values = await _getCompanyInfoQueryHandler.Handle();
            return View(values);
        }

        public IActionResult CreateCompanyInfo()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompanyInfo(CreateComponyInfoCommand command)
        {
            if (ModelState.IsValid)
            {
                await _createCompanyInfoCommandHandler.Handle(command);
                return RedirectToAction("CompanyInfoList");
            }
            return View(command);
        }

        //[HttpGet]
        //public async Task<IActionResult> UpdateCompanyInfo(int id)
        //{
        //    var values = await _getCompanyInfoByIdQueryHandler.Handle(new GetCompayİnfoByIdQuery(id));
        //    return View(values);
        //}

        [HttpPost]
        public async Task<IActionResult> UpdateCompanyInfo(UpdateCompanyInfoCommand command)
        {
            if (ModelState.IsValid)
            {
                await _updateCompanyInfoCommandHandler.Handle(command);
                return RedirectToAction("CompanyInfoList");
            }
            return View(command);
        }

        public async Task<IActionResult> DeleteCompanyInfo(int id)
        {
            await _removeCompanyInfoCommandHandler.Handle(new RemoveCompanyInfoCommand(id));
            return RedirectToAction("CompanyInfoList");
        }
    }
}
