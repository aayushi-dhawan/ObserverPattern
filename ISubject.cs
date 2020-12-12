namespace ObserverPattern
{
    public interface ISubject
    {
        void RegisterUsers(IObserver o);
        void UnregisterUsers(IObserver o);
        void NotifyUsers();
    }
}