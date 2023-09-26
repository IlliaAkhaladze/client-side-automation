
using System;
using System.Collections.Generic;
using System.Linq;

using Selenium.Automation.Model.Domain.HamburgerMenu;
using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Platform.Factory;
using Selenium.Automation.Platform.Waiter;
using Selenium.Automation.Platform.WebElements;
using Selenium.Automation.UI.Navigation;

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
               
        public void ChangeCityButton()
        {
            HamburgerMenuPage.ChangeCityButton.Click();
        }

        public void SetCityName (string cityName)
        {
            HamburgerMenuPage.CityNameLink(cityName).Click();
        }
        public void AcceptButton ()
        {
            HamburgerMenuPage.AcceptButton.Click();
        }
    }
}
