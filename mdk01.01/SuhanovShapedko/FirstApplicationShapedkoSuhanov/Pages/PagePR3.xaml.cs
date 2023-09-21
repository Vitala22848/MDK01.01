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
    /// Логика взаимодействия для PagePR3.xaml
    /// </summary>
    public partial class PagePR3 : Page
    {
        public PagePR3()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, RoutedEventArgs e)
        {
            lstResult.Items.Add("Выполнил Шапедько В. А.");
            lstResult.Items.Add("Вариант-24");
            double X0 = double.Parse(txtX0.Text);
            double Xk = double.Parse(txtXk.Text);
            double Dx = double.Parse(txtDx.Text);
            double a = double.Parse(txtax.Text);

            for (double x = X0; x < Xk; x += Dx)
            {
                double y = a * Math.Pow(Math.Abs(x), 5.0 / 2.0) + Math.Cos(Math.Sqrt(Math.Exp(x)));
                
                lstResult.Items.Add($"X={x}");
                lstResult.Items.Add($"Y={y}");
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            txtX0.Clear();
            txtDx.Clear();
            txtXk.Clear();
            lstResult.Items.Clear();
        }
    }
}
