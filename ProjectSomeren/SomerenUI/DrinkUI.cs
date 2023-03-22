using SomerenDAL;
using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class DrinkUI : Form
    {
        DrinkDao drinkDao = new DrinkDao();

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

        // Buttons

        // Create data in Database
        private void createButton_Click(object sender, EventArgs e)
        {
            // Variables
            // Should be optimised so it doesn't have to be copy pasted in every method..
            string drink_ID = drinkIdTextBox.Text;
            string name = nameTextBox.Text;
            string isAlcoholic;
            string price = priceTextBox.Text;
            string amount = amountTextBox.Text;

            bool isAlcoholicBool = isAlcoholicCheckBox.Checked;

            if (isAlcoholicBool == true)
                isAlcoholic = "1";
            else
                isAlcoholic = "0";

            // Create Query
            drinkDao.UpdateDrinks($"INSERT INTO dbo.drinks " +
                $"VALUES ({drink_ID}, '{name}', {isAlcoholic}, {price}, {amount}); ");

            // Refresh
            ShowDrinksPanel();
        }

        // Update data in Database
        private void updateButton_Click(object sender, EventArgs e)
        {
            // Variables
            // Should be optimised so it doesn't have to be copy pasted in every method..
            string drink_ID = drinkIdTextBox.Text;
            string name = nameTextBox.Text;
            string isAlcoholic;
            string price = priceTextBox.Text;
            string amount = amountTextBox.Text;

            bool isAlcoholicBool = isAlcoholicCheckBox.Checked;

            if (isAlcoholicBool == true)
                isAlcoholic = "1";
            else
                isAlcoholic = "0";

            // Update Query
            drinkDao.UpdateDrinks($"UPDATE dbo.drinks " +
                $"SET [name] = '{name}', " +
                $"is_Alcoholic = {isAlcoholic}, " +
                $"price = {price}, " +
                $"amount = {amount}" +
                $"WHERE drink_ID = '{drink_ID}'");

            // Refresh
            ShowDrinksPanel();
        }

        // Delete data in Database
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Variables
            string drink_ID = drinkIdTextBox.Text;

            // Delete Query
            drinkDao.UpdateDrinks($"DELETE FROM dbo.drinks " +
                $"WHERE drink_ID = {drink_ID}");

            // Refresh
            ShowDrinksPanel();
        }

        //Clear the Text Boxes
        private void clearTextBoxesButton_Click(object sender, EventArgs e)
        {
            drinkIdTextBox.Clear();
            nameTextBox.Clear();
            isAlcoholicCheckBox.Checked = false;
            priceTextBox.Clear();
            amountTextBox.Clear();
        }
    }
}
