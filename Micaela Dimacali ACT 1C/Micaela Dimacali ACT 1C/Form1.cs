using MySql.Data.MySqlClient;
namespace Micaela_Dimacali_ACT_1C
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=micaelaadb;username=root;password=;");
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if(string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)) 
            {
                MessageBox.Show("Please Enter Username and Password");
                return;
            }
            try
            {
                connection.Open();
                string loginquery = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";

                MySqlCommand command = new MySqlCommand(loginquery, connection);

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int count =Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Successfully Login!");
                    admin adminpage = new admin();
                    adminpage.Show();
                    this.Hide();

                }
                else 
                {
                    MessageBox.Show("Invalid username and passowrd");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally 
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                { 
                connection.Close();
                }
            }
        }
    }
}
