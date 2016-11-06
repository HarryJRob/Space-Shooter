using System.Collections.Generic;
using System.Drawing;

namespace Game
{
    public class Ship
    {
        protected int health;
        protected Size shipSize;
        protected Point shipLocation;
        protected Image shipImage;
        protected List<Bullet> BulletList = new List<Bullet> { };
        //protected int movementAngle;
        protected int velocity;
        protected int defaultVelocity;

        public virtual void FireBullet()
        {
            
        }

        public void DrawSelf(Graphics drawHandle)
        {
            drawHandle.DrawImage(shipImage,shipLocation.X,shipLocation.Y,shipSize.Width,shipSize.Height);
        }
    }
}
