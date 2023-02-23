using System;
using Raylib_cs;

public class Rook : Piece
{
    Texture2D rookBlack = Raylib.LoadTexture("pieceImages/rook-black.png");
    Texture2D rookWhite = Raylib.LoadTexture("pieceImages/rook-white.png");

    public Rook(PieceColour colour)
    {
        pieceColour = colour;
    }


    public override void Draw()
    {
        if (pieceColour == PieceColour.White)
        {
            Raylib.DrawTexture(rookWhite, (int)position.X, (int)position.Y, Color.WHITE);
        }

        if (pieceColour == PieceColour.Black)
        {
            Raylib.DrawTexture(rookBlack, (int)position.X, (int)position.Y, Color.WHITE);
        }
    }
}
