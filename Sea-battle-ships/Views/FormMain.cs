using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//====
using Sea_battle_ships.Model;
using Sea_battle_ships.Controllers;


namespace Sea_battle_ships.Views

{
    public partial class FormMain : Form
    {
        #region Variables
        /// <summary>
        /// Размер ячейки моря
        /// </summary>
        private int size = 20;
        #endregion

        #region Constructors

        public FormMain()
        {
            InitializeComponent();
            //====
            CreateSea(SeaOwnPanel);  //добавляем море на виджет нашего поля
            CreateSea(SeaEnemyPanel);  //добавляем море на виджет вражеского поля

            Game.Init();
        }
        #endregion

        #region Events

        /// <summary>
        /// Событие клика по ячейке памяти
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cell_Click(object sender, EventArgs e)
        {
            //string message = string.Format("i:{0} j{1} ({2})",
            //                               (sender as Cell).i,
            //                               (sender as Cell).j,
            //                              (sender as Cell).Parent.Name);
            //MessageBox.Show(message);

            if ((sender as Cell).Parent.Name == "SeaOwnPanel")
            {
                if (Game.SeaOwn[(sender as Cell).i, (sender as Cell).j] == CellState.Empty)
                {
                    Game.SeaOwn[(sender as Cell).i, (sender as Cell).j] = CellState.Miss;
                    UpdateSea((sender as Cell).Parent as Panel);
                }
            }

        }

        #endregion

        #region Methods

        /// <summary>
        /// Метод создаёт массив ячеек игрового поля
        /// </summary>
        /// <param name="panel">Виджет, на который добавляется море</param>

        private void CreateSea(Panel panel)
        {
            char[] vertical = new char[10] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            char[] gorizontal = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Cell cell = new Cell(i, j)
                    {
                        Name=string.Format("{0}_{1}",i,j),
                        Left = size + i * size,
                        Top = size + j * size,
                        Width = size,
                        Height = size

                    };
                    cell.Click += Cell_Click;
                    panel.Controls.Add(cell);
                }
                //добаляем вертикальную строчку
                panel.Controls.Add(new Label()
                {
                    Left = 0,
                    Top = size + j * size,
                    Width = 20,
                    Height = 20,
                    Text = vertical[j].ToString(),
                    TextAlign = ContentAlignment.MiddleCenter




                });
                //добаляем горизонтальную строчку
                panel.Controls.Add(new Label()
                {
                    Left = size + j * size,
                    Top = 0,
                    Width = 20,
                    Height = 20,
                    Text = gorizontal[j].ToString(),
                    TextAlign = ContentAlignment.MiddleCenter
                });

            }
        }

        private void UpdateSea(Panel panel)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (panel.Name == "SeaOwnPanel")
                    {
                        switch (Game.SeaOwn[i, j])
                        {
                            case CellState.Empty:
                                break;
                            case CellState.Ship:
                                break;
                            case CellState.Miss:
                                panel.Controls.Find(string.Format("{0}_{1}", i, j), false)[0].Text = "0";
                                (panel.Controls.Find(string.Format("{0}_{1}", i, j), false)[0] as Cell).TextAlign = ContentAlignment.MiddleCenter;
                                ((panel.Controls.Find(string.Format("{0}_{1}", i, j), false)[0] as Cell).Parent as Panel).Select();
                                break;
                            case CellState.Hit:
                                break;

                        }

                    }

                }

            }

        }

        #endregion
    }

}
