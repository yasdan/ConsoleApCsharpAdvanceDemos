// See https://aka.ms/new-console-template for more information
using ConsoleApCsharpAdvanceDemos;

Console.WriteLine("Hello, World! Welcome to Advance C#.Net Topics");

//LinqDemo LinqDemo = new LinqDemo();

//LinqDemo.BasicLinqery();
//LinqDemo.UsingwhereLinq();
//LinqDemo.UsingOrderByLinq();
//LinqDemo.LinqOfTypeArraylist();
//LinqDemo.OrderByThenByLinq();
//LinqDemo.GroupByLinq();
//LinqDemo.TakeLinq();
//LinqDemo.LInqFirstorFirstDefault();
//LinqDemo.SingleorSingleDefault();

//JsonSerializationDemo();
//SynchronousGetnumbers();

AsyncGetNumbers();



//DictionaryDemoExample();
//TaineeStreamClassDemo();

//DelegatesExample();

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

static void TaineeStreamClassDemo()
{
    Trainee trainee = new Trainee();
    //Console.WriteLine("Enter File name with .txt extension");
    //string fileName = Console.ReadLine() ?? "trainees.txt";
    string fileName = "trainees.txt"; // Default file name

    Console.WriteLine("Enter Trainee Name:");
    trainee.Name = Console.ReadLine() ?? string.Empty;
    Console.WriteLine("Enter Trainee Id:");
    trainee.Id = Console.ReadLine() ?? string.Empty;
    Console.WriteLine("Enter Trainee Course:");
    trainee.Course = Console.ReadLine() ?? string.Empty;

    //trainee.DisplayInfo();
    trainee.AddTrainee(trainee, fileName);
    trainee.ReadTrainees(fileName);
}

static void DictionaryDemoExample()
{
    DictionaryDemo dictionaryDemo = new DictionaryDemo();

    dictionaryDemo.DictionaryDemoMethod();
}

static void JsonSerializationDemo()
{
    Trainee trainee = new Trainee();
    trainee.Id = "T010";
    trainee.Name = "John Mathew";
    trainee.Course = "C# Programming";
    trainee.JsonSerializeTrainee(trainee);
}

static void SynchronousGetnumbers()
{
    Console.WriteLine($"Start: {DateTime.Now.ToLongTimeString()}");
    var numbers = AsynchronousStreamsDemos.GetNumbers(1, 10);
    foreach (var number in numbers)
    {
        Console.WriteLine($"Number: {number}");
    }
    Console.WriteLine($"End: {DateTime.Now.ToLongTimeString()}");
}

static async void AsyncGetNumbers()
{
    //AsynchronousStreamsDemos asynchronousStreamsDemos = new AsynchronousStreamsDemos();
    Console.WriteLine($"Start: {DateTime.Now.ToLongTimeString()}");
    var numbersAsync = AsynchronousStreamsDemos.GetNumbersAsync(1, 11);
     await foreach (var number in numbersAsync)
    {
        Console.WriteLine(number);
    }
    Console.WriteLine($"End: {DateTime.Now.ToLongTimeString()}");
}