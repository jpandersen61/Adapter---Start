using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class PizzaOven : IObservable
    {
        Random random = new Random();
        List<IObserver> _observers = new List<IObserver>();
        private void NotifyObservers(AbstractPizza pizza)
        {
            /*
                 Send notification to all observers 
            */

            foreach (var observer in _observers)
            {
                observer.Notify(pizza);
            }
        }

        public void AddObserver(IObserver observer)
        {
            /*
                 Keep track of all overservers 
            */

            _observers.Add(observer);
        }

        public void preparePizza(AbstractPizza p)
        {

            //Prepare the pizza
            Task.Factory.StartNew(() =>
            {
                //It will take some time
                int preparetime = random.Next(5, 15);
                System.Threading.Thread.Sleep(preparetime * 100);
                
                //Notify all observers
                NotifyObservers(p);
            });
        }


    }
}
