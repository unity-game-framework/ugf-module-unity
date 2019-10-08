using System;
using System.Collections;
using UnityEngine;
using Coroutine = UGF.Coroutines.Runtime.Coroutine;

namespace UGF.Module.Unity.Runtime.Coroutines
{
    public class AsyncOperationCoroutine : Coroutine
    {
        public AsyncOperation AsyncOperation { get; }

        public AsyncOperationCoroutine(AsyncOperation asyncOperation)
        {
            AsyncOperation = asyncOperation ?? throw new ArgumentNullException(nameof(asyncOperation));
        }

        protected override IEnumerator Routine()
        {
            yield return AsyncOperation;
        }
    }
}
