using System.Linq;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Model.Platform.Element;
using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Platform.Element;
using Selenium.Automation.Platform.Page;
using Selenium.Automation.Platform.WebElements;

namespace Selenium.Automation.UI.Header
{
    internal class HeaderPage : WebPage
    { 
      public HeaderPage(IWebDriver webDriver) : base(webDriver)
    {
    }

    [FindBy(How.XPath, "//a[contains(@class, 'lang__link')]")]
        public HtmlLink LanguageLink { get; set; }
    }
}
