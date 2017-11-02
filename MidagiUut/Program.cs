using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidagiUut
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogs dog1 = new Dogs();
            dog1.SetAge(7);
            dog1.Name = "GEEEEEEEEZ";
            dog1.Color = "White - Gray";

            Console.WriteLine("Koera nimi on: " + dog1.Name);
            Console.WriteLine("Koera värv on: " + dog1.Color);
            Console.WriteLine("Koera vanus on: " + dog1.CalculateDogYears());

            //Dogs dog2 = new Dogs();
            //Console.WriteLine("Sisesta koera nimi: ");
            //dog2.Name = Console.ReadLine();
            //Console.WriteLine("Sisesta koera vanus: ");
            //dog2.Age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sisesta koera värv: ");
            //dog2.Color = Console.ReadLine();

            //Console.WriteLine("Koera nimi on: " + dog2.Name);
            //Console.WriteLine("Koera värv on: " + dog2.Color);
            //Console.WriteLine("Koera vanus on: " + dog2.Age);

            Dogs dog3 = new Dogs();
            Console.WriteLine(dog3.Name);
            Console.WriteLine(dog3.Color);
            Console.WriteLine(dog3.NumberOfEyes);
            Console.WriteLine(dog3.IsCarnivore);
            Console.WriteLine("Koera tegelik vanus on: " + dog3.CalculateDogYears());


            //KiiZu cat1 = new KiiZu();
            //cat1.Name = "Kiiz";
            //cat1.Age = 1;
            //cat1.FurLength = "Long";
            //Console.WriteLine(cat1.Name);
            //Console.WriteLine(cat1.Age);
            //Console.WriteLine(cat1.FurLength);
            //Console.WriteLine();


        }
    }
}
