using Automation.Common.Environment;

using Selenium.Automation.Model.Domain.Filter;
using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Platform.Factory;

using System.Collections.Generic;

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
