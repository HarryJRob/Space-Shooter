using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace Game
{
    class GEngine
    {
        private Graphics drawHandle;
        private Thread renderThread;
        private Size gameWindowSize;

        public GEngine(Graphics g)
        {
            //Load an array of required assets and then ID them to draw a frame
            //Maybe custom class for frame which handles what needs to be drawn per frame
            drawHandle = g;
            LoadAsset();
            renderThread = new Thread(new ThreadStart(render));
            renderThread.Start();
        }

        private void render()
        {
            int framesRendered = 0;
            long startTime = Environment.TickCount;
            while (true)
            {
                //Keep updating frame bitmap using frame graphics
                drawHandle.FillRectangle(new SolidBrush(Color.Aqua), 0, 0, gameWindowSize.Width, gameWindowSize.Height);

                //Benchmarking
                framesRendered++;
                if ((Environment.TickCount) >= startTime + 1000)
                {
                    Console.WriteLine("GEngine ----- FPS Counter: " + framesRendered);
                    framesRendered = 0;
                    startTime = Environment.TickCount;
                }
            }
        }

        public void stopRender()
        {
            renderThread.Abort();
        }

        public void LoadAsset()
        {

        }

        public Size setWindowSize
        {
            set { gameWindowSize = value; }
        }
    }
}
