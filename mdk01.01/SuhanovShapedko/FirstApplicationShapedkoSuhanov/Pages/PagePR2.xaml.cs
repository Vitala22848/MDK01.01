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

namespace FirstApplicationShapedkoSuhanov.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePR2.xaml
    /// </summary>
    public partial class PagePR2 : Page
    {
        public PagePR2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            lstResult.Items.Clear();
            double x = double.Parse(txtX.Text);
            double y = double.Parse(txtY.Text);
            double z = double.Parse(txtZ.Text);
            double d = x + y + z;
            lstResult.Items.Add("Лаб.раб.№2. Выполнил Шапедько В.А.");
            lstResult.Items.Add("Вариант-4");
            lstResult.Items.Add($"X={x}");
            lstResult.Items.Add($"y={y}");
            lstResult.Items.Add($"z={z}");
            int n = 0;
            if (rbtSin.IsChecked == true) n = 1;
            else if (rbtSqrX.IsChecked == true) n = 2; 
            switch (n)
            {
                case 0:
                    if (x > y) d = Math.Pow(((Math.Exp(x) - Math.Exp(-x)) / 2) - y, 3) + Math.Atan((Math.Exp(x) - Math.Exp(-x)) / 2);
                    else if (x < y) d = Math.Pow(y - ((Math.Exp(x) - Math.Exp(-x)) / 2), 3) + Math.Atan((Math.Exp(x) - Math.Exp(-x)) / 2);
                    else d = Math.Pow(y + ((Math.Exp(x) - Math.Exp(-x)) / 2), 3) + 0.5;
                    lstResult.Items.Add($"Результат d={Math.Round(d, 3)}");
                    break;
                case 1:
                    if (x > y) d = Math.Pow(Math.Pow(x, 2) - y, 3) + Math.Atan(Math.Pow(x, 2));
                    else if (x < y) d = Math.Pow(y - Math.Pow(x, 2), 3) + Math.Atan(Math.Pow(x, 2));
                    else d = Math.Pow(y + (Math.Pow(x, 2)), 3) + 0.5;
                    lstResult.Items.Add($"Результат d={Math.Round(d, 3)}");
                    break;
                case 2:
                    if (x > y) d = Math.Pow(Math.Exp(x) - y, 3) + Math.Atan(Math.Exp(x));
                    else if (x < y) d = Math.Pow(y - Math.Exp(x), 3) + Math.Atan(Math.Exp(x));
                    else d = Math.Pow(y + (Math.Exp(x)), 3) + 0.5;
                    lstResult.Items.Add($"Результат d={Math.Round(d, 3)}");
                    break;
                default:
                    lstResult.Items.Add("Решение не найдено");
                    break;

            }

            
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtX.Clear();
            txtY.Clear();
            txtZ.Clear();
            lstResult.Items.Clear();
        }
    }
}
