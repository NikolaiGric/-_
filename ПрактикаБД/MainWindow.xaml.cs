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

using ПрактикаБД.Practic_restDataSet1TableAdapters;
 

namespace ПрактикаБД
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewsiTableAdapter viewsi = new ViewsiTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }


        private void DataSet_Click(object sender, RoutedEventArgs e)
        {
            DataSet window = new DataSet();
            window.Show();
        }

        private void EntityFramework_Click(object sender, RoutedEventArgs e)
        {
            EntityFramework window = new EntityFramework();
            window.Show();
        }
    }
}
