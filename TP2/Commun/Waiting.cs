using System;
using System.Threading;

namespace TP2.Commun
{
    public static class Waiting
    {
        public static void WaitMilliseconds(int milliseconds)
        {
            if (milliseconds < 1) return;
            DateTime desired = DateTime.Now.AddMilliseconds(milliseconds);
            while (DateTime.Now < desired)
            {
                Thread.Sleep(1);
                System.Windows.Forms.Application.DoEvents();
            }
        }
    }
}
