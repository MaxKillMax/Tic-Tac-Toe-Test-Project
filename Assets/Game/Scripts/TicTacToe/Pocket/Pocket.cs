using UnityEngine;

namespace TicTacToe
{
    public class Pocket : MonoBehaviour, IPocket
    {
        public ISquare Square { get; private set; }

        public void SetSquare(ISquare square) => Square = square;

        public void RemoveSquare() => Square = default;
    }
}
