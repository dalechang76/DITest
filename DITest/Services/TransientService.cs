using System;
using System.Collections.Generic;
using System.Text;

namespace DITest
{
    class TransientService : ITransient
    {
        public TransientService()
        {
            Console.WriteLine("create Transient.");
        }
    }
}
