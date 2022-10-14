using System.Collections.Generic;
using UnityEngine;

namespace TicTacToe
{
    public class Table : MonoBehaviour, ITable
    {
        [SerializeField] private Pocket[] _pockets;

        public IEnumerable<IPocket> GetPockets() => _pockets;
    }
}
