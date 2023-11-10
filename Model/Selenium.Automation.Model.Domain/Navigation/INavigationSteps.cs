namespace Selenium.Automation.Model.Domain.Navigation
{
	public interface INavigationSteps
	{
		string GetHeader();
		void Open(string linkText);
	}
}
