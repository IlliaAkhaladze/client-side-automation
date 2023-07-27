using FluentAssertions;
using Selenium.Automation.Model.Domain.Filter;
using Selenium.Automation.Model.Domain.Login;
using Selenium.Automation.TestsData.Storage;
using TechTalk.SpecFlow;

namespace Selenium.Automation.Tests.Features
{
    [Binding, Scope(Feature = "Filter")]
    public class FilterStepDefinitions
    {
        private readonly IFilterSteps _filterSteps;
        private readonly ILoginSteps _loginSteps;

        private string[] _actualFilters;
        private string _checkedOptions;
     
        public FilterStepDefinitions( 
				IFilterSteps filterSteps,
                ILoginSteps loginSteps)
        {
			_loginSteps = loginSteps;
            _filterSteps = filterSteps;       
        }

		[Given(@"I open main view")]
		public void GivenIOpenMainView()
		{
			_loginSteps.OpenMainView();
		}

		[Given(@"I open goods category")]
		public void GivenIOpenPage()
		{
			_filterSteps.OpenCategory();			
		}

        [When(@"I get filters by '(.*)' category")]
        public void WhenIGetFilters(string category)
        {
            _actualFilters = _filterSteps.GetFilters(category);            
        }

        [Then(@"I see '(.*)' filters")]
        public void ThenISeeFilters(string entityname)
        {
            var expectedvalues = GoodsCategoryStorage.Values[entityname];
            _actualFilters
                .Should()
                .Contain(expectedvalues);
        }

        [When(@"I check '([^']*)' checkbox")]
        public void WhenICheckCheckbox(string filterName)
        {
            _checkedOptions = _filterSteps.SetSubFilter(true, filterName);
        }

        [Then(@"I see '([^']*)' filters at page top")]
        public void ThenISeeSelectedFilters (string filterSelected)
        {

            _filterSteps.GetSelectedFilters(filterSelected);
            _filterSteps
              .Should()
              .Equals(_checkedOptions);
                
                
        }





    }
}
