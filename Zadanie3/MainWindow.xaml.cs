﻿using System;
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

namespace Zadanie3
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

            int N = Convert.ToInt32(nTextBox.Text);
            float nak = 0;
            if (N > 0)
            {
                for (int i = 1; i <= N; i++)
                {
                    nak += (float)1 / i;
                }
                Otvet.Text = $"{nak:f2}";
            }
            else
            {
                Otvet.Text = $"Число меньше нуля";
            }
        }
    }
}
