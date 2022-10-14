using System;
using UnityEngine;
using UnityEngine.UI;

namespace TicTacToe
{
    public abstract class Popup : Window
    {
        public event Action OnBackgroundButtonClicked;

        [SerializeField] protected Button BackgroundButton;

        protected virtual void OnBackgroundButton()
        {
            OnBackgroundButtonClicked?.Invoke();
            Close();
        }
    }
}
