using System;
using Raylib_cs;

public class Grid
{
    Rectangle square;

    Color green = new Color(118, 150, 68, 255);
    Color beige = new Color(238, 238, 210, 255);

    public Grid(int x, int y)
    {
        square = new Rectangle(x, y, 100, 100);
    }

    public void Draw(int i)
    {
        if (i % 2 == 0)
        {
            Raylib.DrawRectangleRec(square, green);
        }
        else
        {
            Raylib.DrawRectangleRec(square, beige);
        }
    }
}