using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969Assessment
{
    public partial class LoginPage : Form
    {
        MainScreen mainScreen = new MainScreen();
        bool isSpanish = CultureInfo.CurrentCulture.TwoLetterISOLanguageName.ToLower().Equals("en");

        public LoginPage()
        {

            InitializeComponent();
            if (isSpanish)
            {
                usernameLabel.Text = "Nombre de usuario";
                passwordLabel.Text = "Contraseña";
                loginBtn.Text = "Iniciar";
                clearBtn.Text = "Borrar";
                welcomeMsg.Text = "Bienvenidos!\nPor favor, entre su información\npara iniciar sesión";
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Get user input
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            // Connect to database, set up 
            string connectionStr = "server=localhost;uid=c969test;pwd=c969test;database=c969db";
            MySqlConnection conn = new MySqlConnection(connectionStr);
            MySqlDataReader reader;
            MySqlCommand cmd = new MySqlCommand($"SELECT username, password FROM user WHERE username IN('{username}') AND password IN('{password}')", conn);
            conn.Open();

            // Set filepath for log file
            string fileDir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);
            string filePath = System.IO.Path.Combine(fileDir, "c969logfile.txt");



           

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                if (isSpanish)
                {
                    MessageBox.Show("Credenciales de inicio aceptados", "Inicio de session correcto!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Login credentials accepted.", "Login successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                File.AppendAllText(filePath, $"USER {username} SUCCESSFULLY LOGGED IN AT {DateTime.Now}\n");
                mainScreen.Show();
                this.Hide();
            }
            else
            {
                if (isSpanish)
                {
                    MessageBox.Show("Credenciales de inicio rechazados.", "Inicio de session incorrecto!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Login credentials not accepted.\nPlease check your username and password.", "Login unsuccessful!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                File.AppendAllText(filePath, $"USER {username} FAILED LOGIN ATTEMPT AT {DateTime.Now}\n");
            }
              
        }
    }
}
