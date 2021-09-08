using System;
using System.Collections.Generic;
using System.Text;

namespace DITest
{
    class SingletonService : ISingleton
    {
        public SingletonService()
        {
            Console.WriteLine("create Singleton.");
        }
    }
}
