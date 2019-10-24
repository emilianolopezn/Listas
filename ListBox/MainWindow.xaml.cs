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
using System.Collections.ObjectModel;

namespace ListBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        ObservableCollection<Color> Colores = 
            new ObservableCollection<Color>();

        public MainWindow()
        {
            InitializeComponent();
            Colores.Add(new Color("Rojo", "#FF0000", "(255,0,0)"));
            Colores.Add(new Color("Verde", "#00FF00", "(0,255,0)"));
            Colores.Add(new Color("Azul", "#00000FF", "(0,0,255)"));

            lstColores.ItemsSource = Colores;
            
        }

        private void BtnNuevoColor_Click(object sender, RoutedEventArgs e)
        {
            Colores.Add(new Color(
                txtColor.Text,txtHex.Text,txtRGB.Text));
            txtColor.Text = "";
            
        }
    }
}
