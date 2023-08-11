namespace Selenium.Automation.Model.Domain.Filter
{
	public interface IFilterSteps
    {
        string[] GetFilters(string category);
        void OpenCategory();
        void SetSubFilter(bool value, string category, string filterName); 
        string[] GetSelectedFilters();          
    }
}
