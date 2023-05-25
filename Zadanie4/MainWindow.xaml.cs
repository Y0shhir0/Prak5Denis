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

namespace Zadanie4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(aTextBox.Text, out double a) && int.TryParse(nTextBox.Text, out int n) && n > 0)
            {
                double a1 = 1;
                double sum = 1;

                for (int i = 0; i < n; i++)
                {
                    a1 = a1 * a * (-1);
                    sum = sum + a1;
                }

                Otvet.Text = $"Значение выражения: {sum:F2}";
            }
            else
            {
                Otvet.Text = "Некорректный ввод";
            }
        }
    }
}
