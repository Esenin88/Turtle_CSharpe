﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace Turtlegame
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.PenUp();
            GraphicsWindow.KeyDown += GraphicWindow_KeyDown;
            GraphicsWindow.BrushColor = "Red";
            var eat = Shapes.AddRectangle(10, 10);
            int x = 200;
            int y = 200;
            Shapes.Move(eat, x, y);
            while (true)
            {
                Turtle.Move(10);
                if (Turtle.X == x && Turtle.Y == y)
                {
                    x = x + 50;
                    Shapes.Move(eat, x, y);
                }
  
            }

        }
        private static void GraphicWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }
            else if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }
            else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
        }
    }
}
