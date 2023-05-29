using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumDemo.SpecFlow.Drivers
{
  public static class Driver
  {
    public static IWebDriver CreateBrowserSession()
    {
      new DriverManager().SetUpDriver(new ChromeConfig());
      var driver = new ChromeDriver();
      driver.Manage().Window.Maximize();
      return driver;
    }
  }
}