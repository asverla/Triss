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
    public enum eGameState { None, Player, Comp };

    class Engine : DrawableGameComponent
    {
        SpriteBatch _spriteBatch;

        public TicTacToeGame game { get; set; }
        public Engine(Game game)
            : base(game)
        {
            this.game = (TicTacToeGame)game;
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            if (game.GameState == eGameState.Comp)
            {
                //implement computer logic
                //getgameboard status and evaluate, set next move
            }
            else if (game.GameState == eGameState.Player)
            {
                MouseState ms = Mouse.GetState();

                if (ms.LeftButton == ButtonState.Pressed)//|| ms.LeftButton == ButtonState.Released)
                {
                    GetClickedSquare(new Vector2(ms.X, ms.Y));
                    game.GameState = eGameState.Comp;

                    //_textureRectangle.X = ms.X - _texture.Width / 2;
                    //_textureRectangle.Y = ms.Y - _texture.Height / 2;

                    // for debug only
                    //   Console.WriteLine(_msClick.ToString());

                }
            }
            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            //_spriteBatch.DrawString(Sp, "test", new Vector2(), Color.Red);

            base.Draw(gameTime);
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            base.LoadContent();
        }


        private void GetClickedSquare(Vector2 click)
        {
            int index = -1;

            if (game.m_gameBoard.ValidPlacementOfMarker(click, ref index))
                game.m_gameBoard.SetPlacementOfMarker(index, game.GameState);
        }
    }
}
