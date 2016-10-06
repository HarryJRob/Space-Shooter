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
                
        public GameForm()
        {
            InitializeComponent();
            GameTick.Enabled = true;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void gameFrm_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            else
            {
                //Pass to PlayerShip
            }
        }

        private void gameFrm_keyUp(object sender, KeyEventArgs e) 
        {
            //Pass to PlayerShip
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



    }
}
