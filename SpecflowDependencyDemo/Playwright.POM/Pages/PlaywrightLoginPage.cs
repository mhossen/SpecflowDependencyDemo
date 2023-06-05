namespace Playwright.POM.Pages;

public interface IPlaywrightLoginPage
{
  void NavigateToLoginPage();
  void Login(string username, string password);
}

internal sealed class PlaywrightLoginPage : BasePage, IPlaywrightLoginPage
{
  private ILocator Username => Page.Locator("#username");
  private ILocator Password => Page.Locator("#password");
  private ILocator LoginButton => Page.Locator("input[value='Login']");

  public PlaywrightLoginPage(IPage page) : base(page)
  {
  }

  public void NavigateToLoginPage()
  {
    var location = typeof(PlaywrightLoginPage).Assembly.Location;
    var parent = Directory.GetParent(location);
    Page.GotoAsync(@$"{parent}\Sample\login.html").GetAwaiter().GetResult();
  }

  public void Login(string username, string password)
  {
    Username.FillAsync(username).GetAwaiter().GetResult();
    Password.FillAsync(password).GetAwaiter().GetResult();
    LoginButton.ClickAsync(new LocatorClickOptions
    {
      Timeout = 2000,
      Button = MouseButton.Left
    }).GetAwaiter().GetResult();
  }
}