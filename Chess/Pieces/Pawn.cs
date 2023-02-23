using System;
using Raylib_cs;

public class Pawn : Piece
{
    Texture2D pawnBlack = Raylib.LoadTexture("pieceImages/pawn-black.png");
    Texture2D pawnWhite = Raylib.LoadTexture("pieceImages/pawn-white.png");

    public Pawn(PieceColour colour)
    {
        pieceColour = colour;
    }

    public override void Draw()
    {
        if (pieceColour == PieceColour.White)
        {
            Raylib.DrawTexture(pawnWhite, (int)position.X, (int)position.Y, Color.WHITE);
        }

        if (pieceColour == PieceColour.Black)
        {
            Raylib.DrawTexture(pawnBlack, (int)position.X, (int)position.Y, Color.WHITE);
        }
    }
}
