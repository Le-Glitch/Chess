using System;
using Raylib_cs;


public class Bishop : Piece
{
    Texture2D bishopBlack = Raylib.LoadTexture("pieceImages/bishop-black.png");
    Texture2D bishopWhite = Raylib.LoadTexture("pieceImages/bishop-white.png");

    public Bishop(PieceColour colour)
    {
        pieceColour = colour;
    }

    public override void Draw()
    {
        if (pieceColour == PieceColour.White)
        {
            Raylib.DrawTexture(bishopWhite, (int)position.X, (int)position.Y, Color.WHITE);
        }

        if (pieceColour == PieceColour.Black)
        {
            Raylib.DrawTexture(bishopBlack, (int)position.X, (int)position.Y, Color.WHITE);
        }
    }
}
