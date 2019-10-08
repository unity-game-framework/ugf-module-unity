using System;
using UGF.Coroutines.Runtime;

namespace UGF.Module.Unity.Runtime
{
    public interface IUnityResources
    {
        ICoroutine<object> LoadAsync(string path, Type assetType);
        ICoroutine<T> LoadAsync<T>(string path);
        ICoroutine UnloadUnusedAsync();
    }
}
