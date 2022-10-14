namespace TicTacToe
{
    public class TicTacToeCommand : ICommand
    {
        protected ISquare Square { get; private set; }

        public TicTacToeCommand(ISquare square)
        {
            Square = square;
        }

        public void Execute()
        {
            
        }
    }
}
