using System;
using System.Collections.Generic;
using System.Linq;

using Selenium.Automation.Model.Domain.Header;
using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Platform.Factory;
using Selenium.Automation.Platform.Waiter;
using Selenium.Automation.Platform.WebElements;
using Selenium.Automation.UI.Header;
using Selenium.Automation.UI.Slider;

namespace Selenium.Automation.UI.Header
{
    public class HeaderSteps : IHeaderSteps
    {
        private readonly IWebDriver _webDriver;

        public HeaderSteps(
            IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private HeaderPage HeaderPage => PageFactory.Get<HeaderPage>(_webDriver);

        public bool IsLanguageUA() =>
            HeaderPage.GetLanguageLink.GetText().Equals("RU");

                  
            public void ChangeLanguageUA()
            {
                if (!IsLanguageUA())
                       HeaderPage.GetLanguageLink.Click();
                       
         
            }
          

        }
    }
