using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Platform.Element;
using Selenium.Automation.Platform.Page;
using Selenium.Automation.Platform.WebElements;

namespace Selenium.Automation.UI.Menu
{
    public class HamburgerMenuPage : WebPage
    {
        public HamburgerMenuPage(
            IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindBy(OpenQA.Selenium.Support.PageObjects.How.XPath, ".//rz-mobile-user-menu/button")]
        public HtmlButton HamburgerButton { get; set; }

        [FindBy(OpenQA.Selenium.Support.PageObjects.How.XPath, ".//div[contains(@class, 'side-menu__body')]")]
        public HtmlElement HamburgerMenuFrame { get; set; }


    }
}
