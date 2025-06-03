using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd1_SagutdinovaIlona
{
    internal class Cat
    {
        private string name;//имя
        public string Name //свойство имени
        { get { return name; } //возврат имени
            set{ //установка значения, реализуем проверку
                bool let = true;

                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        let = false;
                    }
                }

                if (let)
                    name = value;
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                    name="";
                }
            } }
        private double ves; // вес
        public double Ves //свойство веса
        {
            get { return ves; } //возврат веса
            set //установка значения веса, проверка
            {
                if (value == 0)
                {
                    Console.WriteLine("Вес не может быть нулевым!");
                    return;
                }
                else if (value < 4)
                {
                    Console.WriteLine("Вес не может быть меньше нуля!");
                    return;
                }
                else if (value>50)
                    Console.WriteLine("Вес не может быть больше 50");
                else
                    ves = value;
            }
        }
        public void Meow() //метод где кошка мяукает
        {
            if (ves>0 || name!="")
                Console.WriteLine($"кошка с именем {name} и весом {ves} кричит: МЯЯЯУУ!!!");
        }
    }
}
