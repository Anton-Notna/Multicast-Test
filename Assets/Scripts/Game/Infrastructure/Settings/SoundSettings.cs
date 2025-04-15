using UniRx;
using UnityEngine;

namespace Game.Infrastructure.Settings
{
    public class SoundSettings
    {
        private const string _playerPrefsKey = "sound_enabled";
        private readonly ReactiveProperty<bool> _enabled = new ReactiveProperty<bool>(true);

        public IReadOnlyReactiveProperty<bool> Enabled => _enabled;

        public SoundSettings()
        {
            int saved = PlayerPrefs.GetInt(_playerPrefsKey, 1);
            _enabled = new ReactiveProperty<bool>(saved != 0);
        }

        public void SetSoundEnabled(bool enabled)
        {
            if (_enabled.Value == enabled)
                return;

            PlayerPrefs.SetInt(_playerPrefsKey, enabled ? 1 : 0);
            _enabled.Value = enabled;
        }
    }
}
