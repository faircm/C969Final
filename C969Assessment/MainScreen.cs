using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969Assessment
{
    public partial class MainScreen : Form
    {
        AppointmentScreen appointmentScreen = new AppointmentScreen();
        public MainScreen()
        {
            InitializeComponent();
        }

        private void appointmentsBtn_Click(object sender, EventArgs e)
        {
            appointmentScreen.Show();
            this.Hide();
        }
    }
}
