using System;
using UnityEngine;
using UnityEngine.UI;

namespace TicTacToe
{
    public class GameWindow : Window
    {
        public event Action OnSoundButtonClicked;

        [SerializeField] private Button _soundButton;

        private void OnEnable()
        {
            _soundButton.onClick.AddListener(OnSoundButton);
        }

        private void OnDisable()
        {
            _soundButton.onClick.RemoveListener(OnSoundButton);
        }

        private void OnSoundButton() => OnSoundButtonClicked?.Invoke();
    }
}
