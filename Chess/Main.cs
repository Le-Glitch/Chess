using System;
using Raylib_cs;

public class Main
{
    Grid[,] grid = new Grid[8, 8];
    int squareNum = 0;

    public Main()
    {

        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                grid[i, j] = new Grid(i * Raylib.GetScreenWidth() / 8, j * Raylib.GetScreenHeight() / 8);
            }
        }

        while(!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.GREEN);

            for (var i = 0; i < grid.GetLength(0); i++)
            {
                for (var j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j].Draw(i + j);
                }
            }

            Raylib.EndDrawing();
        }
    }
}
