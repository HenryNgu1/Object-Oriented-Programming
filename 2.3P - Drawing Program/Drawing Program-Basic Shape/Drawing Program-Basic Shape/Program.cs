﻿using Drawing_Program_Basic_Shape;
using SplashKitSDK;
using System;

namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            Window window  = new Window("Shape Drawer", 800, 600);
            Shape myShape = new Shape();

            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    myShape.X = SplashKit.MouseX();
                    myShape.Y = SplashKit.MouseY();
                }

                if(myShape.IsAt(SplashKit.MousePosition()) && (SplashKit.KeyTyped(KeyCode.SpaceKey)))
                {
                    myShape.Color = Color.RandomRGB(255);
                }

                myShape.Draw();
                SplashKit.RefreshScreen();
            }

            while (!window.CloseRequested);
        }
    }
}
