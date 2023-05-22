// See https://aka.ms/new-console-template for more information
using Exercise07;

CarRentalSystem rentalSystem = new CarRentalSystem();
rentalSystem.AddCars("Toyota", "Camry", 2020, 50.00m);
rentalSystem.AddCars("Honda", "Accord", 2019, 55.00m);
rentalSystem.AddCars("Ford", "Mustang", 2021, 80.00m);

Car rentedCar = rentalSystem.RentCar("Honda", "Accord", 2019);
if (rentedCar != null)
{
    Console.WriteLine($"Rented Car: {rentedCar.Make} {rentedCar.Model} {rentedCar.Year}");
}

rentalSystem.DisplayAvailableCars();