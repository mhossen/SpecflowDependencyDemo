namespace SeleniumDemo.POM.Pages;

public interface INavigationPage
{
  void GoToPage(string pageName);
}

internal class NavigationPage : BasePage, INavigationPage
{
  public NavigationPage(IWebDriver driver) : base(driver)
  {
  }

  public void GoToPage(string pageName)
  {
    Driver.FindElement(By.XPath($"//div[@id='navbar-placeholder']/nav//a[contains(.,'{pageName}')]")).Click();
  }
}