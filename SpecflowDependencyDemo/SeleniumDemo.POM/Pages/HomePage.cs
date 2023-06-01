namespace SeleniumDemo.POM.Pages;

public interface IHomePage
{
  string HeaderText { get; }
}

internal class HomePage : BasePage, IHomePage
{
  private IWebElement HomePageHeader => Driver.FindElement(By.CssSelector("h1"));

  public HomePage(IWebDriver driver) : base(driver)
  {
  }

  public string HeaderText => HomePageHeader.Text;
}