using System;
using Zenject;
using Cysharp.Threading.Tasks;
using Game.Core.Storage;
using Game.Infrastructure.SceneManagement;

namespace Game.UI.MainMenu
{
    public class MainMenuController : IInitializable, IDisposable
    {
        private readonly ILevelStorage _levelStorage;
        private readonly SceneLoader _sceneLoader;
        private readonly MainMenuView _view;

        public MainMenuController(ILevelStorage levelStorage, SceneLoader sceneLoader, MainMenuView view)
        {
            _levelStorage = levelStorage;
            _sceneLoader = sceneLoader;
            _view = view;
        }

        public void Initialize()
        {
            _view.OnPlayClicked += HandlePlay;
            _view.OnSettingsClicked += HandleSettings;
        }

        public void Dispose()
        {
            _view.OnPlayClicked -= HandlePlay;
            _view.OnSettingsClicked -= HandleSettings;
        }

        private void HandlePlay()
        {
            var level = _levelStorage.Levels[0];
            _sceneLoader.Load(new GameScenePayload(level)).Forget();
        }

        private void HandleSettings() => _sceneLoader.Load(new SettingsPayload()).Forget();
    }
}