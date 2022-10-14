using System;
using UnityEngine;

namespace TicTacToe
{
    public class Square : MonoBehaviour, ISquare
    {
        public event Action<ISquare> OnSquareDown;

        public Transform Transform => transform;

        private void OnMouseDown()
        {
            OnSquareDown?.Invoke(this);
        }
    }
}
