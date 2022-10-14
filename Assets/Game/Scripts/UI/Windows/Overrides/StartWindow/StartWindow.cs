using System;
using UnityEngine;
using UnityEngine.UI;

namespace TicTacToe
{
    public class StartWindow : Window
    {
        public event Action OnStartButtonClicked;
        public event Action OnSoundButtonClicked;

        [SerializeField] private Button _startButton;
        [SerializeField] private Button _soundButton;

        private void OnEnable()
        {
            _startButton.onClick.AddListener(OnStartButton);
            _soundButton.onClick.AddListener(OnSoundButton);
        }

        private void OnDisable()
        {
            _startButton.onClick.RemoveListener(OnStartButton);
            _soundButton.onClick.RemoveListener(OnSoundButton);
        }

        private void OnStartButton() => OnStartButtonClicked?.Invoke();

        private void OnSoundButton() => OnSoundButtonClicked?.Invoke();
    }
}
