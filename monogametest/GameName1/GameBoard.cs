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
    public class GameBoard : DrawableGameComponent
    {
        private Texture2D m_bkg;
        SpriteBatch spriteBatch;
        List<Square> m_squarelist;

        public GameBoard(Game game)
            : base(game)
        {
            spriteBatch = new SpriteBatch(game.GraphicsDevice);
            base.DrawOrder = (int)DisplayLayer.Background;
            m_squarelist = new List<Square>();
        }

        public override void Initialize()
        {
            Square tmp0 = new Square(98, 59, 167, 127);
            Square tmp1 = new Square(299, 64, 169, 129);
            Square tmp2 = new Square(493, 78, 194, 118);

            Square tmp3 = new Square(107, 223, 170, 121);
            Square tmp4 = new Square(306, 225, 159, 124);
            Square tmp5 = new Square(492, 226, 206, 126);

            Square tmp6 = new Square(109, 362, 168, 169);
            Square tmp7 = new Square(307, 380, 159, 155);
            Square tmp8 = new Square(502, 390, 194, 145);

            m_squarelist.Add(tmp0);
            m_squarelist.Add(tmp1);
            m_squarelist.Add(tmp2);

            m_squarelist.Add(tmp3);
            m_squarelist.Add(tmp4);
            m_squarelist.Add(tmp5);

            m_squarelist.Add(tmp6);
            m_squarelist.Add(tmp7);
            m_squarelist.Add(tmp8);

            base.Initialize();
        }
        protected override void LoadContent()
        {
            m_bkg = base.Game.Content.Load<Texture2D>("TS_bkg");
            base.LoadContent();
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(m_bkg, new Rectangle(0, 0, m_bkg.Width, m_bkg.Height), Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }

        public bool ValidPlacementOfMarker(Vector2 mouseInput, ref int index)
        {
            int x = (int)mouseInput.X;
            int y = (int)mouseInput.Y;

            Rectangle tmp = new Rectangle(x, y, 2, 2);

            foreach (Square s in m_squarelist)
            {
                if (tmp.Intersects(s.GetRect()))
                {
                    if (s.IsOccupied == false)
                        return !s.IsOccupied;
                }
            }
            return true;
        }

        public void SetPlacementOfMarker(int index, eGameState value)
        {
            m_squarelist[index].SquareValue = value;
        }

        public List<Square> GetSquares()
        {
            return m_squarelist;
        }
    }
}
