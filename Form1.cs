using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd2_sagutdinova
{
    public partial class Form1 : Form
    {
        decimal sum = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //создание объекта магазина
        Shop mon = new Shop();
        private void Form1_Load(object sender, EventArgs e)
        {
            mon = new Shop();
            mon.CreateProduct("Кола", 80, 15);
            mon.CreateProduct("Фанта", 60, 10);
            mon.CreateProduct("молоко", 85, 20);
            foreach (var pt in Shop.products.Keys)
            {    comboBox1.Items.Add(pt.Name + " " + pt.Price.ToString()+" " + "руб"); //запонение комбобокса
            }
        }

        private void button1_Click(object sender, EventArgs e) //кнопка купить
        {
            if (comboBox1.Text != "")
            {
                int count = (int)numericUpDown1.Value;
                string[] part = comboBox1.Text.Split(' ');
                if (mon.Sell(part[0],count) == null )
                    MessageBox.Show("Товар не найден!");
                else
                {
                    if (Shop.products[mon.FindByName(part[0])] >= count)
                    {
                        sum += mon.FindByName(part[0]).Price * count;
                        price.Text = $"{sum}";
                        price.Visible = true;
                        Check();
                    }
                    else
                        MessageBox.Show("Товар закончился");
                }
            }
            else
                MessageBox.Show("Выберите товар!");
        }

        private void button2_Click(object sender, EventArgs e)//кнопка посмотреть список
        {
            Check();
        }
        public void Check() //запоняет листбокс
        {
            listBox1.Items.Clear();
            string line = mon.WriteAllProducts();
            string[] list = line.Split('\n');
            for (int i = 0; i < list.Length; i++)
                listBox1.Items.Add(list[i]);
        }
    }
}
