using IdentityEntities.Concrete;
using IdentityEntities.Concrete.Identity.Auto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityPresentationLayer.Controllers
{
	public class LoginController : Controller
	{
		private readonly SignInManager<AppUser> _userManager;
		private readonly RoleManager<AppRole> _roleManager;

		public LoginController(SignInManager<AppUser> userManager, RoleManager<AppRole> roleManager)
		{
			_userManager = userManager;
			_roleManager = roleManager;
		}

		public IActionResult Index()
		{
			return View();
		}
		public async Task<IActionResult> Index(LoginViewModel loginViewModel)
		{
			var result = await _userManager.PasswordSignInAsync(loginViewModel.Email,
				loginViewModel.Password,false,true);
			if (result.Succeeded)
			{
				return RedirectToAction("Index", "Home");
			}
			return View();
		}
	}
}
