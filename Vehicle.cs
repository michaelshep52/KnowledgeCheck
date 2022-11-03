using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeCheck
{
    public class Vehicle
    {
        public Vehicle()
        {
            
        }
        public Vehicle(int vehicleId)
        {
            VehicleId = vehicleId;   
        }

        public int VehicleId { get; private set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public Vehicle Retrieve(int VehicleId) //get a specific vehicle
        {
            return new Vehicle();
        }
        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true; 
            
            if(string.IsNullOrWhiteSpace(Brand)) isValid = false;
            if(string.IsNullOrWhiteSpace(Model)) isValid = false;
            if(string.IsNullOrWhiteSpace(Color)) isValid = false;



            return isValid;
        }
    }
}