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
using System.IO;
namespace WorkWithFiles
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
            StreamWriter sw = new StreamWriter("func.txt");
            sw.WriteLine(textbox1.Text);
            sw.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader("func.txt");
            string line;
            line = sr.ReadLine();
            while (line != null)
            {
                textbox2.Text += line;
                line = sr.ReadLine();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            var name = System.IO.Path.GetFullPath("func.txt");
            textbox3.Text = name;
            textbox3.IsReadOnly = true;
        }
    }
}
