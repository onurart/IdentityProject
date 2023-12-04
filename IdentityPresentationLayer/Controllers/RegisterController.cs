using IdentityBussines.Abstract;
using IdentityDataAccesLayer.Abstract;
using IdentityDtoLayer.Dtos.AppUserDtos;
using IdentityEntities.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using MimeKit;

namespace IdentityPresentationLayer.Controllers
{
	public class RegisterController : Controller
	{
		private readonly UserManager<AppUser> _userManager;
		public readonly ICustomerAccountProcessService _service;
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
			if (ModelState.IsValid)
			{
				Random random = new Random();
				int code = random.Next(1000, 100000);

				AppUser appUser = new AppUser()
				{ UserName = Dtos.UserName, Name = Dtos.Name, SurName = Dtos.SurName, Email = Dtos.Email, ConfirmCode = code };
				var result = await _userManager.CreateAsync(appUser, Dtos.Password);
				if (result.Succeeded)
				{
					MimeMessage mimeMessage = new MimeMessage();
					MailboxAddress mailboxAddressFrom = new MailboxAddress("", "onurumutluoglu@gmail.com");
					MailboxAddress mailboxAddressTo = new MailboxAddress("USer", appUser.Email);
					mimeMessage.From.Add(mailboxAddressFrom);
					mimeMessage.To.Add(mailboxAddressTo);
					var bodybuilder = new BodyBuilder();
					bodybuilder.TextBody = "" + code;
					mimeMessage.Body=bodybuilder.ToMessageBody();
					mimeMessage.Subject = "";
					SmtpClient smtpClient = new SmtpClient();
					smtpClient.Connect("smtp.gmail.com", 587, false);
					smtpClient.Authenticate("onurumutluoglu@gmail.com","");
					smtpClient.Send(mimeMessage);
					smtpClient.Disconnect(true);


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
