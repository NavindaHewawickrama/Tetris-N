
namespace Tetris
{
    class Position
    {
        public int Row { get; set; }

        public int Column { get; set; }

        public Position(int column, int row)
        {
            Row = row;
            Column = column;
        }
    }


}
