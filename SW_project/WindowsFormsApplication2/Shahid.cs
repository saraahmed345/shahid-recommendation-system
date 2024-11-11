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
    public partial class Shahid : Form
    {

        OracleDataAdapter adapter;
        DataSet dataset;
        public Shahid()
        {
            InitializeComponent();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            string conn = "Data Source=orcl;User Id=scott;Password=tiger;";
            string s = "Select * From Watchlist_info";
            adapter = new OracleDataAdapter(s,conn);
            dataset = new DataSet();
            adapter.Fill(dataset);
            Whatch_list whatch = new Whatch_list();
            whatch.SetDataGridViewData(dataset.Tables[0]);
            this.Hide();

            whatch.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            this.Hide();

            Film film = new Film();

            film.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newform1 = new Form1();

            Form2 newform2 = new Form2();
        }
    }
}
