namespace Playwright.POM.Pages;

internal interface IPlaywrightNavigationPage
{
  void GoToPage(string pageName);
}

internal sealed class PlaywrightNavigationPage : BasePage, IPlaywrightNavigationPage
{
  public PlaywrightNavigationPage(IPage page) : base(page)
  {
  }

  public void GoToPage(string pageName)
  {
    Page
      .Locator($"//div[@id='navbar-placeholder']/nav//a[contains(.,'{pageName}')]")
      .ClickAsync()
      .GetAwaiter()
      .GetResult();
  }
}