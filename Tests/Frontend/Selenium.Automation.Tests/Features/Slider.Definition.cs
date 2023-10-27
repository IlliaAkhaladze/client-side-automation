using FluentAssertions;
using Selenium.Automation.Model.Domain.Login;
using Selenium.Automation.Model.Domain.Slider;
using TechTalk.SpecFlow;

namespace Selenium.Automation.Tests.Features
{
	[Binding, Scope(Feature = "Slider")]
	public class SliderDefinition
	{
		private ISliderSteps _sliderSteps;
		private readonly ILoginSteps _loginSteps;

		public SliderDefinition(
			ISliderSteps sliderSteps,
			ILoginSteps loginSteps)
		{
			_sliderSteps = sliderSteps;
			_loginSteps = loginSteps;
		}

		[Given(@"I open main view")]
		[When(@"I open main view")]
		public void GivenIOpenMainView()
		{
			_loginSteps.OpenMainView();
		}

		[Then(@"I see '([^']*)' posts")]
		public void ThenISeePost(string expectedValue)
		{
			var actualValues = _sliderSteps.GetPostLinks();
			actualValues
				.Should()
				.Contain(expectedValue);
		}
	}
}
