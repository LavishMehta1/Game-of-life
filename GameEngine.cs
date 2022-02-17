using System;
using System.Drawing;

namespace Lab4GameOfLife
{
    class GameEngine
    {
        public int Height { get; private set; }
        public int Width { get; private set; }
        public int Ticks { get; set; }
        private Color[,] Grid { get; set; }

        public GameEngine(int h, int w)
        {

            if(h <= 0 || w <= 0)
                throw new ArgumentOutOfRangeException("Indices out of bounds");


            Height = h;
            Width = w;
            Ticks = 0;
            Grid = new Color[h, w];

            for (int j = 0; j < Height; j++)
            {
                 for (int i = 0; i < Width; i++)
                 {
                        Grid[j, i] = Color.FromArgb(0, 0, 0, 0); 
                 }
            }
        }

        public Color this[int y, int x]
        {
            get
            {
                if (IsOutOfBounds(y, x))
                    throw new ArgumentOutOfRangeException("Indices out of bounds");

                return Grid[y, x];
            
            }

            set 
            {
                if(IsOutOfBounds(y, x))
                    throw new ArgumentOutOfRangeException("Indices out of bounds");

                Grid[y, x] = value;
            }

        }
        private bool IsOutOfBounds(int y, int x) =>
            (y < 0 || y >= Height || x < 0 || x >= Width);

        private Color[,] CloneBoard()
        {
            Color[,] boardCopy = new Color[Height, Width];
 
            for (int j = 0; j < Height; j++)
            {
                for (int i= 0; i < Width; i++)
                {
                     boardCopy[j, i] =  Grid[j, i];
                }
            }

            return boardCopy;
        }

        public void Tick()
        {
            Color[,] boardCopy = CloneBoard();

            for (int j = 0; j < Height; j++)
            {
                for (int i = 0; i < Width; i++)
                {
                    boardCopy[j, i] = GetNextState(j, i);
                   
                }
            }

            Grid = boardCopy;
            Ticks++;
        }

        private Color GetNextState(int y, int x)
        {
            if (IsOutOfBounds(y, x))
                throw new ArgumentOutOfRangeException("Invalid Coordinates!!");


           int state = 0;
            int R = 0;
            int G = 0;
            int B = 0;

            for (int j = y - 1; j <= y + 1; j++)
                for (int i = x - 1; i <= x + 1; i++)
                    if (!IsOutOfBounds(j, i))
                    {
                        state = state + Grid[j, i].A;
                        R = R + Grid[j, i].R;
                        G = G + Grid[j, i].G;
                        B = B + Grid[j, i].B;
                    }
            state = state - Grid[y, x].A;
            R = R - Grid[y, x].R;
            G = G - Grid[y, x].G;
            B = B - Grid[y, x].B;

            switch (state)
            {
                case 510:
                    return Grid[y, x];
                case 765:
                    return Color.FromArgb(255, R/3, G/3, B/3);
                default:
                    return Color.FromArgb(0, 0, 0, 0); 
            }

        }
    }
}
