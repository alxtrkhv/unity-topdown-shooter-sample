using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Project.Boot
{
  public class BootScope : LifetimeScope
  {
    protected override void Configure(IContainerBuilder builder)
    {
      builder.RegisterEntryPointExceptionHandler(exception => {
        Debug.LogError($"Exception during scope configuration: {exception}");
      });

      builder.RegisterEntryPoint<BootProcess>();
    }
  }
}
