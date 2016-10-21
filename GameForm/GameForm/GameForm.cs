using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class GameForm : Form
    {

        private GEngine GraphicsEngine;
        private CEngine CollisionEngine;
        public PlayerShip Player1;
        public PlayerShip Player2;

        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            bool twoPlayer = false;
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

            Graphics g = this.CreateGraphics();
            GraphicsEngine = new GEngine(g);
            GraphicsEngine.setWindowSize = this.ClientSize;
            CollisionEngine = new CEngine();
            CollisionEngine.SetgameWindowSize = this.ClientSize;
        }

        private void gameFrm_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            else
            {
                if (Player2 != null)
                {
                    Player1.keyDown(e);
                    Player2.keyDown(e);
                }
                else
                {
                    Player1.keyDown(e);
                }
            }
        }

        private void gameFrm_keyUp(object sender, KeyEventArgs e) 
        {
            if (Player2 != null)
            {
                Player1.keyUp(e);
                Player2.keyUp(e);
            }
            else
            {
                Player1.keyUp(e);
            }
        }
        
        private void GameTick_Tick(object sender, EventArgs e)
        {
            Player1.ActionCheck();
            
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GraphicsEngine.stopRender();
            CollisionEngine.stopCollision();
        }
        
    }
}
