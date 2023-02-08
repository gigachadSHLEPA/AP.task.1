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
    /// Логика взаимодействия для AP15.xaml
    /// </summary>
    public partial class AP15 : Page
    {
        public AP15()
        {
            InitializeComponent();
        }
        private void BtnAnswer2_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                double t = Convert.ToDouble(TbF2.Text);
                double r = Convert.ToDouble(TbY2.Text);
                double y = Convert.ToDouble(TbT2.Text);
                MessageBox.Show($"W={(4*Math.Pow(t,3) + Math.Log10(r))/ (Math.Exp(y + r) + 7.2*Math.Sin(r))}");
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
