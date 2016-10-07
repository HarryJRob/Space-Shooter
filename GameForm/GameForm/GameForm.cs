using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameForm
{
    public partial class GameForm : Form
    {
        private GEngine GraphicsEngine;
        private PlayerShip Player1;
        private PlayerShip Player2;
        private bool twoPlayer;
                
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            twoPlayer = false; //Will be passed from menu form as it closes

            if (twoPlayer)
            {
                Player1 = new PlayerShip();
                Player2 = new PlayerShip();
                Player1.LoadPlayerShip(1);
                Player2.LoadPlayerShip(2);
            }
            else
            {
                Player1 = new PlayerShip();
                Player1.LoadPlayerShip(3);
                Player2 = null;
            }
            GameTick.Enabled = true;
        }

        private void gameFrm_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            else
            {
                if (twoPlayer)
                {
                    Player1.keyDown(e, 1);
                    Player2.keyDown(e, 2);
                }
                else
                {
                    Player1.keyDown(e, 3);
                }
            }
        }

        private void gameFrm_keyUp(object sender, KeyEventArgs e) 
        {
            if (twoPlayer)
            {
                Player1.keyUp(e, 1);
                Player2.keyUp(e, 2);
            }
            else
            {
                Player1.keyUp(e, 3);
            }
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            GraphicsEngine = new GEngine(g);
        }

        private void GameTick_Tick(object sender, EventArgs e)
        {
            /*
             * Move some stuff
             * Check for collisions
             * Update UI if collision
             * Draw current frame
             */
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GraphicsEngine.stopRender();
        }
    }
}
