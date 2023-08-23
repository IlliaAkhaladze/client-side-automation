using OpenQA.Selenium.Support.PageObjects;
using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Platform.Element;
using Selenium.Automation.Platform.Page;
using Selenium.Automation.Platform.WebElements;
using Selenium.Automation.Platform.WebElements.CheckBox;
using System.Linq;

namespace Selenium.Automation.UI.Filter
{
    public class FilterPage : WebPage
    {
        public FilterPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public string Url => "ua/consoles/c80020/";
        public HtmlLink[] FilterCategories =>
            FindAll<HtmlLink>(new Locator(How.XPath, ".//rz-filter-stack//div[contains (@class, 'sidebar-block__toggle-title')]"))
             .ToArray();

        [FindBy(How.XPath, ".//rz-selected-filters")]
        public HtmlElement SelectedFiltersView { get; set; }

        public HtmlLink[] CatalogSelectedItem =>
            FindAll<HtmlLink>(new Locator(How.XPath, ".//rz-catalog-settings//li[a]"))
            .ToArray();
        
        public HtmlElement GetFilterByCat(string category) =>
            Find<HtmlElement>(new Locator(How.XPath, $".//div[@data-filter-name='{category}']"));
      
        public FilterCheckBox[] GetFilterCheckBoxes(string name)
        {
            var filterCheckBoxes = GetFilterByCat(name).FindAll<FilterCheckBox>(new Locator(How.XPath, ".//li"));
            return filterCheckBoxes.ToArray();
        }

    }
}