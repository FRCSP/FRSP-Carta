﻿using Microsoft.Win32;
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
using FRSP_Carta.CSVImport;

namespace FRSP_Carta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog ofd = new OpenFileDialog();
        List<Robot> data = new List<Robot>();
        public MainWindow()
        {
            InitializeComponent();
            tbiload.Width = tbcform.Width / 2;
            tbiplot.Width = tbcform.Width / 2;
        }

        private void btnLoadFile_Click(object sender, RoutedEventArgs e)
        {
            if (ofd.ShowDialog() == true)
            {
                data = CSVImporter.Import(ofd.FileNames.First());
            }
        }

        private void tbcform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D2)
            {
                tbiplot.IsSelected = true;
            }
            if (e.Key == Key.D1)
            {
                tbiload.IsSelected = true;
            }
            lbl.Content = nameof(e.Key);
        }
    }
}