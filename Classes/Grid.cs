
namespace Minesweeper.Classes
{
    internal class Grid
    {
        private int[,] _gridArray;
        private int _height;
        private int _width;

        public Grid( int height, int width)
        {
            _height = height;
            _width = width;
            _gridArray = new int[width, height];

            for (int x = 0; x < _gridArray.GetLength(0); x++)
            {
                for (int y = 0; y < _gridArray.GetLength(1); y++)
                {
                    _gridArray[x, y] = 0;
                }
            }

            SetValue(0, 1, 10);
        }

        private void DrawGrid()
        {
            Console.Clear();

            // 
        }

        public int GetGridPosition(GridPosition gridPosition)
        {
            return _gridArray[gridPosition.X, gridPosition.Y];
        }

        public void SetValue(int x, int y,  int value)
        {
            if(x >= 0 && y >= 0 && x < _width && y < _height)
                _gridArray[x, y] = value;
        }
    }

    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public struct GridPosition
    {
        public int X { get; set; }
        public int Y { get; set; }

        public GridPosition(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
