using System;

namespace ObserverPattern
{
    public class Seller: IObserver
    {
        string Name;
        public Seller(string name)
        {
            this.Name = name;
        }

        public void Update()
        {
            Console.WriteLine("Seller {0} Updated", this.Name);
        }
    }
}