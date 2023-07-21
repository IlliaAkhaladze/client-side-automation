using Selenium.Automation.Model.Domain.Filter;
using Selenium.Automation.Model.Domain.Login;
using Selenium.Automation.Model.Domain.Navigation;
using TechTalk.SpecFlow;

namespace Selenium.Automation.Tests.Features
{
    [Binding, Scope(Feature = "Filter")]
    public class FilterStepDefinitions
    {
        private readonly IFilterSteps _filter;
        private readonly ILoginSteps _loginSteps;
        private readonly INavigationSteps _navigationSteps;

        public FilterStepDefinitions(      
                INavigationSteps navigationSteps)

        {           
            _navigationSteps = navigationSteps;
        }

        [Given(@"I open '(.*)' page")]
        public void GivenIOpenPage(string directLink)
        {
            
        }

        //[When(@"I filter goods by ""([^""]*)""")]
        //public void WhenIFilterGoodsBy(string платформа)
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"I select filter category value ""([^""]*)""")]
        //public void WhenISelectFilterCategoryValue(string p0)
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"I see selected filter options above goods")]
        //public void ThenISeeSelectedFilterOptionsAboveGoods()
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"I see ""([^""]*)"" header")]
        //public void ThenISeeHeader(string p0)
        //{
        //    throw new PendingStepException();
        //}
    }
}
