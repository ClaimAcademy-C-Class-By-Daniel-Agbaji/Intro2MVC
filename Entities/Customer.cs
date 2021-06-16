﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Entities
{
    public class Customer
    {
        public int id  { get; set; }
        public string CustomerName { get; set; }

        public int CustomerOrderNumber { get; set; }

        public bool DidCustomerOrdered { get; set; }
    }
}