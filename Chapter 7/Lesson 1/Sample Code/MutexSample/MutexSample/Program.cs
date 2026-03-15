using System;
using System.Threading;

namespace MutexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Mutex mutex = new Mutex(false, "MutexDemo"))
            {
                //Checking if Other External Thread is Running
                Console.WriteLine("Starting Wait for mutex to be signalled");
                if (!mutex.WaitOne(5000, false))
                {
                    Console.WriteLine("An Instance of the Application is Already Running");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine("Application Is Running.......");
                Console.ReadKey();

                mutex.ReleaseMutex();
            }
        }
    }
}