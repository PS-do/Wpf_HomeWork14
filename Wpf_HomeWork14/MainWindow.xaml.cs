using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_HomeWork14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Стиральная машина",
                Coast = 123.321,
                imgPath = "Data/Appliances.png",
                ProdCategory = ProdCategorys.Appliances,
            });
            products.Add(new Product()
            {
                ProductName = "Бананы",
                Coast = 16.21,
                imgPath = "Data/Food.png",
                ProdCategory = ProdCategorys.Food,
            });
            products.Add(new Product()
            {
                ProductName = "Блендер",
                Coast = 25.25,
                imgPath = "Data/Appliances.png",
                ProdCategory = ProdCategorys.Appliances,
            });
            lstBox.ItemsSource = products;
        }
    }
}
