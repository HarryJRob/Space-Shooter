using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameForm
{
    class PlayerShip : Ship
    {
        private bool moveUp, moveLeft, moveRight, moveDown, shoot, boost;
        private int defaultBoostVelocity;
        private byte playerValue;

        public void LoadPlayerShip(byte playerNum) 
        {
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
                if (e.KeyCode == Keys.ShiftKey )
                {
                    boost = true;
                }
                if (e.KeyCode == Keys.Space)
                {
                    shoot = true;
                }
            }
        }

        public void keyDown(KeyEventArgs e)
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

        public void ActionCheck()
        {
            //May thread this to make it more efficient 
        }  
    }
}
