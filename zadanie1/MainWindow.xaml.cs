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

namespace zadanie1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            double x1, x2, y, z;
            x1 = Convert.ToDouble(Max.Text);
            x2 = Convert.ToDouble(Min.Text);
            z = Convert.ToDouble(s.Text);

            while (x2 <= x1)
            {
                y = -0.23 * Math.Pow(x2, 2) + x2;
                answer.Text += Convert.ToString("x= " + x2 + "   " + "y= " + y + "\n");
                x2 += z;
            }
        }
    }
}
