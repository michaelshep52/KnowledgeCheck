using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeCheck
{
    public class Truck : Vehicle
    {
        public Truck()
        {
            
        }
        public Truck(int truckId)
        {
            TruckId = truckId;
        }
        public int TruckId { get; private set; }
        public string? Name { get; set; }
        public int Year { get; set; }
        public int NumOfWheels = 4;
         public List<Truck> Retrieve() //gets a full list of vehicles
        {
            return new List<Truck>();
        }
        /*public Truck(string brand, string model, string color, int year, int numOfWheels)
        {
            this.Brand = brand;
            this.Model = model;
            this.Color = color;
            this.Year = year;
            this.NumOfWheels = numOfWheels;
        }*/



    }
}
    

   

