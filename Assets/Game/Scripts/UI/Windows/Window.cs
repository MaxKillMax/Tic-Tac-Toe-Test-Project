using UnityEngine;

namespace TicTacToe
{
    public class Window : MonoBehaviour
    {
        [SerializeField] private WindowState _startState;
        public WindowState State { get; private set; }

        public virtual void Initialize()
        {
            SetState(_startState);
        }

        public virtual void SetState(WindowState state)
        {
            if (state == WindowState.Opened)
                Open();
            else if (state == WindowState.Closed)
                Close();
        }

        public virtual void Open()
        {
            State = WindowState.Opened;
            gameObject.SetActive(true);
        }

        public virtual void Close()
        {
            State = WindowState.Closed;
            gameObject.SetActive(false);
        }
    }
}
