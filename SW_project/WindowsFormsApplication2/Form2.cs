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
    public partial class Form2 : Form
    {

        ContentReport1 RF;
        public Form2()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RF= new ContentReport1();

        }

        private void generate_watchlist_Click(object sender, EventArgs e)
        {
            RF.SetParameterValue(0, watch_list_TB.Text);
            crystalReportViewer1.ReportSource = RF;


        }

        private void watch_list_TB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
