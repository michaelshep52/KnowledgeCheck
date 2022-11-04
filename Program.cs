using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeCheck
{
        public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many Trucks do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var truckRecordList = new List<Truck>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                var truck = new Truck();
                Console.WriteLine("Enter who produces your truck: ");
                truck.Brand = Console.ReadLine();

                Console.WriteLine("What is the name of your Truck");
                truck.Name= Console.ReadLine();
                if (truck.Name == "Chevrolet") Console.WriteLine("Congratulations your truck is a Chevrolet");
                if (truck.Name == "Dodge") Console.WriteLine("Congratulations your truck is a Dodge");
                if (truck.Name == "Ford") throw new InvalidDataException("Sorry Ford doesnt make a truck enter a real name");

                Console.WriteLine("Enter the model: ");
                truck.Model = Console.ReadLine();

                Console.WriteLine("Enter the color: ");
                truck.Color = Console.ReadLine();

                Console.WriteLine("Enter the year: ");
                truck.Year = int.Parse(Console.ReadLine());
            
                truckRecordList.Add(new Truck() 
                { 
                Brand = truck.Brand,
                Name = truck.Name, 
                Model = truck.Model, 
                Color = truck.Color, 
                Year = truck.Year
                });  

            }
            foreach (var truck in truckRecordList)
            {
                Console.WriteLine($"Thank you for registering your: {truck.Brand}, {truck.Name}, {truck.Model}, {truck.Color}, {truck.Year}.");
            }

            //Console.WriteLine($"There are {truck.Count} trucks in the list");
            Console.ReadKey();
        }
    }
}
