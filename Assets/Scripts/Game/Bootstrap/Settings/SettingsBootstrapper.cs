using Game.Infrastructure.SceneManagement;
using Game.Shared.SceneManagement;
using Zenject;

namespace Game.Bootstrap.Settings
{
    public class SettingsBootstrapper : MonoInstaller, ISceneBootstrapper<SettingsPayload>
    {
        public void Bootstrap(SettingsPayload payload)
        {
            
        }

        public override void InstallBindings()
        {

        }
    }
}