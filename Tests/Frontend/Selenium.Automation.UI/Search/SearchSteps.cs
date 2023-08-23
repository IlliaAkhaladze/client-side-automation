using Selenium.Automation.Model.Domain.Search;
using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Platform.Factory;

namespace Selenium.Automation.UI.Search
{
	public class SearchSteps : ISearchSteps
	{
		private readonly IWebDriver _webDriver;

		public SearchSteps(
			IWebDriver webDriver)
		{
			_webDriver = webDriver;
		}

		private MainPage MainPage => PageFactory.Get<MainPage>(_webDriver);

		private SearchElement SearchElement => PageFactory.Get<MainPage>(_webDriver).HeaderSection.SearchElement;

		public void SetValue(string value)
		{
			SearchElement.SetValue(value);
		}

		public void Search()
		{
			SearchElement.Search();
		}

		public void Search(string value)
		{
			SearchElement.Search(value);
		}

		public void Close()
		{
			MainPage.DocSection.CloseButton.GetDisplayed();
			_webDriver.Close();
		}
	}
}
