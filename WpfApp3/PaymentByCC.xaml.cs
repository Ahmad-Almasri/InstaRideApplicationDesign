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
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for PaymentByCC.xaml
    /// </summary>
    public partial class PaymentByCC : Window
    {
        private int counter = 0;
        public PaymentByCC()
        {
            InitializeComponent();
        }

        private void ActiveTicketDown(object sender, MouseButtonEventArgs e)
        {
            if (SP3.Height == 45)
            {
                SP3.Height += 440;
                TBPress.Visibility = Visibility.Hidden;
            }
            else
            {
                SP3.Height -= 440;
                TBPress.Visibility = Visibility.Visible;
            }
        }

        private void CheckBoxClicked(object sender, RoutedEventArgs e)
        {
            counter++;
            if (counter % 2 == 0) {
                check.IsChecked = false;
            }
        }
    }
}