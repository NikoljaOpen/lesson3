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
using QuadrLibray;

namespace lesson3.pages
{
    /// <summary>
    /// Логика взаимодействия для quadrPage.xaml
    /// </summary>
    public partial class quadrPage : Page
    {
        public quadrPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(aBox.Text);
            double b = double.Parse(bBox.Text);
            double c = double.Parse(cBox.Text);

            Quadr cuadr = new Quadr(a, b, c);

            RezultLabel.Content = cuadr.get();
        }
    }
}
