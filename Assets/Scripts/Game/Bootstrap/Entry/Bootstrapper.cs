using UnityEngine;
using Zenject;
using Game.Core.Services;
using Game.Core.Storage;
using Game.Infrastructure.SceneManagement;
using Game.Infrastructure.RemoteConfig;
using Game.Infrastructure.Storage;
using Game.Bootstrap.MainMenu;

namespace Game.Bootstrap.Entry
{
    public class Bootstrapper : MonoInstaller
    {
        [SerializeField]
        private RemoteConfigLevelProvider _levelProvider;

        private ILevelStorage _levelStorage;
        private SceneLoader _sceneLoader;

        public override void InstallBindings()
        {
            _levelStorage = new LevelStorage();
            _sceneLoader = new SceneLoader();

            Container.Bind<ILevelProvider>().FromInstance(_levelProvider).AsSingle();
            Container.Bind<ILevelStorage>().FromInstance(_levelStorage).AsSingle();
            Container.Bind<SceneLoader>().FromInstance(_sceneLoader).AsSingle();

        }

        public override async void Start()
        {
            var levels = await _levelProvider.LoadLevelsAsync();
            _levelStorage.SetLevels(levels);
            await _sceneLoader.Load(new MainMenuPayload());
        }
    }
}