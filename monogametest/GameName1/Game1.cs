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

namespace GameName1
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class TicTacToeGame : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        MouseState previousMouseState;

        Texture2D background;
        Rectangle mainFrame;
        GameBoard m_gameBoard;

        Rectangle _textureRectangle;



        static Texture2D _texture;

        public TicTacToeGame()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            m_gameBoard = new GameBoard(this);
            Components.Add(m_gameBoard);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            graphics.PreferredBackBufferHeight = 600;
            graphics.PreferredBackBufferWidth = 800;

            IsMouseVisible = true;

            graphics.IsFullScreen = false;

            mainFrame = new Rectangle(0, 0, 800, 600);



            previousMouseState = Mouse.GetState();

            graphics.ApplyChanges();

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {

            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            _texture = Content.Load<Texture2D>("TS_cross_marker");
            background = Content.Load<Texture2D>("TS_bkg");

            _textureRectangle = new Rectangle(0, 0, _texture.Width, _texture.Height);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            MouseState ms = Mouse.GetState();

            if (ms.LeftButton == ButtonState.Pressed)//|| ms.LeftButton == ButtonState.Released)
            {
                Vector2 _msClick = new Vector2(ms.X, ms.Y);

                _textureRectangle.X = ms.X - _texture.Width / 2;
                _textureRectangle.Y = ms.Y - _texture.Height / 2;

                // for debug only
                Console.WriteLine(_msClick.ToString());
            }

            previousMouseState = ms;

            // TODO: Add your update logic here
            //m_gameBoard.Update(gameTime);
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            //Draw background
            spriteBatch.Begin();
            spriteBatch.Draw(background, mainFrame, Color.White);
            spriteBatch.End();

            //Draw texture

            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, null, null, null, null);
            spriteBatch.Draw(_texture, _textureRectangle, Color.White);

            spriteBatch.End();

            // TODO: Add your drawing code here


            base.Draw(gameTime);
        }

        public void testdraw()
        {

        }

    }
}
