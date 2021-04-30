using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var list = new ConcurrentBag<int>();
            var factory = new TaskFactory(); // (TaskCreationOptions.None, TaskContinuationOptions.OnlyOnRanToCompletion);
            const int n = 100;
            Task[] tasks = new Task[n];
            for (int i = 0; i < n; i++)
            {
                tasks[i] = factory.StartNew((j) => AddToList2((int)j, list), state: i);
            }

            await Task.WhenAll(tasks);

            Console.WriteLine(list.Count);

            foreach (var i in list)
            {
                Console.Write($"{i},");
            }

            await Task.Delay(3000);

        }

        private static void AddToList(int i, List<int> list)
        {
            list.Add(i);
        }
        private static async void AddToList2(int i, ConcurrentBag<int> list)
        {
            list.Add(i);
            await Task.Delay(4);
        }
    }
}
