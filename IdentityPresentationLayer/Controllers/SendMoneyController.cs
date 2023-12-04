using IdentityDataAccesLayer.Concrete;
using IdentityDtoLayer.Dtos.CustomerAccountProcessDtos;
using IdentityEntities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityPresentationLayer.Controllers
{
	public class SendMoneyController : Controller
	{
		private UserManager<AppUser> _userManager;

		public SendMoneyController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public IActionResult Index()
		{
			return View();
		}

		public async Task<IActionResult> Index(SendMoneyForCustomerAccountProcssDto procssDto)
		{
			var context = new Context();
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			//var receverAccountAccountNumber = context.CustomerAccount.Where(x => x.CustomerAccountNumber == procssDto.ReceiverAccountNumber).Select(x => x.CustomerAccountID).FirstOrDefau();
			procssDto.SenderID = user.Id;
			procssDto.ProcessDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			procssDto.ProcessType = "Havale";
			//procssDto.ReceiverId = receverAccountAccountNumber;


			return RedirectToAction("Index","deneme");
		}
	}
}
