using IdentityDtoLayer.Dtos.AppRoleDtos;
using IdentityEntities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityPresentationLayer.Controllers
{
	public class UserProfileController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public UserProfileController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			AppUserEditDto appUser = new AppUserEditDto();
			appUser.Name = values.Name;
			appUser.SurName = values.SurName;
			appUser.PhoneNumber = values.PhoneNumber;
			appUser.Email = values.Email;
			appUser.City = values.City;
			appUser.District = values.Disrtict;
			appUser.ImageUrl = values.ImagesUrl;
			return View(appUser);
		}
		[HttpPost]
		public async Task<IActionResult> Index(AppUserEditDto appUserx)
		{
			if (appUserx.Password==appUserx.ConfirmPasswod)
			{

			}
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			AppUserEditDto appUser = new AppUserEditDto();
			appUserx.Name = values.Name;
			appUserx.SurName = values.SurName;
			appUserx.PhoneNumber = values.PhoneNumber;
			appUserx.Email = values.Email;
			appUserx.City = values.City;
			appUserx.District = values.Disrtict;
			appUserx.ImageUrl = values.ImagesUrl;
			return View(appUser);
		}
	}
}
