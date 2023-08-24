using System.Linq;

using OpenQA.Selenium.Support.PageObjects;

using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Platform.Page;
using Selenium.Automation.Platform.WebElements;

namespace Selenium.Automation.UI.Navigation
{
	public class NavigationPage : WebPage
	{
		public NavigationPage(
			IWebDriver webDriver) : base(webDriver)
		{
		}

		[FindBy(How.XPath, ".//rz-main-page-sidebar//li[.//a[contains(text(), 'Ноутбуки та комп’ютери')]]")]
		public HtmlLink NotebookAndPCLink { get; set; }

		public HtmlLink[] NavigationLinks =>
			FindAll<HtmlLink>(new Locator(How.XPath, ".//rz-main-page-sidebar//a[contains(@class, 'menu-categories__link')]"))
			.ToArray();

		[FindBy(How.XPath, ".//h1")]
		public HtmlLabel Header { get; set; }

		public HtmlLink GetHtmlLink(string text) =>
			Find<HtmlLink>(new Locator(How.XPath, $".//rz-main-page-sidebar//li[.//a[contains(text(), '{text}')]]/a"));
	}
}
