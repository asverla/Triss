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
        }

        public override void Initialize()
        {

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
            spriteBatch.Draw(m_bkg,new Rectangle(0,0,m_bkg.Width,m_bkg.Height),Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }

        public void HandleMouseInput(int row, int col)
        {
           
        }
    }
}
