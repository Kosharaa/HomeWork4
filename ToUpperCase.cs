using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter you'r Second Name, Name, Surname: ");
            string FirstName = Console.ReadLine();
            string[] SubName = FirstName.Split(' ');

            for (int i = 0; i < SubName.Count(); i++)
            {
                FirstName = SubName[i].Substring(0, 1).ToUpper();
                if (i == 0)
                {
                    SubName[i] = FirstName + SubName[i].Substring(1, SubName[i].Length - 1);
                }
                else
                {
                    SubName[i] = FirstName + ".";
                }
            }
            Console.WriteLine(string.Join(" ", SubName));

            /* Более короткая версия
            string fio = Console.ReadLine();
            string[] array = fio.Split(' ').Select(x => x.Substring(0, 1).ToUpper() + x.Remove(0, 1)).ToArray();
            Console.WriteLine($"{array.First()} {array[1].First()}.{array[2].First()}.");
            */

            /* хороший метод, но требует дополнительного пространства имен System.Globalization - забракован учителем.
            FirstName = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(FirstName.ToLower());
            Console.WriteLine(FirstName);
            */
            Console.ReadKey();
        }
    }
}
