using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace TicTacToe
{
    public class SoundWindow : Popup, ISoundSlider
    {
        public event Action<float> OnSoundValueChanged;

        [SerializeField] private Slider _soundSlider;
        [SerializeField] private TMP_Text _soundValueText;

        private void OnEnable()
        {
            InitializeSoundValues();

            BackgroundButton.onClick.AddListener(OnBackgroundButton);
            _soundSlider.onValueChanged.AddListener(OnSoundSlided);
        }

        private void OnDisable()
        {
            BackgroundButton.onClick.RemoveListener(OnBackgroundButton);
            _soundSlider.onValueChanged.RemoveListener(OnSoundSlided);
        }

        private void InitializeSoundValues()
        {
            if (Prefs.TryGetValue(PrefsNames.SoundValue, out float value))
            {
                _soundSlider.value = value;
                UpdateText(value);
            }
        }

        private void OnSoundSlided(float value)
        {
            UpdateText(value);
            OnSoundValueChanged?.Invoke(value);
        }

        private void UpdateText(float value)
{
            _soundValueText.text = (value * 100).ToString("N0") + "%";
        }
    }
}
