using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace GameForm
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
            renderThread = new Thread(new ThreadStart(render));
            renderThread.Start();
            
            
        }

        private void render()
        {
            int framesRendered = 0;
            long startTime = Environment.TickCount;
            int x = 0, y = 0;
            while (true)
            {
                x += 1;
                y += 1;
                //Keep updating frame bitmap using frame graphics
                drawHandle.FillRectangle(new SolidBrush(Color.Red), 0, 0, (gameWindowSize.Width / 20 + x), (gameWindowSize.Height / 20) + y);
                
                

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

        public Size SetgameWindowSize
        {
            set {gameWindowSize = value;}
        }
    }
}
