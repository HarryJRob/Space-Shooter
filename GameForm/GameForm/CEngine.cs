using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace GameForm
{
    class CEngine
    {
        private Thread collisionThread;
        private Size gameWindowSize;

        public CEngine() {
            collisionThread = new Thread(new ThreadStart(CCheck));
            collisionThread.Start();
        }

        private void CCheck()
        {
            int framesRendered = 0;
            long startTime = Environment.TickCount;
            int x = 0;
            while (true)
            {

                x += 1;
                framesRendered++;
                if ((Environment.TickCount) >= startTime + 1000)
                {
                    Console.WriteLine("CEngine ----- FPS Counter: " + framesRendered);
                    framesRendered = 0;
                    startTime = Environment.TickCount;
                }
            }
        }

        public void stopCollision()
        {
            collisionThread.Abort();
        }

        public Size SetgameWindowSize
        {
            set {gameWindowSize = value;}
        }
    }
}
