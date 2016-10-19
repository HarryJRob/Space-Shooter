using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace GameForm
{
    class PlayerShip : Ship
    {
        private bool moveUp, moveLeft, moveRight, moveDown, shoot, boost;
        private int defaultBoostVelocity = 10;
        private byte playerValue;
        private Image PlayerImage;
        public void LoadPlayerShip(byte playerNum, Image X) 
        {
            shipSize = new Size(100, 70);
            X.RotateFlip(RotateFlipType.Rotate90FlipNone);
            PlayerImage = new Bitmap(X, shipSize);
            shipLocation = new Point(0, 0);
            defaultVelocity = 5;
            velocity = defaultVelocity;
            playerValue = playerNum;
            if (playerValue == 1)
            {

            }
            else if (playerValue == 2)
            {

            }
            else if (playerValue == 3)
            {

            }
        }

        public override void fireBullet()
        {
            //Add bullet to bullet list
        }

        public void keyUp(KeyEventArgs e)
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

        public void keyDown(KeyEventArgs e)
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

        public void ActionCheck()
        {
            //May thread this to make it more efficient 
            if (boost)
            {
                if (velocity < defaultBoostVelocity) { velocity += 1; }
            }
            else if (velocity > defaultVelocity) { velocity -= 1; }
            if (moveUp) { shipLocation.Y -= velocity; }
            if (moveDown) { shipLocation.Y += velocity; }
            if (moveLeft) { shipLocation.X -= velocity; }
            if (moveRight) { shipLocation.X += velocity; }
        }

        public void Draw(Graphics drawHandle)
        {
            drawHandle.DrawImage(PlayerImage, shipLocation);
        }
    }
}
