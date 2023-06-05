namespace Playwright.POM.Pages;

public interface IPlaywrightHomePage
{
  string HeaderText { get; }
}

internal sealed class PlaywrightHomePage : BasePage, IPlaywrightHomePage
{
  private ILocator Header => Page.Locator("h1");

  public PlaywrightHomePage(IPage page) : base(page)
  {
  }

  public string HeaderText => Header.InnerTextAsync().GetAwaiter().GetResult();
}