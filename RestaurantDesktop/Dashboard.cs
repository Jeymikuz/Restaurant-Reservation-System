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
            var db = new DataAccess();
            //reservations = db.GetAllReservations();
            //reservations = reservations.OrderByDescending(p => p.ReservationID).ToList();
            InitializeComponent();
            UpdateBinding();


        }

        private void UpdateBinding()
        {
            //ReservationFoundListBox.DataSource = reservations;
            //ReservationFoundListBox.DisplayMember = "FullInfo";

            dataGridView1.DataSource = reservations.OrderByDescending(p=>p.ReservationID).ToList();           
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((bool)row.Cells["Accepted"].Value == true)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
                }

                if((DateTime)row.Cells["ReservationExpire"].Value < DateTime.Now)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var db = new DataAccess();

            if (FirstNameTextBox.Text != "" && LastNameTextBox.Text != "")
            {
                reservations = db.GetReservationsByFirstNameAndLastName(FirstNameTextBox.Text, LastNameTextBox.Text);
                UpdateBinding();
            }
            else if (FirstNameTextBox.Text != "" && LastNameTextBox.Text == "")
            {
                reservations = db.GetReservationsByFirstName(FirstNameTextBox.Text);
                UpdateBinding();
            }
            else if (FirstNameTextBox.Text == "" && LastNameTextBox.Text != "")
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

        private void AddReservationButton_Click(object sender, EventArgs e)
        {
            var r = new NewReservation();
            r.Show();

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            var db = new DataAccess();

            reservations = db.GetAllReservations();
            //reservations = reservations.OrderByDescending(p => p.ReservationID).ToList();
            UpdateBinding();
        }

        private void acceptBtn_OnClick(object sender, EventArgs e)
        {
            try
            {
                var db = new DataAccess();
                var selectedIndex = dataGridView1;

                if (dataGridView1.SelectedRows.Count != 0)
                {
                    DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                    var test = row.Cells["ReservationID"].Value;
                    db.ResevationAccepted((int)test);
                    
                    MessageBox.Show("Poprawnie akceptowano");
                    reservations = db.GetAllReservations();
                    //reservations = reservations.OrderByDescending(p => p.ReservationID).ToList();
                    UpdateBinding();
                }
                else MessageBox.Show("Nie wybrano żadnego klienta");


            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void NewTableBtn_OnClick(object sender, EventArgs e)
        {
            var t = new NewTable();
            t.Show();
        }
    }
}
