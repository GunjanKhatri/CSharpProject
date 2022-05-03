using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Assignment
{
    public class ProcessEventArgs:EventArgs
    {
        public bool IsSuccessful { get; set; }

        public DateTime CompletionDate { get; set; }
    }
}
