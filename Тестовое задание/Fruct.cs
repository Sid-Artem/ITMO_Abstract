using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестовое_задание
{
    abstract class Fruct
    {
        
        public abstract string Name { get; set; }
        
        public Fruct(string name) {  Name = name; }
        public abstract void GetTaste();

        public void ShowInfo() 
        {
            Console.WriteLine(Name);
            GetTaste();
        }
    }
    class Apple : Fruct
    {
        string country;
        string taste;
        string name;

        public override string Name 
        { get => name; 
          set => name=value;
        }

        public Apple(string name, string taste, string country)
        : base(name)
        {
            this.taste = taste;
            this.country = country;
        }


        public override void GetTaste()
        {
            Console.WriteLine(taste);
        }
    }
    class Lemon : Fruct
    {
        int level;
        private string name;

        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Lemon(string name, int level)
        : base(name)
        {
           this.level = level;

        }


        public override void GetTaste()
        {
            Console.WriteLine("Кислый");
        }
}   }
