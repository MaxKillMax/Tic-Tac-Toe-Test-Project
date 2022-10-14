using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace TicTacToe
{
    public class EndWindow : Window
    {
        public event Action OnRestartButtonClicked;

        [SerializeField] private Button _restartButton;
        [SerializeField] private TMP_Text _titleText;

        private void OnEnable()
        {
            _restartButton.onClick.AddListener(OnRestartButton);
        }

        private void OnDisable()
        {
            _restartButton.onClick.RemoveListener(OnRestartButton);
        }

        private void OnRestartButton() => OnRestartButtonClicked?.Invoke();

        public void SetTitleText(string text)
        {
            _titleText.text = text;
        }
    }
}
