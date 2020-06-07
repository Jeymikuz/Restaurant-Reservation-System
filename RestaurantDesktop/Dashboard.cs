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
            InitColumns();


        }

        private void InitColumns()
        {
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[0].HeaderText = "Numer Rezerwacji";
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[1].HeaderText = "Numer Stolika";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[2].HeaderText = "Imię";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[3].HeaderText = "Nazwisko";
            dataGridView1.Columns[5].Width = 70;
            dataGridView1.Columns[5].HeaderText = "Telefon";
            dataGridView1.Columns[6].HeaderText = "Data Rezerwacji";
            dataGridView1.Columns[7].HeaderText = "Koniec rezerwacji";
            dataGridView1.Columns[8].Width = 60;
            dataGridView1.Columns[8].HeaderText = "Długość rezerwacji";
            dataGridView1.Columns[9].Width = 75;
            dataGridView1.Columns[9].HeaderText = "Akceptowane";
            dataGridView1.Columns[10].Width = 70;
            dataGridView1.Columns[10].HeaderText = "Anulowane";


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
                else if ((bool)row.Cells["Canceled"].Value == true)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
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
                    if (reservations[(int)test - 1].Accepted == false)
                    {
                        db.ResevationAccepted((int)test);

                        MessageBox.Show("Poprawnie akceptowano");
                        reservations = db.GetAllReservations();
                        //reservations = reservations.OrderByDescending(p => p.ReservationID).ToList();
                        UpdateBinding();
                    }
                    else {
                        MessageBox.Show("Rezerwacja jest juz zaakceptowana");
                    }

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
            var t = new EditTables();
            t.Show();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                var reservationId = row.Cells["ReservationID"].Value;
                if (reservations[(int)reservationId - 1].Canceled == false)
                {
                    var CancelReservationForm = new CancelReservation((int)reservationId);
                    CancelReservationForm.Show();
                    CancelReservationForm.FormClosed += CancelReservationForm_OnClose;

                }
                else
                {
                    MessageBox.Show("Rezerwacja jest juz anulowana");
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnej rezerwacji");
            }
        }

        private void CancelReservationForm_OnClose(object sender, FormClosedEventArgs e)
        {
            UpdateBinding();
        }
    }
}
