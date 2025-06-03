using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2_sagutdinova
{
    internal class Shop
    {
        public static Dictionary<Product, int> products;
        
        public Shop()
        {
            products = new Dictionary<Product, int>();
        }
        public void AddProduct(Product product, int count) //добавление товара
        {
            products.Add(product, count);
        }
        public string WriteAllProducts() //вывод списка товаров
        {
            string list = "Список продуктов: \n";
            foreach (var product in products)
            {
                list+=product.Key.GetInfo() + "; Количество: " + product.Value + "\n";
            }
            return list;
        }
        public void CreateProduct(string name, decimal price, int count) //создание товара
        {
            products.Add(new Product(name, price), count);
        }
        public string Sell(Product product, int count) //продажа товара
        {
            if (products.ContainsKey(product))
            {
                if (products[product] == 0)
                {
                    return null;
                }
                else if (count < 0)
                    return null;
                else
                {
                    products[product] -= count; ;
                }
            }
            else
            {
                return null;
            }
            return "sdf";
        }
        public Product FindByName(string name) //поиск товара по имени
        {
            foreach (var product in products.Keys)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }
        public string Sell(string ProductName,int count) //уучшенная продажа товара
        {
            Product ToSell = FindByName(ProductName);
            
             if (ToSell != null)
            {
                if (this.Sell(ToSell, count) == null)
                    return null;
                else
                    return "fdf";

            }
            else
            {
                return null;
            }
            return "Товар найден";
        }
    }
}
