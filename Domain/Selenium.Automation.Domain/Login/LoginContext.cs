using Selenium.Automation.Model.Domain.Login;

namespace Selenium.Automation.Domain.Login
{
	public class LoginContext : ILoginContext
	{
		private readonly ILoginSteps _loginSteps;

		public LoginContext(
			ILoginSteps loginSteps)
		{
			_loginSteps = loginSteps;
		}

		public void OpenAndLogin(UserInformation user)
		{
			_loginSteps.OpenLoginPage();
			//_loginSteps.OpenLoginPage();
			Login(user);
		}

		private void Login(UserInformation user)
		{
			_loginSteps.SetEmail(user.Email);
			_loginSteps.SetPassword(user.Password);
			_loginSteps.Login();
		}
	}
}
