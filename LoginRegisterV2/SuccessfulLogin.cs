using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoginRegisterV2
{
    public partial class SuccessfulLogin : Form
    {
        public SuccessfulLogin()
        {
            InitializeComponent();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void labelloggedInExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
