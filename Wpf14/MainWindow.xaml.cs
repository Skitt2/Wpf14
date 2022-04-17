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

namespace Wpf14
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
                ProductName = "Блиннница",
                Price = 2300,
                Image = "Data/Блинница.jpg",
                ProductTypes = ProductTypes.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Гречка",
                Price = 100,
                Image = "Data/Гречка.jpg",
                ProductTypes = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Микроволновая печь",
                Price = 5200,
                Image = "Data/Микроволновая печь.jpg",
                ProductTypes = ProductTypes.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Миксер",
                Price = 2300,
                Image = "Data/Миксер.jpg",
                ProductTypes = ProductTypes.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Молоко",
                Price = 80,
                Image = "Data/Молоко.jpg",
                ProductTypes = ProductTypes.Food
            });
            listBox.ItemsSource = products;
        }
    }
}
