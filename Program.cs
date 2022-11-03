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

            var recordList = new List<Truck>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                var truck = new Truck();

                Console.WriteLine("What is the name of your Truck");
                truck.Name= Console.ReadLine();
                if (truck.Name == "Chevrolet") Console.WriteLine("Congratulations your truck is a Chevrolet");
                if (truck.Name == "Dodge") Console.WriteLine("Congratulations your truck is a Dodge");
                if (truck.Name == "Ford") throw new InvalidDataException("Sorry Ford doesnt make a truck enter a real name");

                Console.WriteLine("Enter who produces your truck: ");
                truck.Brand = Console.ReadLine();
                Console.WriteLine("Enter the model: ");
                truck.Model = Console.ReadLine();
                Console.WriteLine("Enter the color: ");
                truck.Color = Console.ReadLine();
                Console.WriteLine("Enter the year: ");
                truck.Year = int.Parse(Console.ReadLine());
            
                recordList.Add(truck);     
            }
            recordList.ForEach(Truck => Console.WriteLine(Truck));
        
            //Console.WriteLine($"There are {truck.Count} trucks in the list");
            Console.ReadKey();
        }
    }
}
