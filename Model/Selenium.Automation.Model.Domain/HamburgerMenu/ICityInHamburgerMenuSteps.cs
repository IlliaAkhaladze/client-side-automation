namespace Selenium.Automation.Model.Domain.HamburgerMenu
{
    public interface ICityInHamburgerMenuSteps
    {
        void ChangeCity();
        string GetCityName();
        void SetCityName(string cityName);
        void Accept();
    }
}