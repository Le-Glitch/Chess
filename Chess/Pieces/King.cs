using System;
using Raylib_cs;

public class King : Piece
{
    Texture2D kingBlack = Raylib.LoadTexture("pieceImages/king-black.png");
    Texture2D kingWhite = Raylib.LoadTexture("pieceImages/king-white.png");

    public King(PieceColour colour)
    {
        pieceColour = colour;
    }

    public override void Draw()
    {
        if (pieceColour == PieceColour.White)
        {
            Raylib.DrawTexture(kingWhite, (int)position.X, (int)position.Y, Color.WHITE);
        }

        if (pieceColour == PieceColour.Black)
        {
            Raylib.DrawTexture(kingBlack, (int)position.X, (int)position.Y, Color.WHITE);
        }
    }
}
