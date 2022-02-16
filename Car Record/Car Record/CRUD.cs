using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Record
{
    interface CRUD
    {
        ICollection<Car> ReadCars();
        void AddRecord(Car obj);
        void DeleteRecord(Car obj);
        Car FindCar(string vin);
        void UpdateRecord(string vin, Car carChanges);
    }

    class CarRepository : CRUD
    {
        CarsDBEntities entities;
        public CarRepository()
        {
            entities = new CarsDBEntities();
        }
        public void AddRecord(Car obj)
        {
            entities.Cars.Add(obj);
            entities.SaveChanges();
        }

        public void DeleteRecord(Car obj)
        {
            entities.Cars.Remove(obj);
            entities.SaveChanges();
        }

        public Car FindCar(string vin)
        {
            var car = entities.Cars.First(c => c.VIN == vin);
            if (car != null)
                return car;
            else
                return null;
        }

        public ICollection<Car> ReadCars()
        {
            return entities.Cars.ToList();
        }

        public void UpdateRecord(string vin, Car carChanges)
        {
            var carToUpdate = entities.Cars.Find(vin);
            carToUpdate.VIN = carChanges.VIN;
            carToUpdate.Make = carChanges.Make;
            carToUpdate.Model = carChanges.Model;
            carToUpdate.Year = carChanges.Year;
            carToUpdate.Price = carChanges.Price;

            entities.SaveChanges();
        }
    }
}
