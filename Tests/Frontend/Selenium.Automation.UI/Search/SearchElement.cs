using OpenQA.Selenium.Support.PageObjects;

using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Platform.Element;
using Selenium.Automation.Platform.WebElements;

namespace Selenium.Automation.UI.Search
{
	public class SearchElement : HtmlElement, ISearchElement
	{
		[FindBy(How.XPath, ".//input[@name='search']")]
		private HtmlTextBox SearchHtmlTextBox { get; set; }

		[FindBy(How.XPath, ".//button[contains(@class, 'search-form__submit')]")]
		private HtmlButton SearchButton { get; set; }

		public void SetValue(string value)
		{
			SearchHtmlTextBox.SetText(value);
		}

		public void Search()
		{
			SearchButton.Click();
		}

		public void Search(string value)
		{
			SetValue(value);
			Search();
		}
	}
}
