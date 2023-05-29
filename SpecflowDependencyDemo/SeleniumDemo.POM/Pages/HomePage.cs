namespace SeleniumDemo.POM.Pages;

public class HomePage : BasePage
{
  private IWebElement HomePageHeader => Driver.FindElement(By.CssSelector("h1"));

  public HomePage(IWebDriver driver) : base(driver)
  {
  }

  public string HeaderText => HomePageHeader.Text;
}