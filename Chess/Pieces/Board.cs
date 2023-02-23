using System.Numerics;
using System;
using Raylib_cs;

public class Board
{
    Vector2 position = new Vector2();

    public Board(Square[,] grid, Piece[,] blackPieces, Piece[,] whitePieces)
    {
        
        for (int y = 0; y < grid.GetLength(0); y++)
        {
            for (int x = 0; x < grid.GetLength(1); x++)
            {
                position.X = x * Raylib.GetScreenWidth() / 8;
                position.Y = y * Raylib.GetScreenHeight() / 8;

                grid[x, y] = new Square((int)position.X, (int)position.Y);
                grid[x, y].row = x;
                grid[x, y].column = y;

                if (y == 1)
                {
                    blackPieces[x, 1] = new Pawn(PieceColour.Black);
                    blackPieces[x, 1].position = new Vector2((int)position.X, (int)position.Y);
                }

                if (y == 6)
                {
                    whitePieces[x, 1] = new Pawn(PieceColour.White);
                    whitePieces[x, 1].position = new Vector2((int)position.X, (int)position.Y);
                }

                if (y == 0)
                {
                    BlackSetup(position, x, y, blackPieces);
                }

                if (y == 7)
                {
                    WhiteSetup(position, x, y, whitePieces);
                }
            }
        }
    }

    public void BlackSetup(Vector2 position, int x, int y, Piece[,] blackPieces)
    {
        if (x == 0 || x == 7)
        {
            blackPieces[x, 0] = new Rook(PieceColour.Black);
            blackPieces[x, 0].position = new Vector2((int)position.X, (int)position.Y);
        }

        if (x == 1 || x == 6)
        {
            blackPieces[x, 0] = new Knight(PieceColour.Black);
            blackPieces[x, 0].position = new Vector2((int)position.X, (int)position.Y);
        }

        if (x == 2 || x == 5)
        {
            blackPieces[x, 0] = new Bishop(PieceColour.Black);
            blackPieces[x, 0].position = new Vector2((int)position.X, (int)position.Y);
        }

        if (x == 3)
        {
            blackPieces[x, 0] = new Queen(PieceColour.Black);
            blackPieces[x, 0].position = new Vector2((int)position.X, (int)position.Y);
        }

        if (x == 4)
        {
            blackPieces[x, 0] = new King(PieceColour.Black);
            blackPieces[x, 0].position = new Vector2((int)position.X, (int)position.Y);
        }
    }

    public void WhiteSetup(Vector2 position, int x, int y, Piece[,] whitePieces)
    {
        if (x == 0 || x == 7)
        {
            whitePieces[x, 0] = new Rook(PieceColour.White);
            whitePieces[x, 0].position = new Vector2((int)position.X, (int)position.Y);
        }

        if (x == 1 || x == 6)
        {
            whitePieces[x, 0] = new Knight(PieceColour.White);
            whitePieces[x, 0].position = new Vector2((int)position.X, (int)position.Y);
        }

        if (x == 2 || x == 5)
        {
            whitePieces[x, 0] = new Bishop(PieceColour.White);
            whitePieces[x, 0].position = new Vector2((int)position.X, (int)position.Y);
        }

        if (x == 3)
        {
            whitePieces[x, 0] = new Queen(PieceColour.White);
            whitePieces[x, 0].position = new Vector2((int)position.X, (int)position.Y);
        }

        if (x == 4)
        {
            whitePieces[x, 0] = new King(PieceColour.White);
            whitePieces[x, 0].position = new Vector2((int)position.X, (int)position.Y);
        }
    }
}
