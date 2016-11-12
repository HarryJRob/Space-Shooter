using System.Drawing;

namespace Game
{
    public class Bullet
    {
        private Point _bulletLocation;
        private Size _BulletSize = new Size(20,20);
        private byte _bulletImageID;
        private byte _damage;
        private byte _specialProperties;

        public Point BulletLocation { get { return _bulletLocation; } }

        public Size BulletSize { get { return _BulletSize; } }
    }
}
