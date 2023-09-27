using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Management.Instrumentation;
//using System.Timers;

namespace TaskDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            //Task mytask =
            //    new Task(() =>
            //    Console.WriteLine($"Doing some network call on thread {Thread.CurrentThread.ManagedThreadId}"));
            //mytask.Start();

            //Task<double> mytask = new Task<double>(DoWork);
            //mytask.Start();

            //mytask.ContinueWith((tsk) =>
            //{
            //    double result = tsk.Result;
            //    Console.WriteLine($"Result of Task<T> {result}");
            //});

            //Console.WriteLine("Counter value " + DoWork());


            // System.Timers.Timer timer = new System.Timers.Timer();
            //Stopwatch timer = new Stopwatch();
            //timer.Start();


            ////for (int i = 0; i < 10; i++)
            ////{
            ////    Console.WriteLine($"i value {i} and dowork() {DoWork()}");
            ////}
            //Parallel.For(0, 10, (i) =>
            //{
            //    Console.WriteLine($"i value {i} and dowork() in paralle {DoWork()} ");
            //});

            //timer.Stop();
            //Console.WriteLine($"It took {timer.Elapsed.Seconds}");


            CallDowork();

            Console.WriteLine("Main finished...");
            Console.ReadLine();
        }

        static async void CallDowork()
        {
            double result = await DoWorkAsync();
             Console.WriteLine($"Result using async and await {result}");
        }

        static Task<double> DoWorkAsync()
        {
            Task<double> task = new Task<double>(() =>
            {
                Console.WriteLine($"Dowork {Thread.CurrentThread.ManagedThreadId}");
                double val = 0;
                for (long i = 0; i < 100000000; i++)
                {
                    val += i;
                }
                return val;
            });

           task.Start();
            return task;
        }
        //static double DoWork()
        //{
        //    Console.WriteLine($"Dowork {Thread.CurrentThread.ManagedThreadId}");
        //    double val = 0;
        //    for (long i = 0; i < 100000000; i++)
        //    {
        //        val += i;
        //    }
        //    return val;
        //}



        //static void Task1()
        //{

        //    Console.WriteLine($"Doing some network call on thread {Thread.CurrentThread.ManagedThreadId}");
        //}
    }
}
