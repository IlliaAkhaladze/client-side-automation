namespace Selenium.Automation.Model.Domain.Slider
{
	public interface ISliderSteps
	{
		int GetCountPost();
		object GetCurrentPost();
		void Next();
		string[] GetPostLinks();
	}
}
