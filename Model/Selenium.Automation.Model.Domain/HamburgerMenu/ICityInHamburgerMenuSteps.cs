

namespace Selenium.Automation.Model.Domain.HamburgerMenu
{
    public interface ICityInHamburgerMenuSteps
    {
        void ChangeCityButton();
        string GetCityName();

        void SetCityName(string cityName);
        void AcceptButton();
    }
}
