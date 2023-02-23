using System;
using Raylib_cs;

public class Queen : Piece
{
    Texture2D queenBlack = Raylib.LoadTexture("pieceImages/queen-black.png");
    Texture2D queenWhite = Raylib.LoadTexture("pieceImages/queen-white.png");

    public Queen(PieceColour colour)
    {
        pieceColour = colour;
    }

    public override void Draw()
    {
        if (pieceColour == PieceColour.White)
        {
            Raylib.DrawTexture(queenWhite, (int)position.X, (int)position.Y, Color.WHITE);
        }

        if (pieceColour == PieceColour.Black)
        {
            Raylib.DrawTexture(queenBlack, (int)position.X, (int)position.Y, Color.WHITE);
        }
    }
}
