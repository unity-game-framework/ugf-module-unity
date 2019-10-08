using System;
using UGF.Coroutines.Runtime;
using UGF.Module.Unity.Runtime.Coroutines;
using UnityEngine;

namespace UGF.Module.Unity.Runtime
{
    public class UnityResources : IUnityResources
    {
        public ICoroutine<object> LoadAsync(string path, Type assetType)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentException("Value cannot be null or empty.", nameof(path));
            if (assetType == null) throw new ArgumentNullException(nameof(assetType));

            ResourceRequest request = Resources.LoadAsync(path, assetType);

            return new ResourceRequestCoroutine<object>(request);
        }

        public ICoroutine<T> LoadAsync<T>(string path)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentException("Value cannot be null or empty.", nameof(path));

            ResourceRequest request = Resources.LoadAsync(path, typeof(T));

            return new ResourceRequestCoroutine<T>(request);
        }

        public ICoroutine UnloadUnusedAsync()
        {
            AsyncOperation operation = Resources.UnloadUnusedAssets();

            return new AsyncOperationCoroutine(operation);
        }
    }
}
