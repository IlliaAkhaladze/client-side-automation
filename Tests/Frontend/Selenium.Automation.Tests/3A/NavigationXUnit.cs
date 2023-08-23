using Autofac;

using FluentAssertions;

using Selenium.Automation.Model.Domain.Login;
using Selenium.Automation.Model.Domain.Navigation;
using Selenium.Automation.Tests._3A;

using Xunit;

namespace Selenium.Automation.Tests.Features
{
	public class NavigationXUnit : TripleABase
	{
		private INavigationSteps NavigationSteps => Container.Resolve<INavigationSteps>();
		private ILoginSteps LoginSteps => Container.Resolve<ILoginSteps>();
		
		[Theory]
		[InlineData("Ноутбуки та комп’ютери", "Комп'ютери та ноутбуки")]
		[InlineData("Смартфони, ТВ і електроніка", "Смартфони, ТВ і Електроніка")]
		[InlineData("Товари для геймерів", "Товари для геймерів")]
		public void CheckNavigationLink(string linkToOpen, string expectedValue)
		{
			//Arrange
			LoginSteps.OpenMainView();

			//Action
			NavigationSteps.Open(linkToOpen);

			//Assert
			string expectedHeader = NavigationSteps.GetHeader();
			expectedHeader.Should().Be(expectedValue);
		}
	}
}
