using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsApplication2
{
    
    public partial class Signup : Form
    {
        readonly string ordb = "Data source =orcl; User Id=scott ; Password =tiger;";
        OracleConnection conn;
        
        public Signup()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO User_Info (UserID, Username, Email, Password, RegistrationDate) VALUES (:UserID, :Username, :Email, :Password, :RegistrationDate)";
            command.Parameters.Add("UserID", OracleDbType.Int32).Value = txt_UserID.Text;
            command.Parameters.Add("Username", OracleDbType.Varchar2).Value = txt_UserName.Text;
            command.Parameters.Add("Email", OracleDbType.Varchar2).Value = txt_UserEmail.Text;
            command.Parameters.Add("Password", OracleDbType.Varchar2).Value = txt_Password.Text;
            command.Parameters.Add("RegistrationDate", OracleDbType.Date).Value = DateTime.Now;
            
            //conn.Open();
            command.ExecuteNonQuery();
            //conn.Close();
            MessageBox.Show("successful");
            
            this.Hide();

            // Instantiate the SignIn form
            Shahid Shahid_ = new Shahid();

            // Show the SignIn form
            Shahid_.Show();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }
    }
}
