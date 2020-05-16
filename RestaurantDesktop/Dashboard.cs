using RestaurantDesktop.Data;
using RestaurantDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantDesktop
{
    public partial class Dashboard : Form
    {

        List<Reservation> reservations = new List<Reservation>();

        public Dashboard()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            ReservationFoundListBox.DataSource = reservations;
            ReservationFoundListBox.DisplayMember = "FullInfo";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var db = new DataAccess();

            if(FirstNameTextBox.Text!= "" && LastNameTextBox.Text != "") {
                reservations = db.GetReservationsByFirstNameAndLastName(FirstNameTextBox.Text, LastNameTextBox.Text);
                UpdateBinding();
            }
            else if(FirstNameTextBox.Text!= "" && LastNameTextBox.Text == "")
            {
                reservations = db.GetReservationsByFirstName(FirstNameTextBox.Text);
                UpdateBinding();
            }
            else if(FirstNameTextBox.Text== "" && LastNameTextBox.Text != "")
            {
                reservations = db.GetReservationsByLastName(LastNameTextBox.Text);
                UpdateBinding();
            }
            else
            {
                reservations = null;
                UpdateBinding();
            }

            
        }
    }
}
