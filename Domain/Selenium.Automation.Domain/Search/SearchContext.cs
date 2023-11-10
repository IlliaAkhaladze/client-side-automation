using Selenium.Automation.Model.Domain.Search;

namespace Selenium.Automation.Domain.Search
{
	public class SearchContext : ISearchContext
	{
		private readonly ISearchSteps _searchSteps;

		public SearchContext(
			ISearchSteps searchSteps)
		{
			_searchSteps = searchSteps;
		}

		public void Search(string value)
		{
			_searchSteps.Search(value);
		}

		public void SearchAndClose(string value)
		{
			_searchSteps.Search(value);
			_searchSteps.Close();
		}
	}
}
