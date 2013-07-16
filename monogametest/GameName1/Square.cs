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
        public Square()
        {
            squareXYWH.X = 0;
            squareXYWH.Y = 0;
            squareXYWH.Width = 0;
            squareXYWH.Height = 0;
            m_occupied = false;
        }

        public void Init(int x, int y, int w, int h)
        {
            squareXYWH.X = x;
            squareXYWH.Y = y;
            squareXYWH.Width = w;
            squareXYWH.Height = h;
        }
    
    }
}
