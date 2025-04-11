using System;
using UnityEngine;
using UnityEngine.UI;

namespace Game.UI.MainMenu
{
    public class MainMenuView : MonoBehaviour
    {
        [SerializeField]
        private Button _playButton;
        [SerializeField]
        private Button _settingsButton;

        public event Action OnPlayClicked;
        public event Action OnSettingsClicked;

        private void Awake()
        {
            _playButton.onClick.AddListener(() => OnPlayClicked?.Invoke());
            _settingsButton.onClick.AddListener(() => OnSettingsClicked?.Invoke());
        }
    }
}