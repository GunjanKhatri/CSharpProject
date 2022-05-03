using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Producer p1 = new Producer();
            p1.ProcessCompleted += P1_ProcessCompleted; // register with an event
            p1.StartProcess();

            Console.ReadKey();
        }

        public static void P1_ProcessCompleted(object sender, ProcessEventArgs e)
        {
            Console.WriteLine("Process" + (e.IsSuccessful?"Completed Successfully":"failed"));
            Console.WriteLine("Completion time is: "+ e.CompletionDate.ToLongDateString());
        }
    }
}
