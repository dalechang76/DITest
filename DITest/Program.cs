using System;
using Microsoft.Extensions.DependencyInjection;

namespace DITest
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new ServiceCollection()
                .AddSingleton<ISingleton, SingletonService>()
                .AddTransient<ITransient, TransientService>()
                .AddScoped<IScoped, ScopedService>()
                .BuildServiceProvider();

            var provider1 = root.CreateScope().ServiceProvider;
            var provider2 = root.CreateScope().ServiceProvider;

            GetService<ISingleton>(provider1);
            GetService<ITransient>(provider1);
            GetService<IScoped>(provider1);
            Console.WriteLine("-------------");
            GetService<ISingleton>(provider2);
            GetService<ITransient>(provider2);
            GetService<IScoped>(provider2);
        }

        static void GetService<T>(IServiceProvider serviceProvider)
        {
            serviceProvider.GetService<T>();
            serviceProvider.GetService<T>();
        }
    }
}
