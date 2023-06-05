using System;
using Playwright.POM.Pages;
using Playwright.Specflow.Drivers;
using TechTalk.SpecFlow;

namespace Playwright.Specflow.Hooks;

[Binding]
public class Hooks
{
  private readonly IObjectContainer _container;

  protected Hooks(IObjectContainer container)
  {
    _container = container;
  }

  [Before(Order = 0)]
  public void BrowserSetup()
  {
    var playwright = PlaywrightDriver.CreateBrowserSession();
    _container.RegisterInstanceAs(playwright);
    _container.RegisterTypes<BasePage>(_container.Resolve<IPage>());
  }

  [After(Order = 99)]
  public void BrowserTearDown()
  {
    _container.Resolve<IPage>().CloseAsync().GetAwaiter().GetResult();
  }
}