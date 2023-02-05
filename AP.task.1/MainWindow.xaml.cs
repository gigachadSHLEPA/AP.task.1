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

namespace AP.task._1
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
            double f = Convert.ToDouble(TbF.Text);
            double y = Convert.ToDouble(TbY.Text);
            
            MessageBox.Show($"G={(Math.Exp(2*y) + Math.Sin(f)) / Math.Log10(3.8*y + f)}");
           
        }
    }
}
