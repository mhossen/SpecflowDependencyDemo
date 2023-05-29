namespace SeleniumDemo.SpecFlow.Steps;

[Binding]
public class LoginSteps : StepBase
{
  public LoginSteps(IObjectContainer container) : base(container)
  {
  }

  [Given(@"I navigate to login page")]
  public void GivenINavigateToLoginPage()
  {
    GetPage<LoginPage>().NavigateToLoginPage();
  }

  [Given(@"I provide '(.*)' and '(.*)'")]
  public void GivenIProvide(string username, string password)
  {
    GetPage<LoginPage>().Login(username, password);
  }
}