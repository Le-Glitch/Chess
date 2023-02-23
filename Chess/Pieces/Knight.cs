using System;
using Raylib_cs;

public class Knight : Piece
{
    Texture2D knightBlack = Raylib.LoadTexture("pieceImages/knight-black.png");
    Texture2D knightWhite = Raylib.LoadTexture("pieceImages/knight-white.png");


    public Knight(PieceColour colour)
    {
        pieceColour = colour;
    }

    public override void Draw()
    {
        if (pieceColour == PieceColour.White)
        {
            Raylib.DrawTexture(knightWhite, (int)position.X, (int)position.Y, Color.WHITE);
        }

        if (pieceColour == PieceColour.Black)
        {
            Raylib.DrawTexture(knightBlack, (int)position.X, (int)position.Y, Color.WHITE);
        }
    }
}
