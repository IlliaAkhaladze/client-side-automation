using System.Linq;

using OpenQA.Selenium.Support.PageObjects;

using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Platform.Element;

namespace Selenium.Automation.Platform.WebElements.Dropdowns
{
	public class SelectBody : HtmlElement
	{
		public SelectOption[] SelectOptions =>
			FindAll<SelectOption>(new Locator(How.XPath, ".//et-select-body-option"))
				.ToArray();
	}
}
