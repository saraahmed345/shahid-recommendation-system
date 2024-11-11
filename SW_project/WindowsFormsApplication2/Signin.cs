using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsApplication2
{
    public partial class Signin : Form
    {
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;

        public Signin()
        {
            InitializeComponent();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "Check_User_Info";

            // Input parameters
            command.Parameters.Add("p_username", OracleDbType.Varchar2).Value = textBox1.Text;
            command.Parameters.Add("p_password", OracleDbType.Varchar2).Value = textBox2.Text;

            // Output parameter
            command.Parameters.Add("p_message", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;

            try
            {
                command.ExecuteNonQuery();

                // Get the output message
                string message = command.Parameters["p_message"].Value.ToString();
                
                if (message == "Wrong information please try again")
                {
                    MessageBox.Show(message);
                }
                else if (textBox1.Text == "0" && textBox2.Text == "root")
                {
                    this.Hide();

                    Admin dashboard = new Admin();

                    dashboard.Show();
                }
                else
                {
                    this.Hide();

                    Shahid Shahid_ = new Shahid();
 
                    Shahid_.Show();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
