using System.Xml;
using System;

public class Piece
{
    PieceColour pieceColour;
    PieceType pieceType;
    

    enum PieceType
    {
        Pawn,
        Bishop,
        Knight,
        Rook,
        Queen,
        King
    }
}

public enum PieceColour
{
    White,
    Black
}
