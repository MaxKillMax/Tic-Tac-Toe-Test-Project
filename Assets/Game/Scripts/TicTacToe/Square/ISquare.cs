using System;
using UnityEngine;

namespace TicTacToe
{
    public interface ISquare
    {
        public event Action<ISquare> OnSquareDown;

        public Transform Transform { get; }
    }
}
