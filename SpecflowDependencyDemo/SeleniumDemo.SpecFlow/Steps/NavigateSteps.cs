namespace SeleniumDemo.SpecFlow.Steps;

[Binding]
public sealed class NavigateSteps : StepBase
{
  private readonly INavigationPage _navigationPage;

  public NavigateSteps(IObjectContainer container, INavigationPage navigationPage) : base(container)
  {
    _navigationPage = navigationPage;
  }

  [When(@"I navigate to '(.*)'")]
  public void WhenINavigateTo(string page)
  {
    // GetPage<NavigationPage>().GoToPage(page);
    _navigationPage.GoToPage(page);
  }
}