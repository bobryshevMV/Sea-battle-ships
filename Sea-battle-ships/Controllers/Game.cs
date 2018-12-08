using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//====
using Sea_battle_ships.Model;
using Sea_battle_ships.Controllers;

namespace Sea_battle_ships.Controllers
{
    public static class Game
    {
        #region Variables

        /// <summary>
        /// Наше море
        /// </summary>
        public static CellState[,] SeaOwn = new CellState[10, 10];

        /// <summary>
        /// Вражеское море
        /// </summary>
        public static CellState[,] SeaEnemy = new CellState[10, 10];

        #endregion

        #region InterFace API
        /// <summary>
        /// Инициализация игровых морей
        /// </summary>
        public static void Init()
        {
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    SeaOwn[i, j] = CellState.Empty;
                    SeaEnemy[i, j] = CellState.Empty;
                }
            }
        }



        #endregion
    }
}
