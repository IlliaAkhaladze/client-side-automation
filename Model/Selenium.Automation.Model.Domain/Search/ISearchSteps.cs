namespace Selenium.Automation.Model.Domain.Search
{
	public interface ISearchSteps
	{
		void SetValue(string value);
		void Search();
		void Search(string value);
		void Close();
	}
}
