using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2GameOfLife
{
    class Grid
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Cell[][] Cells { get; set; }
        public Grid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Cells = new Cell[Rows][];
            for(int i = 0; i < rows; ++i)
            {
                Cells[i] = new Cell[Columns];
                for(int j = 0; j < Columns; ++j)
                {
                    Cells[i][j] = new Cell();
                }
            }
        }
        public void ToggleCell(int x, int y, bool isAlive)
        {
            Cells[x][y].IsAlive = isAlive;
        }
        public void Evolve()
        {
            
            for(int i = 0; i < Rows; ++i)
            {
                for(int j = 0; j < Columns; ++j)
                {
                    int X = i;
                    int Y = j;
                    int neighbours = 0;
                    
                    
                    if (X - 1 >= 0 && Cells[X - 1][Y].IsAlive) // TOP
                        neighbours++;
                    if (X - 1 >= 0 && Y + 1 < Columns && Cells[X - 1][Y + 1].IsAlive) // TOP RIGHT
                        neighbours++;
                    if (Y + 1 < Columns && Cells[X][Y + 1].IsAlive) // RIGHT
                        neighbours++;
                    if (X + 1 < Rows && Y + 1 < Columns && Cells[X + 1][Y + 1].IsAlive) // BOTTOM RIGHT
                        neighbours++;
                    if (X + 1 < Rows && Cells[X + 1][Y].IsAlive)  // BOTTOM
                        neighbours++;
                    if (X + 1 < Rows && Y - 1 >= 0 && Cells[X + 1][Y - 1].IsAlive)  // BOTTOM LEFT
                        neighbours++;
                    if ( Y - 1 >= 0 && Cells[X][Y - 1].IsAlive) // LEFT
                        neighbours++;
                    if (X - 1 >= 0 && Y - 1 >= 0 && Cells[X - 1][Y - 1].IsAlive)  // TOP LEFT
                        neighbours++;

                    // CONDITIONS
                    if (Cells[X][Y].IsAlive && neighbours < 2)
                        Cells[X][Y].ShouldLive = false;
                    else if (Cells[X][Y].IsAlive && neighbours >= 2 && neighbours <= 3)
                        Cells[X][Y].ShouldLive = true;
                    else if (Cells[X][Y].IsAlive && neighbours > 3)
                        Cells[X][Y].ShouldLive = false;
                    else if (!Cells[X][Y].IsAlive && neighbours == 3)
                        Cells[X][Y].ShouldLive = true;
                    else
                        Cells[X][Y].ShouldLive = false;

                }   
            }

            for(int i = 0; i < Rows; ++i)
            {
                for(int j = 0; j < Columns; ++j)
                {
                    if (Cells[i][j].ShouldLive)
                        Cells[i][j].IsAlive = true;
                    else
                        Cells[i][j].IsAlive = false;
                }
            }
        }
    }
}
