using System.Linq;

using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Platform.Page;
using Selenium.Automation.Platform.WebElements;

using SeleniumExtras.PageObjects;

namespace Selenium.Automation.UI.Login
{
	public class LoginPage : WebPage
	{
		public LoginPage(IWebDriver webDriver)
			: base(webDriver)
		{
		}

		[FindBy(How.XPath, ".//input[@id='auth_email']")]
		public HtmlTextBox EmailTextBox { get; set; }

		[FindBy(How.XPath, ".//input[@id='auth_pass']")]
		public HtmlTextBox PasswordTextBox { get; set; }

		public HtmlButton[] LoginButton =>
			FindAll<HtmlButton>(new Locator(How.XPath, string.Empty)).ToArray();
	}
}
