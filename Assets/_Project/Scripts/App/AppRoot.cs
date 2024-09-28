using System.Threading;
using Cysharp.Threading.Tasks;
using VContainer.Unity;

namespace Project.App
{
  public class AppRoot : IAsyncStartable
  {
    public UniTask StartAsync(CancellationToken cancellation = default)
    {
      return UniTask.CompletedTask;
    }
  }
}
