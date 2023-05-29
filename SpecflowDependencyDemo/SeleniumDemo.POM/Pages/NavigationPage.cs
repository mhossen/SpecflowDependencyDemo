namespace SeleniumDemo.POM.Pages;

public class NavigationPage : BasePage
{
  public NavigationPage(IWebDriver driver) : base(driver)
  {
  }

  public void GoToPage(string pageName)
  {
    Driver.FindElement(By.XPath($"//div[@id='navbar-placeholder']/nav//a[contains(.,'{pageName}')]")).Click();
  }
}