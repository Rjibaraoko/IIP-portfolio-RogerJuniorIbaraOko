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

namespace _03.wpf.Calculator
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userInput.Text += "1";
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            userInput.Text += "2";
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            userInput.Text += "3";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            userInput.Text += "4";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            userInput.Text += "5";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            userInput.Text += "6";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            userInput.Text += "7";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            userInput.Text += "8";
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            userInput.Text += "9";
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            userInput.Text += "0";
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            double num1 = Convert.ToDouble(userInput.Text);
            double num2 = Convert.ToDouble(resultaat.Content);

            



        }

        
    }
}
