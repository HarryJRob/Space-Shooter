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
        private bool currentFrame = true;

        public GEngine(Graphics g)
        {
            //Load an array of required assets and then ID them to draw a frame
            //Maybe custom class for frame which handles what needs to be drawn per frame
            drawHandle = g;
            renderThread = new Thread(new ThreadStart(render));
            renderThread.Start();
        }

        public void render()
        {
            while (true)
            {
                currentFrame = !currentFrame;
            }
        }

        public void RenderFrame()
        {

        }

        public void stopRender()
        {
            renderThread.Abort();
        }
    }
}
