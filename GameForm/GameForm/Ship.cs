using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameForm
{
    class Ship
    {
        protected int health;
        protected Point shipLocation;
        protected List<Bullet> BulletLocation = new List<Bullet> { };
        protected string bulletImageName;
        protected int movementAngle;
        protected int velocity;
        protected int defaultVelocity;

        public virtual void fireBullet()
        {
            
        }
    }
}
