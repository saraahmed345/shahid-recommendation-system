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
    public partial class Film : Form
    {
        string ordb = "Data source =orcl; User Id=scott ; Password =tiger;";
        OracleConnection conn;
        public Film()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            comboBoxTitles.Items.Clear();
            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT Title FROM Content WHERE Genre = :Genre";
            command.Parameters.Add("Genre", OracleDbType.Varchar2).Value = txtGenre.Text;

            OracleDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                comboBoxTitles.Items.Add(dr[0]);
            }
            dr.Close();
        }
    }
}
