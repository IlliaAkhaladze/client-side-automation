using OpenQA.Selenium.Support.PageObjects;

using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Platform.Element;

namespace Selenium.Automation.Platform.WebElements.Dropdowns
{
	public class SelectOption : HtmlElement
	{
		[FindBy(How.XPath, ".//span")]
		public HtmlLabel Name { get; set; }
	}
}
