using System.Xml;
using System;

public class Piece
{
    PieceColour pieceColour;



    enum PieceType
    {
        Pawn,
        Bishop,
        Knight,
        Rook,
        Queen,
        King
    }

    public Square[] validMoves()
    {
        

        return null;
    }
}

public enum PieceColour
{
    White,
    Black
}
