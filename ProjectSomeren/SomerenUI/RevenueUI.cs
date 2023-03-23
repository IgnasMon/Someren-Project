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
            //ShowOrdersPanel();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOrdersPanel();
        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRevenuePanel();
        }
    //Orders
        private void ShowOrdersPanel()
        {
            pnlRevenue.Hide();
            pnlOrder.Show();

            try
            {   // get and display all orders
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
            RevenueService orderService = new RevenueService();
            List<Order> orders = orderService.GetOrders();
            return orders;
        }

        private void DisplayOrders(List<Order> orders)
        {
            // clear the listview before filling it
            listViewOrder.Clear();

            // Create column names at the top of the ListViewItem
            listViewOrder.Columns.Add("Order Id", 100);
            listViewOrder.Columns.Add("Student Id", 140);
            listViewOrder.Columns.Add("Drink Id", 140);
            listViewOrder.Columns.Add("Order Date", 150);
            listViewOrder.Columns.Add("Voucher", 60);

            // Fill in the Revenue table with entries from the DB 
            foreach (Order order in orders)
            {
                ListViewItem lvi = new ListViewItem(order.ID.ToString());
                lvi.Tag = order;   // link order object to listview item
                lvi.SubItems.Add(order.StudentID.ToString());
                lvi.SubItems.Add(order.DrinkID.ToString());
                lvi.SubItems.Add(order.OrderDate.ToString());
                lvi.SubItems.Add(order.Voucher.ToString());
                listViewOrder.Items.Add(lvi);
            }
        }
    // Orders - END

    // Revenue
        // Sales
        private void ShowRevenuePanel()
        {
            pnlOrder.Hide();
            pnlRevenue.Show();

            try
            {
                // get and display revenue
                List<Sale> orders = GetSales();
                List<Customer> customers = GetCustomers();
                //DisplayRevenue(orders);
                DisplayRevenue(orders, customers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the revenue: " + e.Message);
            }
        }

        //private void DisplayRevenue(List<Sale> sales)
        private void DisplayRevenue(List<Sale> sales, List<Customer> customers)
        {
            DisplaySales(sales);
            DisplayCustomers(customers);
        }

        // Sales
        private List<Sale> GetSales()
        {
            RevenueService revenueService = new RevenueService();
            List<Sale> sales = revenueService.GetSales();
            return sales;
        }

        private void DisplaySales(List<Sale> sales)
        {
            listViewSales.Clear();

            // Create column names at the top of the ListViewSales
            listViewSales.Columns.Add("ID", 40);
            listViewSales.Columns.Add("Product Name", 110);
            listViewSales.Columns.Add("Amount Sold", 70);

            // Fill in the Revenue table with entries from the DB 
            foreach (Sale sale in sales)
            {
                ListViewItem lviSales = new ListViewItem(sale.ID.ToString());
                lviSales.Tag = sale;   // link revenue object to listview item
                lviSales.SubItems.Add(sale.Name.ToString());
                lviSales.SubItems.Add(sale.Amount.ToString());
                listViewSales.Items.Add(lviSales);
            }
        }

        // Customers
        private List<Customer> GetCustomers()
        {
            RevenueService revenueService = new RevenueService();
            List<Customer> customers = revenueService.GetCustomers();
            return customers;
        }

        private void DisplayCustomers(List<Customer> customers)
        {
            listViewCustomers.Clear();

            // Create column names at the top of the ListViewSales
            listViewCustomers.Columns.Add("ID", 40);
            listViewCustomers.Columns.Add("Student Name", 110);
            listViewCustomers.Columns.Add("Amount Bought", 70);

            foreach (Customer customer in customers)
            {
                ListViewItem lviCustomers = new ListViewItem(customer.ID.ToString());
                lviCustomers.Tag = customer;   // link revenue object to listview item
                lviCustomers.SubItems.Add(customer.FullName.ToString());
                lviCustomers.SubItems.Add(customer.Amount.ToString());
                listViewCustomers.Items.Add(lviCustomers);
            }
        }
    }
}
