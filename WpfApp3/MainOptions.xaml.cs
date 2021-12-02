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
    /// Interaction logic for MainOptions.xaml
    /// </summary>
    public partial class MainOptions : Window
    {
        string colorClose = "#FF1861F1", colorExpand = "#FF1C54C2";
        public MainOptions()
        {
            InitializeComponent();
        }

        private void LeftEnter(object sender, MouseEventArgs e)
        {
            SP1.Width += 150;
            SP1.Height += 550;
            SP1.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF1C54C2");
        }

        private void LeftLeave(object sender, MouseEventArgs e)
        {
            SP1.Width -= 150;
            SP1.Height -= 550;
            SP1.Background = (SolidColorBrush) new BrushConverter().ConvertFromString("#FF1861F1");
        }

        private void RightEnter(object sender, MouseEventArgs e)
        {
            SP2.Width += 150;
            SP2.Height += 550;
            SP2.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF1C54C2");
        }

        private void RightLeave(object sender, MouseEventArgs e)
        {
            SP2.Width -= 150;
            SP2.Height -= 550;
            SP2.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF1861F1");
        }

        private void ActiveTicketDown(object sender, MouseButtonEventArgs e)
        {
            if (SP3.Height == 45) {
                SP3.Height += 440;
                TBPress.Visibility = Visibility.Hidden;
            }
            else
            {
                SP3.Height -= 440;
                TBPress.Visibility = Visibility.Visible;
            }
        }

        private void LeftDown(object sender, MouseButtonEventArgs e)
        {
            if (SP1.Height == 60)
            {
                SP1.Height += 550;
                SP1.Width += 150;
                SP1.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(colorExpand);
            }
            else
            {
                SP1.Height -= 550;
                SP1.Width -= 150;
                SP1.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(colorClose);
            }
        }

        private void RightDown(object sender, MouseButtonEventArgs e)
        {
            if (SP2.Height == 60)
            {
                SP2.Height += 550;
                SP2.Width += 150;
                SP2.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(colorExpand);
            }
            else
            {
                SP2.Height -= 550;
                SP2.Width -= 150;
                SP2.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(colorClose);
            }
        }
    }
}
