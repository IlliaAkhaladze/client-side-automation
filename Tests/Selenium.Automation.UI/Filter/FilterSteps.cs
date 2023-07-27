using Selenium.Automation.Model.Domain.Filter;
using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Platform.Configuration.Environment;
using Selenium.Automation.Platform.Factory;
using Selenium.Automation.Platform.WebElements.CheckBox;
using System.Collections.Generic;

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

        public string SetSubFilter(bool value, string subcategory)
        {
            FilterCheckBox subFilter = new FilterCheckBox();
            subFilter.SetFilter(value,subcategory);
            return subFilter.ToString();            
        }

        public string[] GetSelectedFilters(string linkText)
        {  
           var filterSelected = FilterPage.GetFilterSelectedItem(linkText);
           var filterCatItemList = new List<string>();
            foreach ( var selectedItems in filterSelected)
            {
                var value = selectedItems.GetText();
                filterCatItemList.Add(value);
            }
            return filterCatItemList.ToArray();
        }

    }
}
