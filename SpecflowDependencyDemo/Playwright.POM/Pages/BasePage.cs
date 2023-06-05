namespace Playwright.POM.Pages;

public abstract class BasePage
{
  protected IPage Page;

  protected BasePage(IPage page)
  {
    Page = page;
  }
}