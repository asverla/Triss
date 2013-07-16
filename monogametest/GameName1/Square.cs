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
        Rectangle   squareXYWH;
        bool        m_occupied;
        public Square(int x, int y, int w, int h)
        {
            squareXYWH.X = x;
            squareXYWH.Y = y;
            squareXYWH.Width = w;
            squareXYWH.Height = h;
            m_occupied = false;
        }

        public void Init(int x, int y, int w, int h)
        {
           
        }
        public Rectangle GetRect()
        {
            return squareXYWH;
        }

        public bool IsOccupied()
        {
            return m_occupied;
        }
    }
}
