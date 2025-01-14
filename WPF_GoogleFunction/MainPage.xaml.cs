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

namespace CampKiosk
{
    /// <summary>
    /// MainPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("/enterPage.xaml", UriKind.Relative);
            NavigationService.Navigate(uri);
        }
        private void visitorButton_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("/visitorPage.xaml", UriKind.Relative);
            NavigationService.Navigate(uri);
        }
        private void eventButton_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("/eventPage.xaml", UriKind.Relative);
            NavigationService.Navigate(uri);
        }
    }  
}
