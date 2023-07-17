using System;
using System.Collections.Generic;
using System.Linq;

using Selenium.Automation.Model.Domain.Navigation;
using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Platform.Configuration.Environment;
using Selenium.Automation.Platform.Factory;
using Selenium.Automation.Platform.Waiter;

namespace Selenium.Automation.UI.Navigation
{
	public class NavigationSteps : StepsBase, INavigationSteps
	{
		private IWebDriver _webDriver;

		public NavigationSteps(
			IWebDriver webDriver, 
			IEnvironmentConfiguration environmentConfiguration) 
			: base(webDriver, environmentConfiguration)
		{
			_webDriver = webDriver;
		}

		private NavigationPage NavigationPage => PageFactory.Get<NavigationPage>(_webDriver);

		public void Open(string linkText)
		{
			// Get link by text
			var htmlLink = NavigationPage.GetHtmlLink(linkText);
			WaitFor.Condition(() => htmlLink.GetDisplayed(),
				$"The link with {linkText} was not found.",
				TimeSpan.FromSeconds(5));
			htmlLink.Click();

			// Get list of links
			List<Platform.WebElements.HtmlLink> htmlLinks = NavigationPage.NavigationLinks.ToList();
			IEnumerable<Platform.WebElements.HtmlLink> hl = htmlLinks.Where(i => i.GetText() == linkText);
			hl.Single().Click();

			// Get concrete link
			var notebookAndPCLink = NavigationPage.NotebookAndPCLink;
			notebookAndPCLink.Click();
		}
	}
}
