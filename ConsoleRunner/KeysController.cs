using System;
using System.Threading;

namespace ConsoleRunner
{
    public class KeysController
    {
        public delegate void Handler(ConsoleKey key);
        public event Handler Space;

        public void Listen()
        {            
            Space?.Invoke(Console.ReadKey(true).Key);
            Listen();
        }
    }
}
