﻿using Selenium.Automation.Model.Platform.Locator;
using Selenium.Automation.Platform.Element;
using Selenium.Automation.UI.Search;

using SeleniumExtras.PageObjects;

namespace Selenium.Automation.UI
{
	public class HeaderSection : HtmlElement
	{
		[FindBy(How.XPath, ".//div[@class='header-search js-app-search-suggest']")]
		public SearchElement SearchElement { get; set; }
	}
}
