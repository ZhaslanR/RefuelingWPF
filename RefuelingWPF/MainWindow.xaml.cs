using System;
using System.Collections.Generic;
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

namespace RefuelingWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double priseChocolate;
        private double priseOil;
        private double priseBurger;
        private double priseBeverages;
        private double sum;
        private double numbersOil;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sumButton_Click(object sender, RoutedEventArgs e)
        {
            if (checkBoxBeverages1.IsChecked == true)
            {
                priseBeverages = 1200;
            }
            else if (checkBoxBeverages2.IsChecked == true)
            {
                priseBeverages = 1500;
            }
            else if (checkBoxBeverages3.IsChecked == true)
            {
                priseBeverages = 1700;
            }

            if (checkBoxChocolate1.IsChecked == true)
            {
                priseChocolate = 500;
            }
            else if (checkBoxChocolate2.IsChecked == true)
            {
                priseChocolate = 700;
            }
            else if (checkBoxChocolate3.IsChecked == true)
            {
                priseChocolate = 900;
            }

            if (checkBoxOil1.IsChecked == true)
            {
                priseOil = 200;
            }
            else if (checkBoxOil2.IsChecked == true)
            {
                priseOil = 500;
            }
            else if (checkBoxOil3.IsChecked == true)
            {
                priseOil = 600;
            }

            if (checkBoxBurger1.IsChecked == true)
            {
                priseBurger = 2000;
            }
            else if (checkBoxBurger2.IsChecked == true)
            {
                priseBurger = 2200;
            }
            else if (checkBoxBurger3.IsChecked == true)
            {
                priseBurger = 2400;
            }

            if (checkBoxNumbersOil1.IsChecked == true)
            {
                numbersOil = 1;
            }
            else if (checkBoxNumbersOil2.IsChecked == true)
            {
                numbersOil = 2;
            }
            else if (checkBoxNumbersOil3.IsChecked == true)
            {
                numbersOil = 3;
            }
            else if (checkBoxNumbersOil4.IsChecked == true)
            {
                numbersOil = 4;
            }

            sum = priseBeverages + priseBurger + priseChocolate + (priseOil*numbersOil);
            MessageBox.Show("Сумма заказа = " + sum);
        }
    }
}
