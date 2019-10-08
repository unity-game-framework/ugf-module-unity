using UGF.Application.Runtime;
using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Module.Unity.Runtime
{
    [CreateAssetMenu(menuName = "UGF/Module.Unity/UnityModuleBuilder", order = 2000)]
    public class UnityModuleBuilderAsset : ModuleBuilderAsset<IUnityModule>
    {
        protected override IApplicationModule OnBuild(IApplication application, IModuleBuildArguments<object> arguments)
        {
            var resources = new UnityResources();

            return new UnityModule(resources);
        }
    }
}
