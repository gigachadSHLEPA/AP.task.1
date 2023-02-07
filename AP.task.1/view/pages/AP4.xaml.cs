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
    /// Логика взаимодействия для AP4.xaml
    /// </summary>
    public partial class AP4 : Page
    {
        public AP4()
        {
            InitializeComponent();
        }
        private void BtnAnswer2_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                double a = Convert.ToDouble(TbF2.Text);
                double y = Convert.ToDouble(TbY2.Text);
                double t = Convert.ToDouble(TbT2.Text);
                MessageBox.Show($"G={(7.8 * Math.Pow(a, 2) + 3.52*t)/(Math.Log10(a + 2*y) + Math.Exp(y))}");
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
