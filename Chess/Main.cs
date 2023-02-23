using System.Numerics;
using System;
using Raylib_cs;

public class Main
{
    Square[,] grid = new Square[8, 8];

    Piece[,] blackPieces = new Piece[8, 2];
    Piece[,] whitePieces = new Piece[8, 2];

    CheckStatus checkStatus = CheckStatus.None;


    public Main()
    {

        Board board = new Board(grid, blackPieces, whitePieces);

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);

            Graphics();

            Raylib.EndDrawing();
        }
    }

    public void Graphics()
    {
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                grid[i, j].Draw(i + j);
            }
        }

        for (int i = 0; i < blackPieces.GetLength(0); i++)
        {
            for (int j = 0; j < blackPieces.GetLength(1); j++)
            {
                blackPieces[i,j].Draw();
            }
        }

        for (int i = 0; i < whitePieces.GetLength(0); i++)
        {
            for (int j = 0; j < whitePieces.GetLength(1); j++)
            {
                whitePieces[i, j].Draw();
            }
        }
    }
    
}

public enum CheckStatus
{
    WhiteInCheck,
    WhiteCheckmated,
    BlackInCheck,
    BlackCheckmated,
    None
}