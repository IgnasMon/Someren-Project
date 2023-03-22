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
    public partial class DrinkUI : Form
    {
        public DrinkUI()
        {
            InitializeComponent();
            ShowDrinksPanel();
        }

        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void refreshToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowDrinksPanel();
        }

        private void ShowDrinksPanel()
        {
            try
            {
                // get and display all lecturers
                List<Drink> drinks = GetDrinks();
                DisplayDrinks(drinks);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the drinks: " + e.Message);
            }
        }

        private List<Drink> GetDrinks()
        {
            DrinkService drinkService = new DrinkService();
            List<Drink> drinks = drinkService.GetDrinks();
            return drinks;
        }

        private void DisplayDrinks(List<Drink> drinks)
        {
            // clear the listview before filling it
            listViewDrinks.Clear();

            // Create column names at the top of the ListViewItem
            listViewDrinks.Columns.Add("Drink Id", 80);
            listViewDrinks.Columns.Add("Name", 120);
            listViewDrinks.Columns.Add("Is Alcoholic", 100);
            listViewDrinks.Columns.Add("Price", 60);
            listViewDrinks.Columns.Add("Amount", 80);

            // Fill in the Drink table with entries from the DB 
            foreach (Drink drink in drinks)
            {
                ListViewItem lvi = new ListViewItem(drink.Drink_ID.ToString());
                lvi.Tag = drink;   // link drink object to listview item
                lvi.SubItems.Add(drink.Name.ToString());
                lvi.SubItems.Add(drink.Is_Alcoholic.ToString());
                lvi.SubItems.Add(drink.Price.ToString());
                lvi.SubItems.Add(drink.Amount.ToString());
                listViewDrinks.Items.Add(lvi);
            }
        }
    }
}
