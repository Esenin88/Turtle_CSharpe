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
            GraphicsWindow.KeyDown += GraphicWindow_KeyDown;
            while (true)
            {
                Turtle.Move(10);
                
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
