namespace SeleniumDemo.SpecFlow.Steps;

[Binding]
public sealed class HomeSteps : StepBase
{
  private readonly IHomePage _homePage;

  public HomeSteps(IObjectContainer container, IHomePage homePage) : base(container)
  {
    _homePage = homePage;
  }

  [Then(@"I verify home page has header '(.*)'")]
  public void ThenIVerifyHomePageHasHeader(string header)
  {
    var headerText = _homePage.HeaderText;
    headerText.Should().Be("Welcome to Sample Website");
  }
}