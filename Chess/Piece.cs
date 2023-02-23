using System.Numerics;
using System.Xml;
using System;

public abstract class Piece
{
    public Vector2 position = new Vector2();

    public PieceColour pieceColour;
    
    public virtual void Draw(){}

    public virtual void ValidMoves(){}

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
