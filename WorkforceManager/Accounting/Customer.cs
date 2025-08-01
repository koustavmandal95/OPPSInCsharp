using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkforceManager.Accounting
{
    public class Customer
    {
        private string customerId;

        private string name;

        public string customerId
        {
            get { return customerId; }
            set
            {
                customerId = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
    }
}