// See https://aka.ms/new-console-template for more information
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
            Console.WriteLine("please enter human age");
            human.age = Convert.ToInt32(Console.ReadLine());
            human.weight = Convert.ToSingle(Console.ReadLine());
            human.height = Convert.ToSingle(Console.ReadLine());
            human.Speak();
            human.HumanDetails(human.name, human.age, human.height, human.weight);
            Console.ReadLine();
        }

    }
}
