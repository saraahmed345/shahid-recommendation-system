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
    public partial class Whatch_list : Form
    {
        OracleDataAdapter adapter;
        DataSet dataset;
        public void SetDataGridViewData(DataTable data)
        {
            dataGridView1.DataSource = data;
        }
        public Whatch_list()
        {
            InitializeComponent();
        }


        private void Whatch_list_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=orcl;User Id=scott;Password=tiger;";
            string selectQuery = "Select * From Watchlist_info";

            using (OracleConnection connection = new OracleConnection(connString))
            {
                OracleDataAdapter adapter = new OracleDataAdapter(selectQuery, connection);

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                // Get the changes from the DataGridView
                DataTable changesDataTable = ((DataTable)dataGridView1.DataSource).GetChanges();

                if (changesDataTable != null)
                {
                    // Apply the changes to the DataSet
                    dataSet.Merge(changesDataTable);

                    // Create the UpdateCommand
                    OracleCommandBuilder commandBuilder = new OracleCommandBuilder(adapter);
                    adapter.UpdateCommand = commandBuilder.GetUpdateCommand();

                    // Update the database with the changes
                    adapter.Update(dataSet);

                    // Accept changes after updating the database
                    ((DataTable)dataGridView1.DataSource).AcceptChanges();

                    MessageBox.Show("Changes successfully saved to the database.");
                }
                else
                {
                    MessageBox.Show("No changes to save.");
                }
            }
        }



        

       
    }
}
