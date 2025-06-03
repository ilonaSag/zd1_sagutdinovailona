using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zd1_SagutdinovaIlona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cat cat = new Cat();
                Console.WriteLine("Введите имя кошки");
                cat.Name = Console.ReadLine();
                Console.WriteLine("Введите вес кошки");
                cat.Ves = double.Parse(Console.ReadLine());
                    cat.Meow();
            }
            catch { Console.WriteLine("Неверный ввод"); }
            Console.ReadKey();
        }
    }
}
