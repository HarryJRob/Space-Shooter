using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Game
{
    public class PlayerShip : Ship
    {
        private bool moveUp, moveLeft, moveRight, moveDown, shoot, boost;
        private bool collisionUp, collisionDown, collisionLeft, collisionRight;
        private const int defaultBoostVelocity = 10;
        private byte playerValue;

        public void LoadPlayerShip(byte playerNum)
        {
            shipLocation = new Point(0, 0);
            defaultVelocity = 5;
            velocity = defaultVelocity;
            shipSize = new Size(200, 200);

            playerValue = playerNum;
        }

        public override void FireBullet()
        {
            BulletList.Add(new Bullet());
            //Add bullet to bullet list
        }

        public void KeyUp(KeyEventArgs e)
        {
            if (playerValue == 1)
            {
                if (e.KeyCode == Keys.W)
                {
                    moveUp = false;
                }

                if (e.KeyCode == Keys.A)
                {
                    moveLeft = false;
                }

                if (e.KeyCode == Keys.D)
                {
                    moveRight = false;
                }

                if (e.KeyCode == Keys.S)
                {
                    moveDown = false;
                }
                if (e.KeyCode == Keys.ShiftKey)
                {
                    boost = false;
                }
                if (e.KeyCode == Keys.Space)
                {
                    shoot = false;
                }
            }
            else if (playerValue == 2)
            {
                if (e.KeyCode == Keys.Up)
                {
                    moveUp = false;
                }

                if (e.KeyCode == Keys.Left)
                {
                    moveLeft = false;
                }

                if (e.KeyCode == Keys.Right)
                {
                    moveRight = false;
                }

                if (e.KeyCode == Keys.Down)
                {
                    moveDown = false;
                }
                if (e.KeyCode == Keys.ControlKey)
                {
                    boost = false;
                }
                if (e.KeyCode == Keys.Enter )
                {
                    shoot = false;
                }
            }
            else if (playerValue == 3)
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    moveUp = false;
                }

                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    moveLeft = false;
                }

                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    moveRight = false;
                }

                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                {
                    moveDown = false;
                }
                if (e.KeyCode == Keys.ShiftKey)
                {
                    boost = false;
                }
                if (e.KeyCode == Keys.Space)
                {
                    shoot = false;
                }
            }
        }

        public void KeyDown(KeyEventArgs e)
        {
            if (playerValue == 1)
            {
                if (e.KeyCode == Keys.W)
                {
                    moveUp = true;
                }

                if (e.KeyCode == Keys.A)
                {
                    moveLeft = true;
                }

                if (e.KeyCode == Keys.D)
                {
                    moveRight = true;
                }

                if (e.KeyCode == Keys.S)
                {
                    moveDown = true;
                }
                if (e.KeyCode == Keys.ShiftKey)
                {
                    boost = true;
                }
                if (e.KeyCode == Keys.Space)
                {
                    shoot = true;
                }
            }
            else if (playerValue == 2)
            {
                if (e.KeyCode == Keys.Up)
                {
                    moveUp = true;
                }

                if (e.KeyCode == Keys.Left)
                {
                    moveLeft = true;
                }

                if (e.KeyCode == Keys.Right)
                {
                    moveRight = true;
                }

                if (e.KeyCode == Keys.Down)
                {
                    moveDown = true;
                }
                if (e.KeyCode == Keys.ControlKey) //Oddly doesnt worth with RShift and NumPad 0. Will Question
                {
                    boost = true;
                }
                if (e.KeyCode == Keys.Enter)
                {
                    shoot = true;
                }
            }
            else if (playerValue == 3)
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    moveUp = true;
                }

                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    moveLeft = true;
                }

                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    moveRight = true;
                }

                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                {
                    moveDown = true;
                }
                if (e.KeyCode == Keys.ShiftKey)
                {
                    boost = true;
                }
                if (e.KeyCode == Keys.Space)
                {
                    shoot = true;
                }
            }
        }

        public override void ActionCheck()
        {
            if (boost)
            {
                if (velocity < defaultBoostVelocity) { velocity += 1; }
            }
            else if (velocity > defaultVelocity) { velocity -= 1; }
            if (moveUp && collisionUp == false) { shipLocation.Y -= velocity; }
            if (moveDown && collisionDown == false) { shipLocation.Y += velocity; }
            if (moveLeft && collisionLeft == false) { shipLocation.X -= velocity; }
            if (moveRight && collisionRight == false) { shipLocation.X += velocity; }
            if (shoot) { FireBullet(); shoot = false; }
        }

        public void DrawBullets(Graphics drawHandle)
        {

            //Thread myThread = new Thread(new ParameterizedThreadStart(Test));
            foreach (Bullet B in BulletList)
            {
                drawHandle.DrawImage(bulletImage, B.BulletLocation.X, B.BulletLocation.Y, B.BulletSize.Width, B.BulletSize.Height);
            }
            //myThread.Start(drawHandle);
                
        }

        private void Test(object drawhandle)
        {
            Graphics g = (Graphics)drawhandle;
            foreach (Bullet B in BulletList)
            {
                try
                {


                    g.DrawImage(bulletImage, B.BulletLocation.X, B.BulletLocation.Y, B.BulletSize.Width, B.BulletSize.Height);
                }
                catch
                {
                    MessageBox.Show("1");
                }
            }
        }
    }
}
