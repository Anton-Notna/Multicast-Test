using UnityEngine;
using Zenject;
using Game.Infrastructure.SceneManagement;
using Game.Shared.SceneManagement;
using Game.UI.Settings;

namespace Game.Bootstrap.Settings
{
    public class SettingsBootstrapper : MonoInstaller, ISceneBootstrapper<SettingsPayload>
    {
        [SerializeField]
        private SettingsView _view;

        public override void InstallBindings()
        {
            Container.BindInstance(_view).AsSingle();
            Container.BindInterfacesAndSelfTo<SettingsController>().AsSingle();
        }

        public void Bootstrap(SettingsPayload payload)
        {
            Container.InjectGameObject(_view.gameObject);
        }
    }
}