using System;
using System.Collections.Generic;

namespace ObserverConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface IObserver
    {
        void Notify();
    }

    public abstract class Subject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Add(IObserver o)
        {
            observers.Add(o);
        }

        public void Notify()
        {
            observers.ForEach(o => o.Notify());
        }
    }

    public class Observable : IObservable<string>
    {
        public IDisposable Subscribe(IObserver<string> observer)
        {
            throw new NotImplementedException();
        }
    }

    class Observer : IObserver<string>
    {
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(string value)
        {
            throw new NotImplementedException();
        }
    }
}
