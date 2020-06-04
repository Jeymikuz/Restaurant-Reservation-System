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
    public partial class DeleteTableConfirm : Form
    {
        int indexOfTable;
        public DeleteTableConfirm(int index)
        {
            InitializeComponent();

            indexOfTable = index;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            var db = new DataAccess();
            db.DeleteTable(indexOfTable);
            this.Close();
        }
    }
}
