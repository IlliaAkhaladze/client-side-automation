using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Platform.Element;
using Selenium.Automation.Platform.Page;
using Selenium.Automation.Platform.WebElements;
using Selenium.Automation.Platform.WebElements.CheckBox;
using System.Collections.Generic;
using System.Linq;

namespace Selenium.Automation.UI.Filter
{
    public class FilterPage : WebPage
    {
        public FilterPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        private HtmlElement GetFilterByCat(string category)
        {
            string locator = $".//div[@data-filter-name='{category}']";
            HtmlElement element = Find<HtmlElement>(new Locator(How.XPath, locator));
            return element;
        }

        public FilterCheckBox[] GetFilterCheckBoxes(string name)
        {
            var filterCheckBoxes = GetFilterByCat(name).FindAll<FilterCheckBox>(new Locator(How.XPath, ".//li"));

            return filterCheckBoxes.ToArray();
        }

        public HtmlLink[] FilterCategories =>
            this.FindAll<HtmlLink>(new Locator(How.XPath, ".//rz-filter-stack//div[contains (@class, 'sidebar-block__toggle-title')]"))
            .ToArray();

        public object Url => "ua/consoles/c80020/";

        public string[] FilterCategoriesLists()
        {
            List<string> filterCatList = new List<string>();
            foreach (HtmlLink element in FilterCategories)
            {
                filterCatList.Add(element.ToString());

            }
            return filterCatList.ToArray();
        }

        public HtmlElement SelectedFiltersView =>
        Find<HtmlElement>(new Locator(How.XPath, ".//rz-selected-filters"));

        public HtmlLink[] CatalogSelectedItem =>
            this.FindAll<HtmlLink>(new Locator(How.XPath, ".//rz-catalog-settings//li[a]"))
            .ToArray();
    }
}
