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
    public partial class CancelReservation : Form
    {
        int ReservationId;
        public CancelReservation(int index)
        {
            InitializeComponent();
            ReservationId = index;
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            var db = new DataAccess();
            db.CancelReservation(ReservationId);
            this.Close();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
