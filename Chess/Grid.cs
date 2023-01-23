using System;
using Raylib_cs;

public class Grid
{
    Rectangle square;


    public Grid(int x, int y)
    {
        square = new Rectangle(x, y, 100, 100);
    }

    public void Draw(int i)
    {
        if (i%2 == 0)
        {
            Raylib.DrawRectangleRec(square, Color.GREEN);
        }
        else
        {
            Raylib.DrawRectangleRec(square, Color.BEIGE);
        }
    }
}