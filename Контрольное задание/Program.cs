using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Контрольное_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cat Cat=new Cat("Мурка");
            Dog Dog = new Dog("Норд");
            Cat.ShowInfo();
            Dog.ShowInfo();
            Console.ReadKey();
        }
    }
}
