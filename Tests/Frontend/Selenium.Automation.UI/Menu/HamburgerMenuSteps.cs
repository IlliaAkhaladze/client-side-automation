using System;
using Automation.Common.Environment;
using Selenium.Automation.Model.Domain.HamburgerMenu;
using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Platform.Factory;
using Selenium.Automation.Platform.Waiter;

namespace Selenium.Automation.UI.Menu
{
    public class HamburgerMenuSteps : StepsBase, IHamburgerMenuSteps
    {
        private IWebDriver _webDriver;
        private HamburgerMenuPage HamburgerMenuPage => PageFactory.Get<HamburgerMenuPage>(_webDriver);

        public HamburgerMenuSteps(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
            : base(webDriver, environmentConfiguration)
        {
            _webDriver = webDriver;
        }

        public void OpenMenu()
        {
            HamburgerMenuPage.HamburgerButton.Click();
            try
            {
                WaitFor.Condition(() =>
                HamburgerMenuPage.HamburgerMenuFrame.GetDisplayed(),
                "Menu was not opened on time",
                TimeSpan.FromSeconds(5));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"thrown an exception {ex}");
            }
        }

        public bool IsMenuDisplayed()
        {
            var value = HamburgerMenuPage.HamburgerMenuFrame.GetDisplayed();
            return value;
        }
    }
}
