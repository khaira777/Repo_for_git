using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_git_project
{
    class Program
    {
        static void Main(string[] args)
        {
            person tom = new person("Tom", 40);
            tom.SaysHello();
            string tomString = tom.ToString();

            Console.WriteLine(tomString);
            Console.WriteLine();


            person jacky = new person("Jacky", 22);

            jacky.SaysHello();

            Console.WriteLine(jacky.ToString());
            Console.WriteLine();

            /*Student joss = new Student("Joss", 22, "A1234567890");

            joss.SaysHello();
            joss.Studies();

            Console.WriteLine(joss.ToString());*/
            Console.ReadLine();
        }
    }
}
