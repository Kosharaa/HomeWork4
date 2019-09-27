using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] NameArray = new string[3][];
            Console.WriteLine("Enter you'r First Name, Surname, Second Name: ");

            for (int i = 0; i < NameArray.Length; i++)
            {                
                    string Info = Console.ReadLine();
                    NameArray[i] = Info.Split(' ');                
            }
            Console.WriteLine("Looking someone?: ");
            string search = Console.ReadLine();
            Console.WriteLine("Search result:");
            for (int i = 0; i < NameArray.Length; i++)
            {
                if (string.Join(" ", NameArray[i]).Contains(search))
                Console.WriteLine(string.Join(" ", NameArray[i]));
            }
            /*
            for (int i = 0; i < NameArray.Length; i++)
            {
                for (int j = 0; j < NameArray[i].Length; j++)
                {
                    Console.WriteLine(NameArray[i][j] + ",");
                }
                Console.WriteLine();
            }
            */




            /*
            string[][] NameArray = new string[3][];

            Console.WriteLine("Enter you'r First Name, Surname, Second Name: ");
            string FirtsBlock = Console.ReadLine();
            NameArray[0] = FirtsBlock.Split(' ');
            string SecondBlock = Console.ReadLine();
            NameArray[1] = FirtsBlock.Split(' ');
            string ThirdBlock = Console.ReadLine();
            NameArray[2] = FirtsBlock.Split(' ');

            for (int i = 0; i < NameArray.Length; i++)
            {
                for (int j = 0; j < NameArray[i].Length; j++)
                {
                    Console.WriteLine(NameArray[i][j] + ",");
                }
                Console.WriteLine();
            }
            */
            Console.ReadKey();
        }
    }
}
