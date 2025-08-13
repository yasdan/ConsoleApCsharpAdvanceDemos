using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApCsharpAdvanceDemos
{
    internal class AsynchronousStreamsDemos
    {
       
            public static IEnumerable<int> GetNumbers(int start, int end)
            {
                var random = new Random();
                var returnList = new List<int>();

                for (int i = start; i < end; i++)
                {
                    returnList.Add(i);
                    Thread.Sleep(millisecondsTimeout: random.Next(500, 1500));
                }

                return returnList;
            }

        public static async IAsyncEnumerable<int> GetNumbersAsync(int start, int end)
        {
            var returnList = new List<int>();
            for (int i = start; i < end; i++)
            {
                returnList.Add(i);
                Console.WriteLine($"Yielding number: {i}");
                await Task.Delay(400);
                yield return i; // This will yield the number asynchronously
            }
           // return returnList;
        }
       
    }
    }


