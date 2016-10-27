//namespace LEARNING_MVC.ViewModels.Account
namespace ViewModels.Account
{
	public class RegisterViewModel : object
	{
		public RegisterViewModel() : base()
		{
		}

		public string Username { get; set; }

		public string Password { get; set; }

		public string ConfirmPassword { get; set; }

		public string EmailAddress { get; set; }

		public string ConfirmEmailAddress { get; set; }
	}
}
