namespace SeleniumDemo.POM.Pages;

public interface ILoginPage
{
  void NavigateToLoginPage();
  void Login(string username, string password);
}

internal class LoginPage : BasePage, ILoginPage
{
  private IWebElement UserName => Driver.FindElement(By.Id("username"));
  private IWebElement Password => Driver.FindElement(By.Id("password"));
  private IWebElement LoginButton => Driver.FindElement(By.CssSelector("input[value='Login']"));

  public LoginPage(IWebDriver driver) : base(driver)
  {
  }

  public void NavigateToLoginPage()
  {
    var location = typeof(LoginPage).Assembly.Location;
    var parent = Directory.GetParent(location);
    Driver.Navigate().GoToUrl(@$"{parent}\Sample\login.html");
  }

  public void Login(string username, string password)
  {
    UserName.SendKeys(username);
    Password.SendKeys(password);
    LoginButton.Click();
  }
}