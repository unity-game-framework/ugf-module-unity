using System;
using System.Collections;
using UGF.Coroutines.Runtime;
using UnityEngine;

namespace UGF.Module.Unity.Runtime.Coroutines
{
    public class ResourceRequestCoroutine<TResult> : Coroutine<TResult>
    {
        public ResourceRequest ResourceRequest { get; }

        public ResourceRequestCoroutine(ResourceRequest resourceRequest)
        {
            ResourceRequest = resourceRequest ?? throw new ArgumentNullException(nameof(resourceRequest));
        }

        protected override IEnumerator Routine()
        {
            yield return ResourceRequest;

            Result = (TResult)(object)ResourceRequest.asset;
        }
    }
}
