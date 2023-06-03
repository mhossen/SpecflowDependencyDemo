namespace SeleniumDemo.SpecFlow.Steps;

[Binding]
public class LoginSteps : StepBase
{
  private readonly ILoginPage _loginPage;

  public LoginSteps(IObjectContainer container, ILoginPage loginPage) : base(container)
  {
    _loginPage = loginPage;
  }

  [Given(@"I navigate to login page")]
  public void GivenINavigateToLoginPage()
  {
    _loginPage.NavigateToLoginPage();
  }

  [Given(@"I provide '(.*)' and '(.*)'")]
  public void GivenIProvide(string username, string password)
  {
    _loginPage.Login(username, password);
  }
}