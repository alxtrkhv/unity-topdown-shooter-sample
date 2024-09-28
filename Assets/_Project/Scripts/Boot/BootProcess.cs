using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine.SceneManagement;
using VContainer.Unity;

namespace Project.Boot
{
  public class BootProcess : IAsyncStartable
  {
    public async UniTask StartAsync(CancellationToken cancellation = default)
    {
      await LoadGameplayScene();
    }

    private async UniTask LoadGameplayScene()
    {
      var sceneName = "Gameplay";

      if (SceneManager.GetActiveScene().name == sceneName) {
        return;
      }

      await SceneManager.LoadSceneAsync(sceneName);
    }
  }
}
