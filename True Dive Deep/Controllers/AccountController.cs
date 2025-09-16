using Microsoft.AspNetCore.Mvc;
using True_Dive_Deep.Persistence;

namespace True_Dive_Deep.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository _accountRepository;
        public IActionResult Index()
        {
            var accounts = AccountRepository.GetAll();
            return View(accounts);
        }
    }
}
