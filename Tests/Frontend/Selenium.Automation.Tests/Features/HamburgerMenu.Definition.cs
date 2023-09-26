using FluentAssertions;

using Selenium.Automation.Model.Domain.HamburgerMenu;
using Selenium.Automation.Model.Domain.Header;
using Selenium.Automation.Model.Domain.Login;
using Selenium.Automation.UI.Menu;
using TechTalk.SpecFlow;

namespace Selenium.Automation.Tests.Features
{
	[Binding, Scope(Feature = "HamburgerMenuScenarios")]
	public class HamburgerMenuDefinition
	{
		private readonly IHamburgerMenuSteps _hamburgerMenuSteps;
		private readonly ILoginSteps _loginSteps;
        private readonly ICityInHamburgerMenuSteps _cityInHamburgerMenuSteps;
        private readonly IHeaderSteps _headerSteps;

        public HamburgerMenuDefinition(
			IHamburgerMenuSteps hamburgerMenuSteps,
			ILoginSteps loginSteps,
            ICityInHamburgerMenuSteps cityInHamburgerMenuSteps,
            IHeaderSteps headerSteps)
		{
			_hamburgerMenuSteps = hamburgerMenuSteps;
			_loginSteps = loginSteps;
            _cityInHamburgerMenuSteps = cityInHamburgerMenuSteps;
            _headerSteps = headerSteps;

        }

		[Given(@"I open main view")]
		public void GivenIOpenMainView()
		{
			_loginSteps.OpenMainView();
		}

        [Given(@"I change language to UA")]
        public void GivenIChangeLanguageToUA()
        {
            _headerSteps.ChangeLanguageUA();
        }


        [When(@"I expand hamburger menu")]
        [Given(@"I expand hamburger menu")]
        public void WhenIExpandHamburgerMenu()
		{
			_hamburgerMenuSteps.OpenMenu();
		}

		[Then(@"I see hamburger menu expanded")]
		public void ThenISeeHamburgerMenuExpanded()
		{
			bool actualValue = _hamburgerMenuSteps.IsMenuDisplayed();
			actualValue.Should().BeTrue();
		}

        [When(@"I click Change city in Hamburger menu")]
        public void WhenIClickChangeCityInHamburgerMenu()
        {
            _cityInHamburgerMenuSteps.ChangeCityButton();
        }

        [When(@"I change city to ""([^""]*)"" in Select city popup")]
        public void WhenIChangeCityToInSelectCityPopup(string city)
        {
            _cityInHamburgerMenuSteps.SetCityName(city);
            _cityInHamburgerMenuSteps.AcceptButton();
        }




        [Then(@"I see city is changed to ""([^""]*)"" in Hamburger menu")]
        public void ThenISeeCityIsChangedToInHamburgerMenu(string expectedValue)
        {
            var actualValue = _cityInHamburgerMenuSteps.GetCityName();
            actualValue
                .Should()
                .Contain(expectedValue);
        }


    }
}
