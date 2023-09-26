using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Platform.Page;
using Selenium.Automation.Platform.WebElements;
using System.Linq;

namespace Selenium.Automation.UI.Slider
{
	internal class SliderPage : WebPage
	{
		public SliderPage(IWebDriver webDriver) : base(webDriver)
		{
		}

		[FindBy(How.XPath, "//button[contains(@class, 'next')]")]
		public HtmlButton Next { get; set; }

		public HtmlLink[] PostsElements =>
			FindAll<HtmlLink>(new Locator(How.XPath, "//app-slider//li//a"))
			.ToArray();
	}
}