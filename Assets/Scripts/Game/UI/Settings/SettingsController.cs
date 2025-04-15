using System;
using Zenject;
using Cysharp.Threading.Tasks;
using Game.Infrastructure.SceneManagement;
using Game.Infrastructure.Settings;

namespace Game.UI.Settings
{
    public class SettingsController : IInitializable, IDisposable
    {
        private readonly SoundSettings _sound;
        private readonly SceneLoader _sceneLoader;
        private readonly SettingsView _view;

        public SettingsController(SoundSettings sound, SceneLoader sceneLoader, SettingsView view)
        {
            _sound = sound;
            _sceneLoader = sceneLoader;
            _view = view;
        }

        public void Initialize()
        {
            _view.OnBackClicked += HandleBack;
            _view.OnSoundToggled += HandleSoundChange;
            _view.SetSoundValue(_sound.Enabled.Value);
        }

        public void Dispose()
        {
            _view.OnBackClicked -= HandleBack;
            _view.OnSoundToggled -= HandleSoundChange;
        }

        private void HandleBack() => _sceneLoader.Load(new MainMenuPayload()).Forget();

        private void HandleSoundChange(bool enabled) => _sound.SetSoundEnabled(enabled);
    }
}