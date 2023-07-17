using Selenium.Automation.Model.Domain.Login;
using Selenium.Automation.Model.Domain.Navigation;

using TechTalk.SpecFlow;

namespace Selenium.Automation.Tests.Features
{
	[Binding, Scope(Feature = "NavigationScenarios")]
	public class NavigationDefinition
	{
		private readonly INavigationSteps _navigationSteps;
		private readonly ILoginSteps _loginSteps;

		public NavigationDefinition(
			INavigationSteps navigationSteps,
			ILoginSteps loginSteps)
		{
			_navigationSteps = navigationSteps;
			_loginSteps = loginSteps;
		}

		[Given(@"I open main view")]
		public void GivenIOpenMainView()
		{
			_loginSteps.OpenMainView();
		}

		[When(@"I open '(.*)' link")]
		public void WhenIOpenLink(string linkText)
		{
			_navigationSteps.Open(linkText);
		}

		[Then(@"I see '(.*)' header")]
		public void ThenISeeЮтериТаНоутбукиHeader(string expectedValue)
		{
			throw new PendingStepException();
		}

	}
}
