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
using Practika1.KFCDataSetTableAdapters;

namespace Practika1
{
    public partial class OrdersPage : Page
    {
        ordersTableAdapter orders = new ordersTableAdapter();

        public OrdersPage()
        {
            InitializeComponent();
            ordersDataGrid.ItemsSource = orders.GetData();
        }
    }
}
