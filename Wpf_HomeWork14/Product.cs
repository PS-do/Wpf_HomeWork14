using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_HomeWork14
{

    //Определить класс Product для хранения информации о товаре.
    //Класс должен содержать характеристики
    //Название товара (строка),
    //Цена (число),
    //Изображение (строка - путь к файлу с изображением),
    //Категория(перечисление, возможные значения – Еда, Бытовая техника).

    public enum ProdCategorys
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string ProductName { get; set; }
        public double Coast { get; set; }
        public string imgPath { get; set; }
        public ProdCategorys ProdCategory { get; set; }
    }
}
