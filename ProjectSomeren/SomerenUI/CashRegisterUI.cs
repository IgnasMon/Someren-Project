using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;
using SomerenService;

namespace SomerenUI
{
    public partial class CashRegisterUI : Form
    {
        public CashRegisterUI()
        {
            InitializeComponent();
            ShowStudentsPanel();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowStudentsPanel()
        {
            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Clear();

            listViewStudents.Columns.Add("Student Id", 100);
            listViewStudents.Columns.Add("Class", 60);
            listViewStudents.Columns.Add("First Name", 120);
            listViewStudents.Columns.Add("Last Name", 120);
            listViewStudents.Columns.Add("Telephone Number", 160);
            listViewStudents.Columns.Add("Room Id", 100);

            foreach (Student student in students)
            {
                ListViewItem lvi = new ListViewItem(student.StudentID.ToString());
                lvi.Tag = student;   // link student object to listview item
                lvi.SubItems.Add(student.Class.ToString());
                lvi.SubItems.Add(student.FirstName.ToString());
                lvi.SubItems.Add(student.LastName.ToString());
                lvi.SubItems.Add(student.TelephoneNumber.ToString());
                lvi.SubItems.Add(student.RoomID.ToString());
                listViewStudents.Items.Add(lvi);
            }

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

            // Create column names at the top of the ListViewItem
            listViewStudents.Columns.Add("Drink Id", 80);
            listViewStudents.Columns.Add("Name", 120);
            listViewStudents.Columns.Add("Is Alcoholic", 100);
            listViewStudents.Columns.Add("Price", 60);
            listViewStudents.Columns.Add("Amount", 80);

            // Fill in the Drink table with entries from the DB 
            foreach (Drink drink in drinks)
            {
                ListViewItem lvi = new ListViewItem(drink.Drink_ID.ToString());
                lvi.Tag = drink;   // link drink object to listview item
                lvi.SubItems.Add(drink.Name.ToString());
                lvi.SubItems.Add(drink.Is_Alcoholic.ToString());
                lvi.SubItems.Add(drink.Price.ToString());
                lvi.SubItems.Add(drink.Amount.ToString());
                listViewStudents.Items.Add(lvi);
            }
        }
    }
}
