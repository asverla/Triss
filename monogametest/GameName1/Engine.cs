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

    class Engine : GameComponent
    {
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

        private void GetClickedSquare(Vector2 click)
        {
            int row;
            int col;

            if (click.X < 266)
                col = 1;
            else if (click.X > 532)
                col = 3;
            else
                col = 2;

            if (click.Y < 200)
                row = 1;
            else if (click.Y > 400)
                row = 3;
            else
                row = 2;

            Console.WriteLine("Row: " + row);
            Console.WriteLine("Col: " + col);

        }
    }
}
