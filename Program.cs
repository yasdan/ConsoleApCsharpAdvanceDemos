// See https://aka.ms/new-console-template for more information
using ConsoleApCsharpAdvanceDemos;

Console.WriteLine("Hello, World! Welcome to Advance C#.Net Topics");

DelegatesExample();

static void DelegatesExample()
{
    Console.WriteLine("Delegates Example");

    CalculateDelegate calculateDelegate; // declare a delegate variable

    // This is a simple example of using delegates in C#.
    DelegatesDemo delegatesDemo = new DelegatesDemo();

    calculateDelegate = delegatesDemo.Sum;
    // Using the delegate to call methods directly
    calculateDelegate(20, 30);
    calculateDelegate += delegatesDemo.Multiply;

    calculateDelegate(15, 10);
    // Removing a method from the delegate invocation list
    calculateDelegate -= delegatesDemo.Multiply;
    calculateDelegate(50, 25);
    // Invoking the delegate
    calculateDelegate.Invoke(5, 10);
    calculateDelegate += delegatesDemo.Divide;
    calculateDelegate(100, 20);

    // Using delegates with events
    delegatesDemo.Subscribe(message => Console.WriteLine($"Received message: {message}"));

    delegatesDemo.TriggerEvent("This is a test message after subscribing!");
    delegatesDemo.Unsubscribe(message => Console.WriteLine($"Received message: {message}"));
}

