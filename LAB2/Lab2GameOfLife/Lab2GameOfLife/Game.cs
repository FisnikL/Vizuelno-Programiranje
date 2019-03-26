using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2GameOfLife
{
    abstract class Game
    {
        protected Grid grid;
        public int CurrentGeneration { get; set; }
        public int MaxGenerations { get; set; }
        public Game(int maxGenerations)
        {
            MaxGenerations = maxGenerations;
            CurrentGeneration = 0;
        }
        public void Evolve()
        {
            grid.Evolve();
            CurrentGeneration = CurrentGeneration + 1;
        }

        public virtual void Show()
        {
            Console.Clear();
            Console.WriteLine($"Current generation:{CurrentGeneration}");
            for(int i = 0; i < grid.Rows; ++i)
            {
                for(int j = 0; j < grid.Columns; ++j)
                {
                    Console.Write(grid.Cells[i][j]);
                }
                Console.WriteLine();
            }

        }
    }
}
