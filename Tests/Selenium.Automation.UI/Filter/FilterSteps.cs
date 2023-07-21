using Selenium.Automation.Model.Domain.Filter;
using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Platform.Configuration.Environment;
using Selenium.Automation.Platform.Driver;
using Selenium.Automation.Platform.Factory;
using Selenium.Automation.UI.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium.Automation.UI.Filter
{
    public class FilterSteps : StepsBase, IFilterSteps
    {
        private IWebDriver _webDriver;

        public FilterSteps(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
            : base(webDriver, environmentConfiguration)
        {
            _webDriver = webDriver;
        }
        private FilterPage FilterPage => PageFactory.Get<FilterPage>(_webDriver);

        
        public string[] GetFilters(string category)
        {
           var filters = FilterPage.GetFilterCheckBoxes(category);
            var filterList = new List<string>();
            foreach (var filter in filters)
            {
                filterList.Add(filter.GetText());
            }
            return filterList.ToArray();
        }
    }
}
