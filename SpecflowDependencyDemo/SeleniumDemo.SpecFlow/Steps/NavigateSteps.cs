namespace SeleniumDemo.SpecFlow.Steps;

[Binding]
public sealed class NavigateSteps : StepBase
{
  public NavigateSteps(IObjectContainer container) : base(container)
  {
  }

  [When(@"I navigate to '(.*)'")]
  public void WhenINavigateTo(string page)
  {
    GetPage<NavigationPage>().GoToPage(page);
  }
}