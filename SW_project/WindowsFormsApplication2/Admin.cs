using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsApplication2
{
    public partial class Admin : Form
    {
        string ordb = "Data source =orcl; User Id=scott ; Password =tiger;";
        OracleConnection conn;

        public Admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void add_new_content_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection(ordb);
                conn.Open();

                OracleCommand command = new OracleCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;

                string tags = "";

                foreach (object itemChecked in content_tags.CheckedItems)
                {
                    if (tags != "")
                        tags = tags + "," + itemChecked.ToString();
                    else
                        tags += itemChecked.ToString();
                }

                command.CommandText = @"INSERT INTO Content (title, type_content, con_description, genre, tags, releaseyear)
                    VALUES( :content_title, :content_type, :content_description, :content_genre, :content_tags, :content_year)";
                command.Parameters.Add("content_title", OracleDbType.Varchar2).Value = content_title.Text;
                command.Parameters.Add("content_type", OracleDbType.Varchar2).Value = content_type.SelectedItem.ToString();
                command.Parameters.Add("content_description", OracleDbType.Varchar2).Value = contetn_description.Text;
                command.Parameters.Add("content_genre", OracleDbType.Varchar2).Value = content_genre.SelectedItem.ToString();
                command.Parameters.Add("content_tags", OracleDbType.Varchar2).Value = tags;
                command.Parameters.Add("content_year", OracleDbType.Int16).Value = release_date.Value.Year;

                Console.WriteLine("Tags are: " + tags);

                command.ExecuteNonQuery();

                string message = string.Format("Done! We added ({0}) successfully", content_title.Text);

                MessageBox.Show(message);
                conn.Close();

                // clear form
                InitializeComponent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }
    }
}
