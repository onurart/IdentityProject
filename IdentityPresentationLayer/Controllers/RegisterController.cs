using IdentityDtoLayer.Dtos.AppUserDtos;
using IdentityEntities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityPresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AppserRegisterDtos Dtos)
        {
            ; if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                { UserName = Dtos.UserName, Name = Dtos.Name, SurName = Dtos.SurName, Email = Dtos.Email };
                var result = await _userManager.CreateAsync(appUser, Dtos.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "ConfirMail");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("0", item.Description);
                    }
                }
            }
            return View();

        }
    }
}
