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

namespace AP.task2._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                double d = Convert.ToDouble(TbF.Text);
                double y = Convert.ToDouble(TbY.Text);
               
                MessageBox.Show($"F={Math.Log10(d) + (3.5*Math.Pow(d, 2) + 1) / (Math.Cos(2*y))}");
            }
            catch (Exception)
            {
                MessageBox.Show("*В ВАС КИНУЛИ ССАНОЙ ТРЯПКОЙ*");
            }



        }
    }
}
