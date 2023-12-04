using IdentityEntities.Concrete;
using IdentityPresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityPresentationLayer.Controllers
{
	public class ConfirmMailController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public ConfirmMailController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}
		[HttpGet]
		public IActionResult Index()
		{
			var values = TempData["Mail"];
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Index(CofirmMailViewModel cofirmMailViewModel)
		{
			var values = TempData["Mail"];
			var user = await _userManager.FindByEmailAsync(cofirmMailViewModel.Mail);
			if (user.ConfirmCode==cofirmMailViewModel.ConfirmCode)
			{
				user.EmailConfirmed = true;
				await _userManager.UpdateAsync(user);
				return RedirectToAction("");
			}
			return View();
		}
	}
}
