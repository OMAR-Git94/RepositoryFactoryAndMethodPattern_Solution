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
    public class DITest1
    {
        readonly IRepositoryFactory factory;
        public DITest1(IRepositoryFactory factory)
        {
            this.factory = factory;
        }

        public void Run()
        {
            IGenecricRepostory<Bus> repo = this.factory.GetRepo<Bus>();
            repo.Insert(new Bus { Id = 1, BusName = "Green Line", BusColor = "White", Seat = 60 });
            repo.AddRange(new Bus[] {
                new Bus { Id = 2, BusName = "Hanif", BusColor = "Green", Seat=65},
                new Bus { Id = 3, BusName = "Red line", BusColor= "White", Seat=60 }
            });
            repo.Get()
                .ToList()
                .ForEach(b => Console.WriteLine($"BusName: {b.BusName}, BusColor: {b.BusColor}, Seat: {b.Seat}"));
            Console.WriteLine();
            Console.WriteLine("Update:");
            //update
            var bus = repo.Get(2);
            bus.BusColor = "red";
            repo.Update(bus);
            repo.Get()
                .ToList()
                .ForEach(b => Console.WriteLine($"BusName: {b.BusName}, BusColor: {b.BusColor}, Seat: {b.Seat}"));
            Console.WriteLine();
            Console.WriteLine("Delete:");
            //delete
            repo.Delete(1);
            repo.Get()
               .ToList()
               .ForEach(b => Console.WriteLine($"BusName: {b.BusName}, BusColor: {b.BusColor}, Seat: {b.Seat}"));
            Console.WriteLine();
            IGenecricRepostory<ManuFacturingCompany> repo1 = factory.GetRepo<ManuFacturingCompany>();
            repo1.Insert(new ManuFacturingCompany { Id = 1, CompanyName = "Volvo", CompanyNumber = "01876XXXXXX", CompanyEmail = "volvo@volvo.com" });
            repo1.AddRange(new ManuFacturingCompany[]
            {
                new ManuFacturingCompany { Id = 2, CompanyName = "Purbasha", CompanyNumber = "01999XXXXXX", CompanyEmail = "pur@pur.pub" },
                new ManuFacturingCompany { Id = 3, CompanyName = "Royal", CompanyNumber = "01777XXXXXX", CompanyEmail = "royal@royal.com" }
            });
            repo1.Get()
                .ToList()
                .ForEach(m => Console.WriteLine($"Id:{m.Id}, Name: {m.CompanyName},Contact: {m.CompanyName}, Email: {m.CompanyEmail}"));
            Console.WriteLine();
            Console.WriteLine("Update:");
            var mf = repo1.Get(1);
            mf.CompanyNumber = "01888XXXXXX";
            mf.CompanyEmail = "contact@volvo.com";
            repo1.Update(mf);
            repo1.Get()
                .ToList()
                .ForEach(m => Console.WriteLine($"Id:{m.Id}, Name: {m.CompanyName},Contact: {m.CompanyName}, Email: {m.CompanyEmail}"));
            Console.WriteLine();
            Console.WriteLine("Delete:");
            repo1.Delete(1);
            repo1.Get()
                .ToList()
                .ForEach(m => Console.WriteLine($"Id:{m.Id}, Name: {m.CompanyName},Contact: {m.CompanyName}, Email: {m.CompanyEmail}"));
            Console.WriteLine();

        }
    }
}
