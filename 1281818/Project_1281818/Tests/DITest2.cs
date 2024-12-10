using RepositoryFactoryAndMethodPattern.Factories;
using RepositoryFactoryAndMethodPattern.Models;
using RepositoryFactoryAndMethodPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Tests
{
    public class DITest2
    {
        public void Run(IRepositoryFactory factory)
        {
            IGenecricRepostory<ManuFacturingCompany> repo = factory.GetRepo<ManuFacturingCompany>();
            repo.Insert(new ManuFacturingCompany { Id = 1, CompanyName = "Volvo", CompanyNumber = "01876XXXXXX", CompanyEmail = "pub1@pub.pub" });
            repo.AddRange(new ManuFacturingCompany[]
            {
                new ManuFacturingCompany { Id = 2, CompanyName = "Purbasha", CompanyNumber = "01876XXXXXX", CompanyEmail = "pub1@pub.pub" },
                new ManuFacturingCompany { Id = 3, CompanyName = "Royal", CompanyNumber = "01876XXXXXX", CompanyEmail = "pub1@pub.pub" }
            });
            repo.Get()
                .ToList()
                .ForEach(m => Console.WriteLine($"Id:{m.Id}, Name: {m.CompanyName},Contact: {m.CompanyName}, Email: {m.CompanyEmail}"));
            Console.WriteLine();
            Console.WriteLine("Update:");
            var mf = repo.Get(1);
            mf.CompanyNumber = "01888XXXXXX";
            mf.CompanyEmail = "pub1@pub.com";
            repo.Update(mf);
            repo.Get()
                .ToList()
                .ForEach(m => Console.WriteLine($"Id:{m.Id}, Name: {m.CompanyName},Contact: {m.CompanyName}, Email: {m.CompanyEmail}"));
            Console.WriteLine();
            Console.WriteLine("Delete:");
            repo.Delete(1);
            repo.Get()
                .ToList()
                .ForEach(m => Console.WriteLine($"Id:{m.Id}, Name: {m.CompanyName},Contact: {m.CompanyName}, Email: {m.CompanyEmail}"));
            Console.WriteLine();
            IGenecricRepostory<Bus> repo1 = factory.GetRepo<Bus>();
            repo1.Insert(new Bus { Id = 1, BusName = "Green Line", BusColor = "White", Seat = 60 });
            repo1.AddRange(new Bus[] {
                new Bus { Id = 2, BusName = "Hanif", BusColor = "Green", Seat=65},
                new Bus { Id = 3, BusName = "Red line", BusColor= "White", Seat=60 }
            });
            repo1.Get()
                .ToList()
                .ForEach(b => Console.WriteLine($"BusName: {b.BusName}, BusColor: {b.BusColor}, Seat: {b.Seat}"));
            Console.WriteLine();
            Console.WriteLine("Update:");
            //update
            var bus = repo1.Get(2);
            bus.BusColor = "red";
            repo1.Update(bus);
            repo1.Get()
                .ToList()
                .ForEach(b => Console.WriteLine($"BusName: {b.BusName}, BusColor: {b.BusColor}, Seat: {b.Seat}"));
            Console.WriteLine();
            Console.WriteLine("Delete:");
            //delete
            repo1.Delete(1);
            repo1.Get()
               .ToList()
               .ForEach(b => Console.WriteLine($"BusName: {b.BusName}, BusColor: {b.BusColor}, Seat: {b.Seat}"));
        }
    }
}
