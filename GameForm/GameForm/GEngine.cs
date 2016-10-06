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
        private Bitmap DBFrame1;
        private Bitmap DBFrame2;
        private bool currentFrame;

        //public GEngine(Graphics g)
        //{
        //    drawHandle = g;
        //    renderThread = new Thread(new ThreadStart(render));
        //}

        public void render()
        {
            while (true)
            {
                drawHandle.FillRectangle(new SolidBrush(Color.Aqua), 0, 0, 20, 20);
            }
        }

        public void stopRender()
        {
            renderThread.Abort();
        }
    }
}
