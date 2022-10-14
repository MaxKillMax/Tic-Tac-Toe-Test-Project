using System.Linq;
using UnityEngine;

namespace TicTacToe
{
    public sealed class UI : Singleton<UI>
    {
        [SerializeField] private Window[] _windows;

        protected override void Awake()
        {
            base.Awake();

            foreach (Window window in _windows)
                window.Initialize();
        }

        public static T Get<T>() where T : Window => Instance._windows.OfType<T>().FirstOrDefault();
    }
}
