using System;
using System.Threading;

namespace ProcessBar
{
    class Program
    {
        static void Main()
        {
            int totalItems = 100;
            ProcessBar.Process progressBar = new ProcessBar.Process(totalItems);

            for (int i = 0; i <= totalItems; i++)
            {
                Thread.Sleep(1); // Giả lập công việc đang được thực hiện
                progressBar.Update(i);
            }

            progressBar.Finish();
            Console.WriteLine("Process completed.");
        }
    }
}
