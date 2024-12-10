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
    public class DITest3
    {
        readonly IGenecricRepostory<Bike> repo;
        public DITest3(IGenecricRepostory<Bike> repo)
        {
            this.repo = repo;
        }
        public void Run()
        {
           
            repo.Insert(new Bike { Id = 1, BikeName = "R15", BikeColor = "White", BikePrice = 600000 });
            repo.AddRange(new Bike[] {
                new Bike { Id = 2, BikeName = "RTR", BikeColor = "Green", BikePrice=200000},
                new Bike { Id = 3, BikeName = "HERO", BikeColor = "Red", BikePrice=100000 }
            });
            repo.Get()
                .ToList()
                .ForEach(b => Console.WriteLine($"BikeName: {b.BikeName}, BikeColor: {b.BikeColor}, Price: {b.BikePrice}"));
            Console.WriteLine("Update");
            //update
            var bike = repo.Get(2);
            bike.BikeColor = "Yellow";
            repo.Update(bike);
            repo.Get()
                .ToList()
                .ForEach(b => Console.WriteLine($"BikeName: {b.BikeName}, BikeColor: {b.BikeColor}, Price: {b.BikePrice}"));
            Console.WriteLine("Delete");
            //delete
            repo.Delete(1);
            repo.Get()
               .ToList()
               .ForEach(b => Console.WriteLine($"BikeName: {b.BikeName}, BikeColor: {b.BikeColor}, Price: {b.BikePrice}"));
            Console.WriteLine();

        }

    }
}
