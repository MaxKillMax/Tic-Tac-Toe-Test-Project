namespace TicTacToe
{
    public interface IPocket
    {
        public ISquare Square { get; }

        public void SetSquare(ISquare square);

        public void RemoveSquare();
    }
}
