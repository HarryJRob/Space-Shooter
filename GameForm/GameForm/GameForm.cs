using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
namespace Game
{
    public partial class GameForm : Form
    {

        private PlayerShip Player1;
        private PlayerShip Player2;
        private Graphics DrawHandle;
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            bool twoPlayer = false;
            DrawHandle = this.CreateGraphics();
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
            Render.Enabled = true;
            Collision.Enabled = true;
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
                    Player1.KeyDown(e);
                    Player2.KeyDown(e);
                }
                else
                {
                    Player1.KeyDown(e);
                }
            }
        }

        private void gameFrm_keyUp(object sender, KeyEventArgs e) 
        {
            if (Player2 != null)
            {
                Player1.KeyUp(e);
                Player2.KeyUp(e);
            }
            else
            {
                Player1.KeyUp(e);
            }
        }
        
        private void GameTick_Tick(object sender, EventArgs e)
        {
            Player1.ActionCheck();
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GameTick.Enabled = false;
            Render.Enabled = false;
            Collision.Enabled = false;
        }

        private void Collision_Tick(object sender, EventArgs e)
        {

        }

        private void Render_Tick(object sender, EventArgs e)
        {
            Player1.DrawSelf(DrawHandle);
            if (Player2 != null)
            {
                Player2.DrawSelf(DrawHandle);
                Player2.DrawBullets(DrawHandle);
            }
        }
        
    }
}
