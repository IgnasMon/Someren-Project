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
    public partial class RoomsUI : Form
    {
        public RoomsUI()
        {
            InitializeComponent();
            ShowRoomsPanel();
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoomsPanel();
        }

        private void ShowRoomsPanel()
        {

            try
            {
                // get and display all lecturers
                List<Room> rooms = GetRooms();
                DisplayRooms(rooms);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }

        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
            return rooms;
        }

        private void DisplayRooms(List<Room> rooms)
        {
            // clear the listview before filling it
            listViewRooms.Clear();

            listViewRooms.Columns.Add("Room Id", 100);
            listViewRooms.Columns.Add("Capacity", 160);
            listViewRooms.Columns.Add("Floor", 160);
            listViewRooms.Columns.Add("Building", 160);


            foreach (Room room in rooms)
            {
                ListViewItem rvi = new ListViewItem(room.Id.ToString());
                rvi.Tag = room;   // link lecturer object to listview item
                rvi.SubItems.Add(room.capacity.ToString());
                rvi.SubItems.Add(room.floor.ToString());
                rvi.SubItems.Add(room.building.ToString());
                listViewRooms.Items.Add(rvi);
            }
        }
    }
}
