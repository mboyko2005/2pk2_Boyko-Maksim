using Microsoft.SqlServer.Server;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace pz_26
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isBold;
        bool isItal;
        bool isUnd;
        public static bool Save_ON = false;
        private string ReadMessage;

        public string filename { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            SearchFileWindow searceFileWindow = new SearchFileWindow();
            if (searceFileWindow.ShowDialog() == true)
                filename = searceFileWindow.FileName;
        }
        private void New_Click(object sender, RoutedEventArgs e)
        {
            CreateFileWindow createFileWindow = new CreateFileWindow();
            if (createFileWindow.ShowDialog() == true)
                filename = createFileWindow.FileName;
            StreamWriter ss = new StreamWriter($@"C:\Users\boyko.ma1683\source\repos\2pk2_Boyko_Maksim\pz_26\data/{filename}.txt");
            ss.Close();
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter($@"C:\Users\boyko.ma1683\source\repos\2pk2_Boyko_Maksim\pz_26\data/{filename}.txt");
            sw.WriteLine(textbox1.Text);
            sw.Close();
            Save_ON = true;
        }
        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == true)
            {
                textbox1.Text = File.ReadAllText(openFile.FileName);
            }
            DateTime time = File.GetCreationTime(openFile.FileName);
            FileInfo info = new FileInfo(openFile.FileName);
            idl.Text = $"{time}  Размер: {info.Length} Б";
            
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Save_ON = false;
        }
        private void italicc_Click(object sender, RoutedEventArgs e)
        {
            if (!isItal)
                textbox1.FontStyle = FontStyles.Italic;
            else
                textbox1.FontStyle = FontStyles.Normal;
            isItal = !isItal;
        }
        private void blodd(object sender, RoutedEventArgs e)
        {
            if (!isBold)
                textbox1.FontWeight = FontWeights.Bold;
            else 
                textbox1.FontWeight = FontWeights.Normal;
            isBold = !isBold;
        }
        private void underr(object sender, RoutedEventArgs e)
        {
            if (!isUnd)
                textbox1.TextDecorations = TextDecorations.Underline;
            else
                textbox1.TextDecorations = null;
            isUnd = !isUnd;
        }
        private void txtEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (!Save_ON)
            {
                int row = textbox1.GetLineIndexFromCharacterIndex(textbox1.CaretIndex);
                int col = textbox1.CaretIndex - textbox1.GetCharacterIndexFromLineIndex(row);
                ibl.Text = $"Строка: {row} Столбец: {col} Трубется Сохранение";
            }
            if (Save_ON)
            {
                int row = textbox1.GetLineIndexFromCharacterIndex(textbox1.CaretIndex);
                int col = textbox1.CaretIndex - textbox1.GetCharacterIndexFromLineIndex(row);
                ibl.Text = $"Строка: {row} Столбец: {col} Сохранено";
            }
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
        private void textbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int index = textbox1.SelectionStart;
                textbox1.Text = textbox1.Text.Substring(0, textbox1.SelectionStart) + Environment.NewLine
                    + textbox1.Text.Substring(textbox1.SelectionStart);
                textbox1.SelectionStart = textbox1.Text.Length;
            }
        } 
        private void textbox1_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void CursorPosition_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void CursorPosition_KeyUp(object sender, KeyEventArgs e)
        {

        }

    }
}
