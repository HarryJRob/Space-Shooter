using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    public class Ship
    {
        protected int health;
        protected Size shipSize;
        protected Point shipLocation;
        protected byte shipImage;
        protected byte bulletImageName;
        //protected int movementAngle;
        protected int velocity;
        protected int defaultVelocity;

        public virtual void fireBullet()
        {
            
        }
    }
}
