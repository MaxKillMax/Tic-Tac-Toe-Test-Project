using System.Collections.Generic;

namespace TicTacToe
{
    public interface ITable
    {
        public IEnumerable<IPocket> GetPockets();
    }
}
