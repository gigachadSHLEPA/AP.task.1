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
    /// Логика взаимодействия для AP1.xaml
    /// </summary>
    public partial class AP1 : Page
    {
        public AP1()
        {
            InitializeComponent();
        }
        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                double d = Convert.ToDouble(TbF1.Text);
                double y = Convert.ToDouble(TbY1.Text);
                    MessageBox.Show($"F={Math.Log10(d) + (3.5 * Math.Pow(d, 2) + 1) / (Math.Cos(2 * y))}");
                }
                catch (Exception)
                {
                    MessageBox.Show("*В ВАС КИНУЛИ ССАНОЙ ТРЯПКОЙ*");
                }
            

        }
        private void BtnBack1_Click(object sender, RoutedEventArgs e)
        {
            Coreee.MyCore?.Navigate(new MainPage());
        }
    }
}
