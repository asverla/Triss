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
        public GameBoard GameBoard { get; set; }

        public TicTacToeGame game { get; set; }
        public Engine(Game game)
            : base(game)
        {
            this.game = (TicTacToeGame)game;
            this.GameBoard = this.game.m_gameBoard;
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
                EvalComp();

            }
            else if (game.GameState == eGameState.Player)
            {
                MouseState ms = Mouse.GetState();

                if (ms.LeftButton == ButtonState.Pressed)//|| ms.LeftButton == ButtonState.Released)
                {
                    if (EvalClick(new Vector2(ms.X, ms.Y)))
                        game.GameState = eGameState.Comp;
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


        private bool EvalClick(Vector2 click)
        {
            int index = -1;

            if (GameBoard.ValidPlacementOfMarker(click, ref index))
            {
                GameBoard.SetPlacementOfMarker(index, game.GameState);
                return true;
            }

            return false;
        }

        private void EvalComp()
        {
            List<Square> _squares = GameBoard.GetSquares();

            foreach (var s in _squares)
            {
                if (s.IsOccupied == false)
                {
                    GameBoard.SetPlacementOfMarker(_squares.IndexOf(s), eGameState.Comp);
                    game.GameState = eGameState.Player;

                    return;
                }
            }
        }
    }
}
