using SomerenDAL;
using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class RevenueUI : Form
    {
        public RevenueUI()
        {
            InitializeComponent();
            ShowRevenuePanel();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRevenuePanel();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowRevenuePanel()
        {
            try
            {
                // get and display all orders
                List<Order> orders = GetOrders();
                DisplayOrders(orders);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the orders: " + e.Message);
            }
        }

        private List<Order> GetOrders()
        {
            OrderService orderService = new OrderService();
            List<Order> orders = orderService.GetOrders();
            return orders;
        }

        private void DisplayOrders(List<Order> orders)
        {
            // clear the listview before filling it
            listViewRevenue.Clear();

            // Create column names at the top of the ListViewItem
            listViewRevenue.Columns.Add("Order Id", 100);
            listViewRevenue.Columns.Add("Student Id", 140);
            listViewRevenue.Columns.Add("Drink Id", 140);
            listViewRevenue.Columns.Add("Order Date", 150);
            listViewRevenue.Columns.Add("Voucher", 60);

            // Fill in the Revenue table with entries from the DB 
            foreach (Order order in orders)
            {
                ListViewItem lvi = new ListViewItem(order.ID.ToString());
                lvi.Tag = order;   // link revenue object to listview item
                lvi.SubItems.Add(order.StudentID.ToString());
                lvi.SubItems.Add(order.DrinkID.ToString());
                lvi.SubItems.Add(order.OrderDate.ToString());
                lvi.SubItems.Add(order.Voucher.ToString());
                listViewRevenue.Items.Add(lvi);
            }
        }

    }
}
