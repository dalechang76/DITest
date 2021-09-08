using System;
using System.Collections.Generic;
using System.Text;

namespace DITest
{
    class ScopedService : IScoped
    {
        public ScopedService()
        {
            Console.WriteLine("create Scope.");
        }
    }
}
