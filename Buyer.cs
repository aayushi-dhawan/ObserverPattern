using System;

namespace ObserverPattern
{
    public class Buyer : IObserver
    {
        string Name;
        public Buyer(string name)
        {
            this.Name = name;
        }
        public void Update()
        {
            Console.WriteLine("Buyer {0} Updated", this.Name);
        }
    }
}