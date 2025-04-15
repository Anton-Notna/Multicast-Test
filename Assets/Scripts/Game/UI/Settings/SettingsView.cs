using System;
using UnityEngine;
using UnityEngine.UI;

namespace Game.UI.Settings
{
    public class SettingsView : MonoBehaviour
    {
        [SerializeField]
        private Toggle _soundToggle;
        [SerializeField]
        private Button _backButton;

        public event Action<bool> OnSoundToggled;
        public event Action OnBackClicked;

        private void Awake()
        {
            _soundToggle.onValueChanged.AddListener(val => OnSoundToggled?.Invoke(val));
            _backButton.onClick.AddListener(() => OnBackClicked?.Invoke());
        }

        public void SetSoundValue(bool value) => _soundToggle.isOn = value;
    }
}