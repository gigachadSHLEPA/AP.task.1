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
    /// Логика взаимодействия для AP22.xaml
    /// </summary>
    public partial class AP22 : Page
    {
        public AP22()
        {
            InitializeComponent();
        }
        private void BtnAnswer2_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                double d = Convert.ToDouble(TbF2.Text);
                double y = Convert.ToDouble(TbY2.Text);
                MessageBox.Show($"R={(Math.Pow(Math.Sin(y), 2) + 0.3*d)/(Math.Exp(y) + Math.Log(d))}");
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
