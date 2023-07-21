using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium.Automation.Model.Domain.Filter
{
    public interface IFilterSteps
    {
        string[] GetFilters(string category);
    }
}
