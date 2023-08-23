using OpenQA.Selenium.Support.PageObjects;

using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Platform.Element;
using Selenium.Automation.Platform.WebElements;

namespace Selenium.Automation.UI
{
	public class DocSection : HtmlElement
	{
		[FindBy(How.XPath, "")]
		public HtmlButton CloseButton { get; set; }
	}
}