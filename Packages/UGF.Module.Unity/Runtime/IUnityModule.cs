using UGF.Application.Runtime;

namespace UGF.Module.Unity.Runtime
{
    public interface IUnityModule : IApplicationModule
    {
        IUnityResources Resources { get; }
    }
}
