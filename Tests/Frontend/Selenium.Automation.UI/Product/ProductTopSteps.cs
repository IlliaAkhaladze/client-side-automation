using Automation.Common.Environment;

using Selenium.Automation.Model.Domain.Poduct;
using Selenium.Automation.Model.Platform.Drivers;
using Selenium.Automation.Platform.Factory;

namespace Selenium.Automation.UI.Product
{
	public class ProductTopSteps : StepsBase, IProductTopSteps
	{
		private readonly IWebDriver _webDriver;

		public ProductTopSteps(
			IWebDriver webDriver,
			IEnvironmentConfiguration environmentConfiguration)
			: base(webDriver, environmentConfiguration)
		{
			_webDriver = webDriver;
		}

		private ProductTopElement ProductTopElement =>
			PageFactory.Get<MainPage>(_webDriver).ProductTopElement;

		public string GetTitle() =>
			ProductTopElement.ProductHeaderLabel.GetText().Trim();
	}
}
