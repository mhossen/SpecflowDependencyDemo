using FluentAssertions;
using Playwright.POM.Pages;

namespace Playwright.Specflow.Steps;

[Binding]
public class PlaywrightLoginStep : PlaywrightBaseStep
{
  private readonly IPlaywrightLoginPage _loginPage;
  private readonly IPlaywrightHomePage _homePage;

  public PlaywrightLoginStep(IObjectContainer container, IPlaywrightLoginPage loginPage, IPlaywrightHomePage homePage) : base(container)
  {
    _loginPage = loginPage;
    _homePage = homePage;
  }

  [Given(@"I navigate to login page")]
  public void GivenINavigateToLoginPage()
  {
    _loginPage.NavigateToLoginPage();
  }

  [Given(@"I provide '(.*)' and '(.*)'")]
  public void GivenIProvideAnd(string username, string password)
  {
    _loginPage.Login(username, password);
  }

  [Then(@"I verify home page has header '(.*)'")]
  public void ThenIVerifyHomePageHasHeader(string pageHeader)
  {
    _homePage.HeaderText.Should().Be(pageHeader);
  }
}