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
    /// Логика взаимодействия для PagePR7.xaml
    /// </summary>
    public partial class PagePR7 : Page
    {
        public PagePR7()
        {
            InitializeComponent();
        }

        private void btnResultMas_Click(object sender, RoutedEventArgs e)
        {
            lstMasResult.Items.Add("Числа,Положительные в квадрате,отрицательные умноженны на 2");
            for (int i = 0; i < 15; i++)
            {
              
              
                {
                    double x = mas[i];
                    double y;

                    if (x >= 0)
                    {
                        y = Math.Pow(x, 2.0);
                    }
                    else
                    {
                        y = mas[i] * x * 2.0;
                    }

                    
                    lstMasResult.Items.Add(y);
                }

            }
        }

        int[] mas = new int[100];
        private void btnMas_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            string i1 = "";
            for (int i = 0; i < 15; i++)
            {
                mas[i] = rnd.Next (-50,50) ;
                i1 = "mas[" + i.ToString() + "] = " + mas[i].ToString();
                lstMas.Items.Insert(i, i1);
            }
        }
    }
}
