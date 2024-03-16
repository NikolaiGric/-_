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
    /// Логика взаимодействия для EntityFramework.xaml
    /// </summary>
    public partial class EntityFramework : Window
    {
        private Practic_restEntities1 context = new Practic_restEntities1();
        public EntityFramework()
        {
            InitializeComponent();
            AllDataGrid.ItemsSource = context.Viewsi.ToList();
        }
    }
}
