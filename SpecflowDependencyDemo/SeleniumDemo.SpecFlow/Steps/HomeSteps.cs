namespace SeleniumDemo.SpecFlow.Steps;

[Binding]
public sealed class HomeSteps : StepBase
{
  public HomeSteps(IObjectContainer container) : base(container)
  {
  }

  [Then(@"I verify home page has header '(.*)'")]
  public void ThenIVerifyHomePageHasHeader(string header)
  {
    var headerText = GetPage<HomePage>().HeaderText;
    headerText.Should().Be("Welcome to Sample Website");
  }
}