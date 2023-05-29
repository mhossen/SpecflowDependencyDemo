namespace SeleniumDemo.POM.Pages;

public abstract class BasePage
{
  protected readonly IWebDriver Driver;

  protected BasePage(IWebDriver driver)
  {
    Driver = driver;
  }
}