using Game.Infrastructure.Settings;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Game.UI.Common
{
    [RequireComponent(typeof(Button))]
    public class AudioOnClick : MonoBehaviour
    {
        [SerializeField]
        private Button _button;
        [SerializeField]
        private AudioSource _audioSource;

        private SoundSettings _settings;

        [Inject]
        public void Construct(SoundSettings settings) => _settings = settings;

        private void Start()
        {
            _button.onClick.AddListener(() =>
            {
                if (_settings.Enabled.Value)
                    _audioSource.Play();
            });
        }
    }
}