using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HelloWorld
{
    public class Human
    {
        public string name;
        public int age;
        public float weight, height;
        public void Speak()
        {
            Console.WriteLine("Human can speak");
        }
        public void HumanDetails(String humanname, int age, float weight, float height)
        {
            Console.WriteLine("HumanDetails:{0},{1},{2},{3}", humanname, age, weight, height);
        }
    }
}
