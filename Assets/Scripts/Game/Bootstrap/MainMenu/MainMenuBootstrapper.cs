using Game.Infrastructure.SceneManagement;
using Game.Shared.SceneManagement;
using Game.UI.MainMenu;
using UnityEngine;
using Zenject;

namespace Game.Bootstrap.MainMenu
{
    public class MainMenuBootstrapper : MonoInstaller, ISceneBootstrapper<MainMenuPayload>
    {
        [SerializeField]
        private MainMenuView _mainMenuView;

        public override void InstallBindings()
        {
            Container.BindInstance(_mainMenuView).AsSingle();
            Container.BindInterfacesAndSelfTo<MainMenuController>().AsSingle();
        }

        public void Bootstrap(MainMenuPayload payload)
        {
            Container.InjectGameObject(_mainMenuView.gameObject);
        }
    }
}