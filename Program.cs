using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
          Subject s = new Subject();
          IObserver oBuyer = new Buyer("Jon");
          IObserver oBuyer1 = new Buyer("Bob");
          IObserver oseller = new Seller("ICloud");

          s.RegisterUsers(oBuyer);
          s.RegisterUsers(oBuyer1);
          s.RegisterUsers(oseller);

          s.ModifyValue(5);

          s.UnregisterUsers(oseller);
          s.ModifyValue(10);
        }
    }
}
