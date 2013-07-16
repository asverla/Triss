using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameName1
{
    class alex
    {
        public alex( TicTacToeGame _game )
        {
            _game.DrawGamestuff += _game_DrawGamestuff;
        }

        void _game_DrawGamestuff()
        {
        //    throw new NotImplementedException();
            drawMe();
        }

        public void drawMe()
        {

        }

    }
}
