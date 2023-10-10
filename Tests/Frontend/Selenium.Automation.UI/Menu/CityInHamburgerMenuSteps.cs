using Selenium.Automation.Model.Domain.HamburgerMenu;
using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Platform.Factory;

namespace Selenium.Automation.UI.Menu
{
    public class CityInHamburgerMenuSteps : ICityInHamburgerMenuSteps
    {
        private readonly IWebDriver _webDriver;

        public CityInHamburgerMenuSteps(
            IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private HamburgerMenuPage HamburgerMenuPage => PageFactory.Get<HamburgerMenuPage>(_webDriver);

        public string GetCityName()
        {
            var cityName = HamburgerMenuPage.CityName.GetText();
            return cityName;
        }

        public void ChangeCity()
        {
            HamburgerMenuPage.ChangeCityButton.Click();
        }

        public void SetCityName(string cityName)
        {
            HamburgerMenuPage.GetCityNameLink(cityName).Click();
        }
        public void Accept()
        {
            HamburgerMenuPage.AcceptButton.Click();
        }
    }
}