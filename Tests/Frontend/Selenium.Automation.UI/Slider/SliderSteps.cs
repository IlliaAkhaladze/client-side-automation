using Selenium.Automation.Model.Domain.Slider;
using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Platform.Factory;
using Selenium.Automation.Platform.Waiter;
using Selenium.Automation.Platform.WebElements;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Selenium.Automation.UI.Slider
{
    public class SliderSteps : ISliderSteps
    {
        private readonly IWebDriver _webDriver;

        public SliderSteps(
            IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private SliderPage SliderPage => PageFactory.Get<SliderPage>(_webDriver);

        public int GetCountPost()
        {
            var returnedValue = SliderPage.PostsElements.Length;
            return returnedValue;
        }

        public string[] GetPostLinks()
        {
            WaitFor.Condition(() =>
            SliderPage.PostsElements.Length > 0,
            "The elements was not loaded on time.",
            TimeSpan.FromSeconds(30));
            List<HtmlLink> hrefs = SliderPage.PostsElements.ToList();
            List<string> values = new List<string>();

            foreach (var item in hrefs)
            {
                values.Add(item.GetLink());
            }

            return values.ToArray();
        }
    }
}