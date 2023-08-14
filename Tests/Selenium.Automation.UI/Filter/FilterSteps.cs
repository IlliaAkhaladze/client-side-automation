using Automation.Common.Environment;

using Selenium.Automation.Model.Domain.Filter;
using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Platform.Factory;

using System.Collections.Generic;
using System.Linq;

namespace Selenium.Automation.UI.Filter
{
	public class FilterSteps : StepsBase, IFilterSteps
    {
        private IWebDriver _webDriver;
        private IEnvironmentConfiguration _environmentConfiguration;

        public FilterSteps(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
            : base(webDriver, environmentConfiguration)
        {
            _webDriver = webDriver;
            _environmentConfiguration = environmentConfiguration;
        }
        private FilterPage FilterPage => PageFactory.Get<FilterPage>(_webDriver);

        
        public string[] GetFilters(string category)
        {
           var filters = FilterPage.GetFilterCheckBoxes(category);
            var filterList = new List<string>();
            foreach (var filter in filters)
            {
                var value = filter.GetText().Split("(")[0];
                filterList.Add(value.Trim());
            }
            return filterList.ToArray();
        }

        public void OpenCategory()
        {
            var fullUri = $"{_environmentConfiguration.EnvironmentUri}/{FilterPage.Url}";
            _webDriver.Get(fullUri);
        }

        public void SetSubFilter(bool value, string category, string filterName)
        {
            var subFilters = FilterPage.GetFilterCheckBoxes(category);
            var filter = subFilters.Single(i => i.GetText().Contains(filterName));
            filter.SetFilter(value, filterName);           
        }

        public string[] GetSelectedFilters()
        {
            var filterSelected = FilterPage.CatalogSelectedItem;
            var returnedValue = filterSelected.Select(i => i.GetText()).ToArray();
            return returnedValue;
        }

    }
}
