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
            LoadOrders();
            LoadSales();
            LoadCustomers();
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
        private void LoadOrders()
        {
            // Clear Items from the ListView
            listViewOrder.Items.Clear();

            // Create column names at the top of the ListViewItem
            listViewOrder.Columns.Add("Order Id", 100);
            listViewOrder.Columns.Add("Student Id", 140);
            listViewOrder.Columns.Add("Drink Id", 140);
            listViewOrder.Columns.Add("Order Date", 150);
            listViewOrder.Columns.Add("Voucher", 60);
        }

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

            listViewOrder.Items.Clear();

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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowRevenuePanel();
        }
        // Sales
        private void ShowRevenuePanel()
        {
            pnlOrder.Hide();
            pnlRevenue.Show();

            // Get selected dateStart and dateEnd
            string dateStart = monthCalendarStart.SelectionRange.Start.ToString();
            string dateEnd = monthCalendarEnd.SelectionRange.Start.ToString();

            try
            {
                // get and display revenue
                List<Sale> orders = GetSales(dateStart, dateEnd);
                List<Customer> customers = GetCustomers(dateStart, dateEnd);
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
        private void LoadSales()
        {
            listViewSales.Clear();

            // Create column names at the top of the ListViewSales
            listViewSales.Columns.Add("ID", 40);
            listViewSales.Columns.Add("Product Name", 150);
            listViewSales.Columns.Add("Amount Sold", 120);
        }

        private List<Sale> GetSales(string dateStart, string dateEnd)
        {
            RevenueService revenueService = new RevenueService();
            List<Sale> sales = revenueService.GetSales(dateStart, dateEnd);
            return sales;
        }

        private void DisplaySales(List<Sale> sales)
        {
            // Clear Items from the ListView
            listViewSales.Items.Clear();

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
        private void LoadCustomers()
        {
            listViewCustomers.Clear();

            // Create column names at the top of the ListViewSales
            listViewCustomers.Columns.Add("ID", 40);
            listViewCustomers.Columns.Add("Full Name", 150);
            listViewCustomers.Columns.Add("Amount Bought", 120);
        }

        private List<Customer> GetCustomers(string dateStart, string dateEnd)
        {
            RevenueService revenueService = new RevenueService();
            List<Customer> customers = revenueService.GetCustomers(dateStart, dateEnd);
            return customers;
        }

        private void DisplayCustomers(List<Customer> customers)
        {
            // Clear Items from the ListView
            listViewCustomers.Items.Clear();

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
