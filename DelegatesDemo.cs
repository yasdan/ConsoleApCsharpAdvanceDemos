using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApCsharpAdvanceDemos
{
    // delegates are type-safe function pointers that can be used to
    // encapsulate a method with a specific signature.
    public delegate void Notify(string message);

    public delegate void CalculateDelegate(int x, int y);

    internal class DelegatesDemo
    {

        public void Sum(int x, int y)
        {
            Console.WriteLine($"Sum: {x + y}");
        }

        public void Multiply(int x, int y)
        {
            Console.WriteLine($"Product: {x * y}");
        }

        public void Divide(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return;
            }
            Console.WriteLine($"Division: {x / y}");
        }

        public void Subtract(int x, int y)
        {
            Console.WriteLine($"Difference is :{x - y}");

        }



        // Declare a delegate type Notify that takes a string parameter.
        public event Notify NotifyEvent;
        public void TriggerEvent(string message)
        {
            NotifyEvent?.Invoke(message);
           
        }

        // The NotifyEvent is an event of type Notify delegate.
        public void Subscribe(Notify handler)
        {
            NotifyEvent += handler;
        }
        public void Unsubscribe(Notify handler)
        {
            NotifyEvent -= handler;
            Console.WriteLine("Unsubscribed from the event.");
        }
    }
}
