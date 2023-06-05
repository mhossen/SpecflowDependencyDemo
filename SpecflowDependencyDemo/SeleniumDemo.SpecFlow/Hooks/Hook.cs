using OpenQA.Selenium;
using SeleniumDemo.SpecFlow.Drivers;

namespace SeleniumDemo.SpecFlow.Hooks;

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
    var driver = Driver.CreateBrowserSession();
    _container.RegisterInstanceAs(driver);
    _container.RegisterTypes<BasePage>(_container.Resolve<IWebDriver>());
  }

  [After(Order = 99)]
  public void BrowserTearDown()
  {
    _container.Resolve<IWebDriver>().Dispose();
  }
}