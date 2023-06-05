namespace Playwright.Specflow.Drivers;

public static class PlaywrightDriver
{
  public static IPage CreateBrowserSession()
  {
    var playwright = Microsoft.Playwright.Playwright.CreateAsync().GetAwaiter().GetResult();
    var browser = playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
    {
      Headless = false,
      Channel = "chrome",
      SlowMo = 120
    }).GetAwaiter().GetResult();

    var context = browser.NewContextAsync(new BrowserNewContextOptions
    {
      IgnoreHTTPSErrors = true
    }).GetAwaiter().GetResult();

    var page = context.NewPageAsync().GetAwaiter().GetResult();
    return page;
  }
}