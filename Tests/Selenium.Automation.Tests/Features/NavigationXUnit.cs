using System;
using System.Collections.Generic;
using System.Text;

using FluentAssertions;

using Selenium.Automation.Model.Domain.Login;
using Selenium.Automation.Model.Domain.Navigation;

using Xunit;

namespace Selenium.Automation.Tests.Features
{
	public class NavigationXUnit
	{
		private readonly INavigationSteps _navigationSteps;
		private readonly ILoginSteps _loginSteps;

		public NavigationXUnit()
			//INavigationSteps navigationSteps,
			//ILoginSteps loginSteps)
		{
			//_navigationSteps = navigationSteps;
			//_loginSteps = loginSteps;
		}
		
		[Theory]
		[InlineData("Ноутбуки та комп’ютери", "Комп'ютери та ноутбуки")]
		public void CheckNavigationLink(string linkToOpen, string expectedValue)
		{
			// Arrange
			//_loginSteps.OpenMainView();

			// Action
			//_navigationSteps.Open(linkToOpen);

			// Assert
			//string expectedHeader = _navigationSteps.GetHeader();
			//expectedHeader.Should().Be(expectedValue);
		}
	}
}
