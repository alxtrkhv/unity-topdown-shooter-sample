using VContainer;
using VContainer.Unity;

namespace Project.App
{
  public class AppScope : LifetimeScope
  {
    protected override void Configure(IContainerBuilder builder)
    {
      builder.RegisterEntryPoint<AppRoot>();
    }
  }
}
