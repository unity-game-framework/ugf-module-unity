using System;
using UGF.Application.Runtime;

namespace UGF.Module.Unity.Runtime
{
    public class UnityModule : ApplicationModuleBase, IUnityModule
    {
        public IUnityResources Resources { get; }

        public UnityModule(IUnityResources resources)
        {
            Resources = resources ?? throw new ArgumentNullException(nameof(resources));
        }
    }
}
