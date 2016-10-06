using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;

namespace GameForm
{
    class GEngine
    {
        private Graphics drawHandle;
        private Thread renderThread;
        private Bitmap DBFrame1 = new Bitmap(Image.FromFile(@"N:\test.png"));
        private Bitmap DBFrame2 = new Bitmap(Image.FromFile(@"N:\test.png"));
        private bool currentFrame;

        public GEngine(Graphics g)
        {
            drawHandle = g;
            renderThread = new Thread(new ThreadStart(render));
            renderThread.Start();
        }

        public void render()
        {
                if (currentFrame)
                {
                    drawHandle.DrawLine(Pens.Blue, new Point(0, 0), new Point(50, 50));
                }
                else
                {
                    drawHandle.DrawImage(DBFrame2, new Point(50, 50));
                }
                currentFrame = !currentFrame;
        }

        public void stopRender()
        {
            renderThread.Abort();
        }
    }
}
