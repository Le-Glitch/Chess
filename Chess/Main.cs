using System;
using Raylib_cs;

public class Main
{
    Square[,] grid = new Square[8, 8];
    int squareNum = 0;

    public Main()
    {

        Setup();

        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                grid[i, j] = new Square(i * Raylib.GetScreenWidth() / 8, j * Raylib.GetScreenHeight() / 8);
                grid[i, j].row = i;
                grid[i, j].column = j;
            }
        }

        while(!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);

            Graphics();

            Raylib.EndDrawing();
        }
    }

    public void Setup()
    {
        
    }



    public void Graphics()
    {
        for (var i = 0; i < grid.GetLength(0); i++)
        {
            for (var j = 0; j < grid.GetLength(1); j++)
            {
                grid[i, j].Draw(i + j);
            }
        }
    }
}



public enum CheckSTatus
{
    WhiteInCheck,
    WhiteCheckmated,
    BlackInCheck,
    BlackCheckmated,
    None
}