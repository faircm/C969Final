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
    public partial class AppointmentScreen : Form
    {
        AddAppointmentScreen addAppointmentScreen = new AddAppointmentScreen();
        public AppointmentScreen()
        {
            InitializeComponent();
        }

        private void addApptBtn_Click(object sender, EventArgs e)
        {
            addAppointmentScreen.Show();
        }
    }
}
