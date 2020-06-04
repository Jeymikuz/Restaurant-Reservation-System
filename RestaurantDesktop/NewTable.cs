using RestaurantDesktop.Data;
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
    public partial class NewTable : Form
    {
        public List<Models.Table> tables = new List<Models.Table>();

        public NewTable()
        {
            InitializeComponent();
            InitTables();
            UpdateBinding();
        }

        private void AddBtn_OnClick(object sender, EventArgs e)
        {
            var db = new DataAccess();
            try
            {
                db.AddNewTable(int.Parse(NewNumberOfChairsTekstBox.Text));
                MessageBox.Show("Poprawnie dodano stolik");
                UpdateBinding();
            }
            catch
            {
                MessageBox.Show("Błąd");
                UpdateBinding();

            }

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InitTables()
        {
            var db = new DataAccess();
            tables = db.GetAllTable();
        }

        private void UpdateBinding()
        {
            //ReservationFoundListBox.DataSource = reservations;
            //ReservationFoundListBox.DisplayMember = "FullInfo";
            var db = new DataAccess();
            tables = db.GetAllTable();
            TableDataGridView.DataSource = tables;
            
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new DataAccess();
                var selectedIndex = TableDataGridView;

                if (TableDataGridView.SelectedRows.Count != 0 && EditNumberOfChairsTekstBox.Text!=null)
                {
                    DataGridViewRow row = this.TableDataGridView.SelectedRows[0];
                    var index = ((int)row.Cells["TableID"].Value);
                    var NumberOfChairs = int.Parse(EditNumberOfChairsTekstBox.Text);

                    db.UpdateTable(index, NumberOfChairs);
                    UpdateBinding();

                }
                else MessageBox.Show("Nie wybrano żadnego stolika");


            }
            catch
            {
                MessageBox.Show("Error");
                UpdateBinding();

            }
        }

        private void DeleteTableBtn_Click(object sender, EventArgs e)
        {
            var lastIndex = tables.LastOrDefault().TableID;
            var d = new DeleteTableConfirm(lastIndex);
            d.Show();
            d.FormClosed += DeleteTableConfirm_FormClosed;
        }

        void DeleteTableConfirm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateBinding();
        }
    }
}
