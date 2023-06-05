namespace Playwright.Specflow.Steps;

public abstract class PlaywrightBaseStep : TechTalk.SpecFlow.Steps
{
  protected IObjectContainer _container;

  protected PlaywrightBaseStep(IObjectContainer container)
  {
    _container = container;
  }
}