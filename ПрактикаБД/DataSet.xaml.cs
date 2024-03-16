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
using System.Windows.Shapes;
using ПрактикаБД.Practic_restDataSet1TableAdapters;


namespace ПрактикаБД
{
    /// <summary>
    /// Логика взаимодействия для DataSet.xaml
    /// </summary>
    public partial class DataSet : Window
    {
        ViewsiTableAdapter viewsi = new ViewsiTableAdapter();
        public DataSet()
        {
            InitializeComponent();
            AllDataGrid.ItemsSource = viewsi.GetData();
        }
    }
}
