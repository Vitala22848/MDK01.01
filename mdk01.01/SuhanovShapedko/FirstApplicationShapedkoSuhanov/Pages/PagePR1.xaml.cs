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
    /// Логика взаимодействия для PagePR1.xaml
    /// </summary>
    public partial class PagePR1 : Page
    {
        public PagePR1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(txtX.Text);
            double y = Convert.ToDouble(txtY.Text);
            double z = Convert.ToDouble(txtZ.Text);

            double gamma = 5 * Math.Atan(x) - 0.25 * Math.Acos(x) * (x + 3 * Math.Abs(x - y) + (x * x)) / (Math.Abs(x - y) * z + (x * x));

            lstResult.Items.Add("ПР1 ИСП 21.2А Суханов, Шапедько");
            lstResult.Items.Add("Вариант-7");
            lstResult.Items.Add($"x={x}");
            lstResult.Items.Add($"y={y}");
            lstResult.Items.Add($"z={z}");
            lstResult.Items.Add($"результат gamma={gamma}");
        }
    }
}
