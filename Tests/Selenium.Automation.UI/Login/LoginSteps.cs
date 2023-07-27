using System;

using Automation.Common.Environment;

using Selenium.Automation.Model.Domain.Login;
using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Platform.Configuration.Environment;
using Selenium.Automation.Platform.Factory;

namespace Selenium.Automation.UI.Login
{
	public class LoginSteps : StepsBase, ILoginSteps
	{
		private readonly IWebDriver _webDriver;

		public LoginSteps(
			IWebDriver webDriver,
			IEnvironmentConfiguration environmentConfiguration)
			: base(webDriver, environmentConfiguration)
		{
			_webDriver = webDriver;
		}

		private LoginPage LoginPage => PageFactory.Get<LoginPage>(_webDriver);

		private MainPage MainPage => PageFactory.Get<MainPage>(_webDriver);

		public void SetEmail(string email)
		{
			LoginPage.EmailTextBox.SetText(email);
		}

		public void SetPassword(string password)
		{
			LoginPage.PasswordTextBox.SetText(password);
		}

		public void Login()
		{
			throw new NotImplementedException();
		}

		public void OpenLoginPage()
		{
			OpenMainView();
			MainPage.OpenLoginButton.Click();
		}
	}
}
