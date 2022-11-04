using System.Runtime.Serialization;
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
            var numberOfRecords = int.Parse(Console.ReadLine()!);

            var truckRecordList = new List<Truck>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                var truck = new Truck();
                Console.WriteLine("Enter who produces your truck: ");
                truck.Brand = Console.ReadLine();
                if (truck.Brand == "") 
                {
                    Console.WriteLine("You did not enter a producer!");
                    return;
                }
                Console.WriteLine("What is the make of your truck: ");
                truck.Name= Console.ReadLine();
                if(truck.Name == "") 
                {
                    Console.WriteLine("Please enter a make!");
                    return;
                }
                if(truck.Name == "Ford") throw new InvalidDataException("Ford doesn't make a truck enter a real make!");

                Console.WriteLine("Enter the model: ");
                truck.Model = Console.ReadLine();
                if (truck.Model == "") 
                {
                    Console.WriteLine("You did not enter a model!");
                    return;
                }
                Console.WriteLine("Enter the color: ");
                truck.Color = Console.ReadLine();
                if (truck.Color == "") 
                {
                    Console.WriteLine("You did not enter a producer!");
                    return;
                }
                Console.WriteLine("Enter the year: ");
                truck.Year = Convert.ToInt32(Console.ReadLine());

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
                Console.WriteLine(
                    $"Thank you for registration: {truck.Brand}, {truck.Name}, {truck.Model}, {truck.Color}, {truck.Year}.");
            }  
            Console.ReadKey();
        }
    }
}
