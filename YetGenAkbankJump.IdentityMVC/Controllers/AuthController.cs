using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using YetGenAkbankJump.Domain.Identity;
using YetGenAkbankJump.IdentityMVC.ViewModel;

namespace YetGenAkbankJump.IdentityMVC.Controllers
{
    public class AuthController : Controller
    {

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IToastNotification _toastNotification;

        public AuthController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            var registerViewModel = new AuthRegisterViewModel(); 
            return View(registerViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> RegisterAsync(AuthRegisterViewModel registerViewModel)
        {
            if (!ModelState.IsValid)
                return View(registerViewModel);

            var userId = Guid.NewGuid();

            var user = new User()
            {
                Id = userId,
                Email = registerViewModel.Email,
                UserName = registerViewModel.UserName,
                FirstName = registerViewModel.FirstName,
                SurName = registerViewModel.SurName,
                Gender = registerViewModel.Gender,
                BirthDate = registerViewModel.BirthDate.Value.ToUniversalTime(),
                CreatedOn = DateTimeOffset.UtcNow,
                CreatedByUserId = userId.ToString(),
                
            };

            var identityResult = await _userManager.CreateAsync(user,registerViewModel.Password); 

            if(!identityResult.Succeeded)
                throw new Exception("Patladık");
            _toastNotification.AddSuccessToastMessage("You've successfully registered to the application");


            return RedirectToAction(nameof(Login));
        }

        [HttpGet]
        public IActionResult Login()
        {
            var loginViewModel = new AuthLoginViewModel();

            return View(loginViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> LoginAsync(AuthLoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
                return View(loginViewModel);

            var user = await _userManager.FindByEmailAsync(loginViewModel.Email);

            if (user is null)
            {
                _toastNotification.AddErrorToastMessage("Your email or password is incorrect.");

                return View(loginViewModel);
            }

            var loginResult = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password,true,false);

            if (!loginResult.Succeeded)
            {
                _toastNotification.AddErrorToastMessage("Your email or password is incorrect");

                return View(loginViewModel);
            }

            _toastNotification.AddSuccessToastMessage($"Welcome:{user}!");

            return RedirectToAction(nameof(Index),controllerName:"Students");
        }
    }
}
