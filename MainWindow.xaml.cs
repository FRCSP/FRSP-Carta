using Microsoft.Win32;
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
        int autoBalls = 0;
        int teleBalls = 0;
        static List<string> sorts = new List<string>
        {
            "Raw Score",
            "Auto Score",
            "Teleop Score",
            "Can Use Control Panel",
            "Can Climb",
            "Can Level"
        };

        public MainWindow()
        {
            InitializeComponent();
            cmbSort.ItemsSource = sorts;
            
        }

        private void btnLoadFile_Click(object sender, RoutedEventArgs e)
        {
            if (ofd.ShowDialog() == true)
            {
                if (ofd.FileNames.First().Split('.').Last() == "csv")
                {
                    data = CSVImporter.Parse(ofd.FileName);
                    txtImportStatus.Text = "Imported";
                }
                else
                {
                    MessageBox.Show("Please choose a CSV File");
                }
            }
        }

        public static void LogEx(string ex)
        {
            MessageBox.Show(ex);
        }

        private void tbcform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D2)
            {
                tbilist.IsSelected = true;
            }
            if (e.Key == Key.D1)
            {
                tbiload.IsSelected = true;
            }
        }
    }
}
