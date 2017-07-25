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

namespace WpfMarcel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Data data;
        public MainWindow()
        {
            InitializeComponent();
            data = new Data();
            this.DataContext = data;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A: " + data.A + "B: " + data.B);
        }
    }
}
