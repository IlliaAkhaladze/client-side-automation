using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Platform.Page;
using Selenium.Automation.Platform.WebElements;

using SeleniumExtras.PageObjects;

namespace Selenium.Automation.UI.Header
{
	public class HeaderPage : WebPage
    {
        public HeaderPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindBy(How.XPath, "//a[contains(@class, 'lang__link')]")]
        public HtmlLink LanguageLink { get; set; }
    }
}