namespace Selenium.Automation.Model.Domain.Filter
{
    public interface IFilterSteps
    {
        string[] GetFilters(string category);
        void OpenCategory();
        string SetSubFilter(bool value, string name); 
        string[] GetSelectedFilters(string selectedFilter);          
    }
}
