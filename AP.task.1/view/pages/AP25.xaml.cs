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
    /// Логика взаимодействия для AP25.xaml
    /// </summary>
    public partial class AP25 : Page
    {
        public AP25()
        {
            InitializeComponent();
        }
        private void BtnAnswer2_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                double m = Convert.ToDouble(TbF2.Text);
                double y = Convert.ToDouble(TbY2.Text);
                MessageBox.Show($"N={(Math.Pow(m,2) + 2.8*m + 0.355)/(Math.Cos(2*y) + 3.6)}");
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
