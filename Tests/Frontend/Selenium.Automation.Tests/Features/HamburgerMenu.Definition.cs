using FluentAssertions;
using Selenium.Automation.Model.Domain.HamburgerMenu;
using Selenium.Automation.Model.Domain.Login;
using TechTalk.SpecFlow;
namespace Selenium.Automation.Tests.Features
{
    [Binding, Scope(Feature = "HamburgerMenuScenarios")]
    public class HamburgerMenuDefinition
    {
        private readonly IHamburgerMenuSteps _hamburgerMenuSteps;
        private readonly ILoginSteps _loginSteps;

        public HamburgerMenuDefinition(
            IHamburgerMenuSteps hamburgerMenuSteps,
            ILoginSteps loginSteps)
        {
            _hamburgerMenuSteps = hamburgerMenuSteps;
            _loginSteps = loginSteps;
        }

        [Given(@"I open main view")]
        public void GivenIOpenMainView()
        {
            _loginSteps.OpenMainView();
        }

        [When(@"I expand hamburger menu")]
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


    }
}
