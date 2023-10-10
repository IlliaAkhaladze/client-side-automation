using FluentAssertions;
using Selenium.Automation.Model.Domain.Header;
using Selenium.Automation.Model.Domain.Login;
using TechTalk.SpecFlow;

namespace Selenium.Automation.Tests.Features
{
    [Binding, Scope(Feature = "Header")]
    public class HeaderDefinition
    {
        private readonly ILoginSteps _loginSteps;
        private readonly IHeaderSteps _headerSteps;

        public HeaderDefinition(
            ILoginSteps loginSteps,
            IHeaderSteps headerSteps)
        {
            _loginSteps = loginSteps;
            _headerSteps = headerSteps;
        }

        [Given(@"I open main view")]
        public void GivenIOpenMainView() =>
            _loginSteps.OpenMainView();

        [When(@"I change language to UA")]
        public void WhenIChangeLanguageToUA() =>
            _headerSteps.ChangeLanguageUA();

        [Then(@"I see language is  UA")]
        public void ThenISeeLanguageIsUA()
        {
            bool actualValue = _headerSteps.IsLanguageUA();
            actualValue.Should().BeTrue();
        }
    }
}