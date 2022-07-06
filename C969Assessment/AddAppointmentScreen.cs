using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C969Assessment
{
    public partial class AddAppointmentScreen : Form
    {
        public AddAppointmentScreen()
        {
            InitializeComponent();
            apptIdBox.Text = "blah"; //autopopulate id here based on most recent id in db
            userIdBox.Text = "blah"; //autopopulate id here based on current user 
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString();
            try
            {
                Appointment newAppt = new Appointment(Int32.Parse(apptIdBox.Text), Int32.Parse(custIdBox.Text), Int32.Parse(userIdBox.Text), titleBox.Text, descBox.Text, locationBox.Text, contactBox.Text, typeBox.Text, urlBox.Text, DateTime.Parse(startBox.Text), DateTime.Parse(endBox.Text), DateTime.Now, createdByBox.Text, DateTime.Now, lastUpdateByBox.Text);

                Appointment.apptList.Add(newAppt);
            } catch(FormatException)
            {
                MessageBox.Show("All fields must be filled out correctly before continuing.", "Error adding appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Hide();
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
