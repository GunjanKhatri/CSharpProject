using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Assignment
{
    //public delegate void Notify<T>();
    public class Producer
    {
        //public event Notify<ProcessEventArgs> ProcessCompleted;
        public event EventHandler<ProcessEventArgs> ProcessCompleted;
        public void StartProcess()
        {
            var data = new ProcessEventArgs();
            try
            {
                Console.WriteLine("Process Started!");

                Random rand = new Random();
                var result = rand.Next(1, 50000);
                Console.WriteLine(result);

                data.IsSuccessful = true;
                data.CompletionDate = DateTime.Now;
                OnProcessCompleted(data);
            }
            catch
            {
                data.IsSuccessful = false;
                data.CompletionDate = DateTime.Now;
                OnProcessCompleted(data);
            }
        }

        protected virtual void OnProcessCompleted(ProcessEventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        } 

    }
}
