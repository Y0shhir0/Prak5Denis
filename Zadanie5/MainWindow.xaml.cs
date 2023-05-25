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

namespace Zadanie5
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

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            double x = 1.0, y = 1.0, n1;
            n1 = x / (1 + Math.Abs(y));
            int n = Convert.ToInt32(nTextBox.Text);
            for (int i = 2; i <= n; i++)
            {
                x = 0.3 * (x - 1);
                y = x + y;
                n1 += x / (1 + Math.Abs(y));
            }
            Otvet.Text = $"Ответ: {n1}";
        }
    }
}
