using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969Assessment
{
    class Appointment
    {
        public int appointmentId { get; set; }
        public int customerId { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string contact { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public DateTime createDate { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastUpdateBy { get; set; }

        public static string connectionStr = "server=localhost;uid=c969test;pwd=c969test;database=c969db";
        public static MySqlConnection conn = new MySqlConnection();
        public static MySqlDataReader reader;
        public static MySqlScript script = new MySqlScript();
        public static MySqlCommand cmd = new MySqlCommand("SELECT * FROM appointment", conn);

        public static List<Appointment> apptList = getAppts();
        public Appointment()
        {

        }
        public Appointment(int appointmentId, int customerId, int userId, string title, string description, string location, string contact, string type, string url, DateTime start, DateTime end, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            this.appointmentId = appointmentId;
            this.customerId = customerId;
            this.userId = userId;
            this.title = title;
            this.description = description;
            this.location = location;
            this.contact = contact;
            this.type = type;
            this.url = url;
            this.start = start;
            this.end = end;
            this.createDate = createDate;
            this.createdBy = createdBy;
            this.lastUpdate = lastUpdate;
            this.lastUpdateBy = lastUpdateBy;

           // MySqlCommand addCmd = new MySqlCommand($"INSERT INTO appointment VALUES ({appointmentId}{customerId}{userId}{title}{description}{location}{contact}{type}{url}{start}{end}{createDate}{createdBy}{lastUpdate}{lastUpdateBy}", conn);
/*            conn.ConnectionString = connectionStr;
            conn.Open();
            script.Connection = conn;
            script.Query = $"INSERT INTO appointment VALUES ({appointmentId}{customerId}{userId}{title}{description}{location}{contact}{type}{url}{start}{end}{createDate}{createdBy}{lastUpdate}{lastUpdateBy}";
            script.Execute();*/

            apptList.Add(this);
        }

        public static List<Appointment> getAppts()
        {
            List<Appointment> appointments = new List<Appointment>();
            conn.ConnectionString = connectionStr;
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Appointment appointment = new Appointment();
                appointment.appointmentId = reader.GetInt32("appointmentId");
                appointment.customerId = reader.GetInt32("customerId");
                appointment.userId = reader.GetInt32("userId");
                appointment.title = reader.GetString("title");
                appointment.description = reader.GetString("description");
                appointment.location = reader.GetString("location");
                appointment.contact = reader.GetString("contact");
                appointment.type = reader.GetString("type");
                appointment.url = reader.GetString("url");
                appointment.start = reader.GetDateTime("start");
                appointment.end = reader.GetDateTime("end");
                appointment.createDate = reader.GetDateTime("createDate");
                appointment.createdBy = reader.GetString("createdBy");
                appointment.lastUpdate = reader.GetDateTime("lastUpdate");
                appointment.lastUpdateBy = reader.GetString("lastUpdateBy");

                appointments.Add(appointment);
                
            }
            conn.Close();

            return appointments;
        }
    }
}
