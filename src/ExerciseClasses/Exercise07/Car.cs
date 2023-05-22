using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal RentalPricePerDay { get; set; }
        public bool IsAvailable { get; set; }
    }

    public class CarRentalSystem
    {
        public List<Car> Cars { get; set;} = new List<Car>();

        public void AddCars(string make, string model, int year,decimal renalPricePerDay)
        {
            Car car = new Car 
            { 
                IsAvailable = true,
                Make = make,
                Model = model,
                Year = year,
                RentalPricePerDay= renalPricePerDay
            };
            Cars.Add(car);

        }
        public Car RentCar(string make, string model, int year)
        {
            Car car = Cars.Find(c=> c.Make == make && c.Model == model && c.Year == year && c.IsAvailable);
            if (car != null)
            {
                car.IsAvailable = false;
                return car;
            }
            else
            {
                return null;
            }
        }

        public Car ReturnCar(string make, string model, int year)
        {
            Car car = Cars.Find(c => c.Make == make && c.Model == model && c.Year == year && !c.IsAvailable);
            if (car != null)
            {
                car.IsAvailable = true;
                return car;
            }
            else
            {
                return null;
            }
        }
        public void DisplayAvailableCars()
        {
            Console.WriteLine("Available Cars:");
            foreach (Car car in Cars)
            {
                if (car.IsAvailable)
                {
                    Console.WriteLine($"Make: {car.Make}, Model: {car.Model}, Year: {car.Year}, Rental Price per Day: {car.RentalPricePerDay}");
                }
            }
        }
    }
}
