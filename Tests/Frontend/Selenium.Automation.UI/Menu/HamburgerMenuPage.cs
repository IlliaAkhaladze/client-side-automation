using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Platform.Element;
using Selenium.Automation.Platform.Page;
using Selenium.Automation.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

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


        [FindBy(OpenQA.Selenium.Support.PageObjects.How.XPath, ".//span[contains(@class, 'city-toggle__text')]")]
        public HtmlElement CityName { get; set; }

        [FindBy(How.XPath, ".//button[contains(@class, 'city-toggle')]")]
        public HtmlButton ChangeCityButton { get; set; }

        
        public HtmlLink CityNameLink (string cityName) =>
            Find<HtmlLink>(new Locator (How.XPath, $"//a[contains(text(),'{cityName}')]"));

        [FindBy(How.XPath, ".//div[contains(@class, 'header-location__footer')]//button")]
        public HtmlButton AcceptButton { get; set; }

    }
}
