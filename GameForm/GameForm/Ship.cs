using System.Collections.Generic;
using System.Drawing;

namespace Game
{
    public class Ship
    {
        protected int health;
        protected Size shipSize = new Size (200,200);
        protected Point shipLocation = new Point(0,0);
        protected Image shipImage = Game.Properties.Resources.working;
        protected Image bulletImage = Game.Properties.Resources.Bullet;
        protected List<Bullet> BulletList = new List<Bullet> { };
        //protected int movementAngle;
        protected int velocity;
        protected int defaultVelocity;

        public virtual void FireBullet()
        {
            
        }

        public virtual void ActionCheck()
        {

        }

        public void DrawSelf(Graphics drawHandle)
        {
            try
            {
                drawHandle.DrawImage(shipImage, shipLocation.X, shipLocation.Y, shipSize.Width, shipSize.Height);
            }
            catch { }
        }
    }
}
