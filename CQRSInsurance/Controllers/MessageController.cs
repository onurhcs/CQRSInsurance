using CQRSInsurance.Context;
using CQRSInsurance.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CQRSInsurance.Controllers
{
    public class MessageController : Controller
    {
        CQRSContext _context = new CQRSContext();

        public MessageController(CQRSContext context)
        {
            _context = context;
        }
        public IActionResult MessageSend()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(Message model)
        {
            if (ModelState.IsValid)
            {
                _context.Messages.Add(model);
                _context.SaveChanges();
                TempData["SuccessMessage"] = "Mesajınız başarıyla gönderildi!";
                return RedirectToAction("Index", "Default");
            }
            return View(model);
        }



    }
}
