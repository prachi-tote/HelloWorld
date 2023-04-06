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
        public void HumanDetails(String humanname, float humanHeight,float humanWeight,int age)
        {
            Console.WriteLine("HumanDetails:{0},{1},{2},{3}", humanname, humanHeight,humanWeight,age);
        }
    }
}
