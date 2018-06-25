using Carsales.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft;
using Newtonsoft.Json;

namespace Carsales.Server.Repository
{
    public static class CarRepository
    {
        public static string GetCars()
        {
            return JsonConvert.SerializeObject(new List<Car>
            {
                new Car {Id = 1, Comments="This is Toyota Camry" , Make = "Toyota", Model = "Camry", Year = 2018, SellerType = "Dealer", Price=5000},
                new Car {Id = 2, Comments="This is Honda City" , Make = "Honda", Model = "City", Year = 2017, SellerType = "Private", Price=15000},
                new Car {Id = 3, Comments="This is Mercedez S30" , Make = "Mercedes", Model = "S30", Year = 2015, SellerType =  "Dealer", Price=33222},
                new Car {Id = 4, Comments="This is Audi Q4" , Make = "Audi", Model = "Q4", Year = 2014, SellerType = "Private", Price=15000}
            });
        }
    }
}