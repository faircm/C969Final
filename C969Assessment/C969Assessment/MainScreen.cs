using System;
using System.Windows.Forms;

namespace C969Assessment
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            userApptList.DataSource = Appointment.getCurrentUserAppts();
            Appointment.appointmentReminder();
        }

        private void appointmentsBtn_Click(object sender, EventArgs e)
        {
            AppointmentScreen appointmentScreen = new AppointmentScreen();
            appointmentScreen.Show();
        }

        private void closeBtn_click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void customersBtn_Click(object sender, EventArgs e)
        {
            CustomerScreen customerScreen = new CustomerScreen();
            customerScreen.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            userApptList.DataSource = null;
            userApptList.DataSource = Appointment.getCurrentUserAppts();
        }
    }
}
