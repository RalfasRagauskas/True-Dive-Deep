using Microsoft.AspNetCore.Mvc;

namespace True_Dive_Deep.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public class ContactFormModel
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Phonenumber { get; set; }
            public string Country { get; set; }
            public string Subject { get; set; } 
        }
        [HttpPost]
        public IActionResult SendMessage(ContactFormModel model)
        {
           
            if (string.IsNullOrWhiteSpace(model.Firstname) || string.IsNullOrWhiteSpace(model.Subject))
            {
                
                return BadRequest();
            }

            // 2. GEM ELLER SEND BESKEDEN HER
             // _emailService.SendContactEmail(model); 
            // _db.ContactMessages.Add(model);
            // _db.SaveChanges();
      
            return Ok(); 
        }
    }


}

