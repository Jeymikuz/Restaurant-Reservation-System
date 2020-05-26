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
        public NewTable()
        {
            InitializeComponent();
        }

        private void AddBtn_OnClick(object sender, EventArgs e)
        {
            var db = new DataAccess();
            try
            {
                db.AddNewTable(int.Parse(NumberOfChairsTekstBox.Text));
                MessageBox.Show("Poprawnie dodano stolik");
            }
            catch
            {
                MessageBox.Show("Błąd");
            }
            this.Close();
        }
    }
}
