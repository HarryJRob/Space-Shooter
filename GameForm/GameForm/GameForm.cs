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
        
        public GameForm()
        {
            InitializeComponent();
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

        }

        private void canvasPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Green, 10, 10, 200, 150);
            GraphicsEngine = new GEngine();
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
