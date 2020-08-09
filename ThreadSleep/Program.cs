using System.Threading;
using System;
using System.Net;

namespace ThreadSleep
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 1;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(num);
            //    Thread.Sleep(1000);
            //    num++;
            //}

            BankAccount acct = new BankAccount(10);
            Thread[] threads = new Thread[15];

            Thread.CurrentThread.Name = "main";

            for (int i = 0; i < 15; i++)
            {
                Thread t = new Thread(new ThreadStart(acct.IssueWithDraw));
                t.Name = i.ToString();
                threads[i] = t;               
            }
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Threads {0} Alive : {1} ", threads[i].Name, threads[i].IsAlive);

                threads[i].Start();

                Console.WriteLine("Threads {0} Alive : {1} ", threads[i].Name, threads[i].IsAlive);
            }
            Console.WriteLine("Current priority", Thread.CurrentThread.Priority);
            Console.WriteLine("Thread {0} Ending");
            Console.ReadLine();
        }
    }

    class BankAccount
    {
        private Object acctLock = new object();
        double Balance;
        public BankAccount(double balance)
        {
            Balance = balance;
        }

        public double WithDraw(double ammount)
        {
            if ((Balance - ammount) < 0 )
            {
                return Balance;
            }

            lock (acctLock)
            {
                if (Balance >= ammount)
                {
                    Console.WriteLine("Removed {0} and {1} lefit in Account"
                        , ammount, (Balance - ammount));

                    Balance -= ammount;
                }

                return Balance;
            }
        }

         public void IssueWithDraw()
        {
            WithDraw(1);
        }

    }
}
