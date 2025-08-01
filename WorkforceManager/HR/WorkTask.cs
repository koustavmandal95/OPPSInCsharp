using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkforceManager.HR
{
    public struct WorkTask
    {
        public string description;
        public int hours;

        public void PerformTask()
        {
            Console.WriteLine($"Task {description} of {hours} hour(s) has been performed.");
        }
    }
}