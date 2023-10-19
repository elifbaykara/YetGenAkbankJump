using Lecture_4_2.Utilities;
using Microsoft.AspNetCore.Mvc;
using YetGenAkbankJump.MvcClient.Models;

namespace YetGenAkbankJump.MvcClient.Controllers
{
    public class PasswordsController : Controller
    {
        private readonly PasswordGenerator _passwordGenerator;

        public PasswordsController()
        {
            _passwordGenerator = new PasswordGenerator();
        }

        public IActionResult Index() //sayfya ilk kez girdiğimde bu çalışacak httpget
        {
            var IndexViewModel = new PasswordsIndexViewModel();
            IndexViewModel.Password = _passwordGenerator.Generate(15, true, true, true, false);

            return View(IndexViewModel);
        }
        [HttpPost]
        public IActionResult Index(int passwordLength) //sayfadan input gönderirken yani butona basınca bu çalışacak httppost
        {
            var IndexViewModel = new PasswordsIndexViewModel();
            IndexViewModel.Password = _passwordGenerator.Generate(15, true, true, true, false);

            return View(IndexViewModel);
        }
    }
}
