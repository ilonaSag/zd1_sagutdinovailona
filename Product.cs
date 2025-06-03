using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2_sagutdinova
{
    internal class Product
    {
        private decimal price;
        private string name;
        public decimal Price { get; set; }
        public string Name { get; set; }
        public Product(string Name, decimal Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
        public string GetInfo() //информация о товаре
        {
            return $"Наименование: {Name}; Цена: {Price} руб.";
        }
    }
}
