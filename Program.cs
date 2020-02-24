using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Breed = "German Shepherd";

            d.Color = "Black White";
            d.Name = "Zuki";
            d.Age = 6;
            d.AvailableForAdoption = true;
         
            

            Console.WriteLine("About Dog: Breed: {0} Color: {1} Name: {2} Age: {3}", d.Breed, d.Color, d.Name, d.Age);
            Console.ReadKey();



        }
    }
}
