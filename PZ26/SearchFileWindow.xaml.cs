using System;
using System.IO;
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

namespace pz_26
{
    /// <summary>
    /// Логика взаимодействия для SearchFileWindow.xaml
    /// </summary>
    public partial class SearchFileWindow : Window
    {
        public SearchFileWindow()
        {
            InitializeComponent();
        }
        private void Ofcourse_Click(object sender, RoutedEventArgs e)
        {
            listbox1.Items.Clear();
            DirectoryInfo dr = new DirectoryInfo(@"C:\Users\boyko.ma1683\source\repos\2pk2_Boyko_Maksim\pz_26\data");

            foreach (var derol in dr.GetFiles())
            {
                listbox1.Items.Add(derol.Name);
            }
        }
        public string FileName
        {
            get { return Search.Text; }
        }

        private void listbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}