namespace SeleniumDemo.SpecFlow.Steps;

public abstract class StepBase : TechTalk.SpecFlow.Steps
{
  protected readonly IObjectContainer Container;

  protected StepBase(IObjectContainer container)
  {
    Container = container;
  }

  protected TPage GetPage<TPage>() where TPage : BasePage
  {
    return Container.Resolve<TPage>();
  }
}