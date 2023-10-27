using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Platform.Element;
using Selenium.Automation.Platform.Page;
using Selenium.Automation.Platform.WebElements;

using SeleniumExtras.PageObjects;

namespace Selenium.Automation.UI.Menu
{
	public class HamburgerMenuPage : WebPage
    {
        public HamburgerMenuPage(
            IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindBy(How.XPath, ".//rz-mobile-user-menu/button")]
        public HtmlButton HamburgerButton { get; set; }

        [FindBy(How.XPath, ".//div[contains(@class, 'side-menu__body')]")]
        public HtmlElement HamburgerMenuFrame { get; set; }

        [FindBy(How.XPath, ".//span[contains(@class, 'city-toggle__text')]")]
        public HtmlElement CityName { get; set; }

        [FindBy(How.XPath, ".//button[contains(@class, 'city-toggle')]")]
        public HtmlButton ChangeCityButton { get; set; }

        public HtmlLink GetCityNameLink(string cityName) =>
            Find<HtmlLink>(new Locator(How.XPath, "//ul[contains(@class, 'header-location__popular')]//li[last()]"));

        [FindBy(How.XPath, ".//div[contains(@class, 'header-location__footer')]//button")]
        public HtmlButton AcceptButton { get; set; }

    }
}