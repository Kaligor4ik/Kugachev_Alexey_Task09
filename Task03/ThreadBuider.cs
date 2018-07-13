using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task03
{
    class ThreadBuider
    {
        public List<ThreadStart> ThreadStrts { get; set; } = new List<ThreadStart>();
        public List<Thread> Threads { get; set; } = new List<Thread>();

        public void Build()
        {
            foreach (ThreadStart ts in ThreadStrts)
            {
                Threads.Add(new Thread(ts));
            }
        }

        public void StartAll()
        {
            foreach (Thread t in Threads)
            {
                t.Start();
            }
        }
    }
}
