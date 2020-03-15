using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using FRSP_Carta.CSVImport;
using FRSP_Carta.UI;
using System.Windows.Documents;
using System.ComponentModel;
using System.Windows.Media;

namespace FRSP_Carta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog ofd = new OpenFileDialog();
        public static List<Robot> data = new List<Robot>();
        private GridViewColumnHeader listViewSortCol = null;
        private SortAdorner listViewSortAdorner = null;
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
            dtgData.IsReadOnly = true;
            dtgData.BorderBrush = Brushes.White;
        }

        private void btnLoadFile_Click(object sender, RoutedEventArgs e)
        {
            if (ofd.ShowDialog() == true)
            {
                MessageBox.Show(Width.ToString());
                if (ofd.FileNames.First().Split('.').Last() == "csv")
                {
                    dtgData.ItemsSource = null;
                    dtgData.Items.Clear();
                    data.Clear();
                    data = CSVImporter.Parse(ofd.FileName);
                    txtImportStatus.Text = "Imported";
                    tbilist.IsSelected = true;
                    dtgData.ItemsSource = data;
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

        private void DtgData_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            PropertyDescriptor pd = e.PropertyDescriptor as PropertyDescriptor;
            e.Column.Header = pd.DisplayName;
            if (pd.DisplayName == "MatchInfo")
            {
                e.Cancel = true;
            }
        }

        private void tbcform_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabControl control = sender as TabControl;
            if (control.SelectedItem == tbiload)
            {
                tbilist.IsSelected = false;
            }
        }
    }
}
