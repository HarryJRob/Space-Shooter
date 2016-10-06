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
        protected List<Point> BulletLocation = new List<Point> { };
        protected string bulletImageName;
        protected int movementAngle;
        protected int velocity;
        protected int defaultVelocity;

        protected virtual void fireBullet()
        {

        }
    }
}
