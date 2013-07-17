#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion


namespace TicTacToe
{
    public class Square
    {
        Rectangle squareXYWH;
        public eGameState SquareValue { get; set; }
        public bool IsOccupied { get { return SquareValue == eGameState.None ? false : true; } }

        public Square(int x, int y, int w, int h)
        {
            squareXYWH.X = x;
            squareXYWH.Y = y;
            squareXYWH.Width = w;
            squareXYWH.Height = h;
            SquareValue = eGameState.None;
        }

        public void Init(int x, int y, int w, int h)
        {

        }
        public Rectangle GetRect()
        {
            return squareXYWH;
        }
        
    }
}
