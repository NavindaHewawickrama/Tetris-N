using System.Collections.Generic;

namespace Tetris
{
    public abstract class Block
    {
        protected abstract Position[][] Tiles { get; }
        protected abstract Position StartOffset { get; }

        public abstract int id { get; }

        private int rotationState;
        private Position offSet;

        public Block()
        {
            offSet = new Position(StartOffset.Row, StartOffset.Column);
        }

        public IEnumerable<Position> TilePositions()
        {
            foreach(Position p in Tiles[rotationState])
            {
                yield return new Position(p.Row + offSet.Row, p.Column + offSet.Column);
            }
        }

        public void RotateCW()
        {
            rotationState = (rotationState + 1) % Tiles.Length;
        }

        public void RotateCCW()
        {
            if(rotationState == 0)
            {
                rotationState = Tiles.Length - 1;
            }
            else
            {
                rotationState--;
            }
            
        }

        public void Move(int rows, int columns)
        {
            offSet.Row += rows;
            offSet.Column += columns;
        }

        public void Reset()
        {
            rotationState = 0;
            offSet.Row = StartOffset.Row;
            offSet.Column = StartOffset.Column;
        }

    }
}
