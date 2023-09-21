using System;
using System.Collections.Generic;
using System.IO;
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

namespace FirstApplicationShapedkoSuhanov.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePR6.xaml
    /// </summary>
    public partial class PagePR6 : Page
    {
        public PagePR6()
        {
            InitializeComponent();
        }

        private void BtnListFromFile_Click(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader(@"Строки.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                lstInput.Items.Add(sr.ReadLine());
            }
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            lstInput.Items.Add("Выполнили Суханов А. С. и Шапедько В. А.");
            lstInput.Items.Add("Вариант-6");
            try
            {
                int index = lstInput.SelectedIndex;
                string str = (string)lstInput.Items[index];
                string line = str;

                for (char c = 'a'; c <= 'z'; c++)
                    str = str.Replace(c, '+');

                for (char c = 'A'; c <= 'Z'; c++)
                    str = str.Replace(c, '+');

                txbResult.Text = str;
                StreamWriter sw = new StreamWriter(@"Result.txt");
                sw.WriteLine($"Номер строки: {index}");
                sw.WriteLine($"исходная строка: {line}");
                sw.WriteLine($"Новая строка: {txbResult.Text}");
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lstInput.Items.Clear();
        }
    }
}
