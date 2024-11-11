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
    public partial class Welcome : Form
    {

        
        public Welcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Instantiate the SignIn form
            Signin signInForm = new Signin();

            // Show the SignIn form
            signInForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Instantiate the SignIn form
            Signup signupForm = new Signup();

            // Show the SignIn form
            signupForm.Show();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
