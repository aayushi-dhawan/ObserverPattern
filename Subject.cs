using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class Subject : ISubject
    {
        int value = 0;
        public List<IObserver> observers = new List<IObserver>();
        public void RegisterUsers(IObserver o)
        {
            this.observers.Add(o);
            Console.WriteLine("Observer Added");
        }

        public void UnregisterUsers(IObserver o)
        {
            this.observers.Remove(o);   
            Console.WriteLine("Observer Removed");
        }

        public void NotifyUsers()
        {
            foreach (var o in this.observers)
            {
                o.Update();
            }
        }

        public void ModifyValue(int a)
        {
            this.value = a;
            Console.WriteLine("Value Changed, Inform all the Observers");
            NotifyUsers();
        }

    }
}