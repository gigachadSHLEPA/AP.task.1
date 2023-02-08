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

namespace AP.task._1.view.pages
{
    /// <summary>
    /// Логика взаимодействия для AP20.xaml
    /// </summary>
    public partial class AP20 : Page
    {
        public AP20()
        {
            InitializeComponent();
        }
        private void BtnAnswer2_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                double k = Convert.ToDouble(TbF2.Text);
                double p = Convert.ToDouble(TbY2.Text);
                double x = Convert.ToDouble(TbT2.Text);
                double d = Convert.ToDouble(TbD2.Text);
                MessageBox.Show($"Q={(Math.Sqrt(k+ 2.6*p*Math.Sin(k)))/(x - Math.Pow(d,3))}");
            }
            catch (Exception)
            {
                MessageBox.Show("*В ВАС КИНУЛИ ССАНОЙ ТРЯПКОЙ*");
            }


        }
        private void BtnBack2_Click(object sender, RoutedEventArgs e)
        {
            Coreee.MyCore?.Navigate(new MainPage());
        }
    }
}
