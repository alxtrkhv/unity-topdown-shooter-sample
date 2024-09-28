using System.Collections.Generic;
using UnityEngine;
using VContainer.Unity;

namespace Project.Boot
{
  [DefaultExecutionOrder(-5001)]
  public class ScopeLoader : MonoBehaviour
  {
    [SerializeField]
    private bool _editorOnly;

    [SerializeField]
    private List<LifetimeScope> _scopes = null!;

    private void Awake()
    {
      if (_editorOnly && !Application.isEditor) {
        return;
      }

      foreach (var scope in _scopes) {
        if (scope == null) {
          return;
        }

        var loadedScope = FindObjectOfType(scope.GetType(), includeInactive: true);
        if (loadedScope != null) {
          return;
        }

        Instantiate(scope);
      }
    }
  }
}
