using RepositoryFactoryAndMethodPattern.Factories;
using RepositoryFactoryAndMethodPattern.Models;
using RepositoryFactoryAndMethodPattern.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern
{
    internal class Program
    {
        static void Main()
        {
            DITest1 di1 = new DITest1(new RepositoryFactoryImpl());
            di1.Run();
            Console.WriteLine("======================");
            DITest2 di2 = new DITest2();
            di2.Run(new RepositoryFactoryImpl());
            Console.WriteLine("====================== ");
            DITest3 di3 = new DITest3(new RepositoryFactoryImpl().GetRepo<Bike>());
            di3.Run();
            Console.WriteLine("====================== ");
            Console.ReadLine();
        }
    }
}
