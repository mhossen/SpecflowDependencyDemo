namespace SeleniumDemo.SpecFlow.Hooks;

public static class ContainerExtension
{
  public static void RegisterTypes<TBase>(this IObjectContainer container, params object[] args) where TBase : class
  {
    var typeOfBase = typeof(TBase);

    var derivedTypes = typeOfBase.Assembly.GetTypes()
      .Where(t => typeOfBase.IsAssignableFrom(t) && t is {IsClass: true, IsAbstract: false});

    Parallel.ForEach(derivedTypes, derivedType =>
    {
      var obj = Activator.CreateInstance(derivedType, args);
      container.RegisterInstanceAs(obj);
    });
  }
}