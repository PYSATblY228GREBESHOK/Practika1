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
    public partial class MainWindow : Window
    {
        buyersTableAdapter buyers = new buyersTableAdapter();

        public MainWindow()
        {
            InitializeComponent();
            buyersDataGrid.ItemsSource = buyers.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OrdersPage ordersPage = new OrdersPage();

            this.Content = ordersPage;
        }
        private void Button_ClickEntity(object sender, RoutedEventArgs e)
        {
            OrdersEFPage ordersEFPage = new OrdersEFPage();

            this.Content = ordersEFPage;
        }
        private void Button_ClickEntityBuyers(object sender, RoutedEventArgs e)
        {
            BuyersEFPage buyersEFPage = new BuyersEFPage();

            this.Content = buyersEFPage;
        }
    }
}
