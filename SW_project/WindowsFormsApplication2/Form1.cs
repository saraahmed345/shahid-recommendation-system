using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace shahid
{
    public partial class Form1 : Form
    {


        ContentReport1 CR;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CR = new ContentReport1();
            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
                content_cmb.Items.Add(v.Value);
        }

      

        private void GenerateReport_btn_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, content_cmb.Text);
            crystalReportViewer1.ReportSource = CR;
        }

        private void watch_list_transfer_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

           
            form2.Show();

        }
    }
}
