using System.Threading;
using Cysharp.Threading.Tasks;
using VContainer.Unity;

namespace Project.Boot
{
  public class BootProcess : IAsyncStartable
  {
    public UniTask StartAsync(CancellationToken cancellation = default)
    {
      return UniTask.CompletedTask;
    }
  }
}
