// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
using System.Threading.Tasks;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adding local repo");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome");
            Console.WriteLine("Modifying changes in Remote");
            Human human = new Human();
            Console.WriteLine("Please enter human name");
            human.name = Console.ReadLine();
            Console.WriteLine("Please enter ur height");
            human.height = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("please enter ur weight");
            human.weight = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("please enter ur age");
            human.age = Convert.ToInt32(Console.ReadLine());
            human.Speak();
            human.HumanDetails(human.name, human.weight, human.height, human.age);
            Console.ReadLine();
        }

    }
}
