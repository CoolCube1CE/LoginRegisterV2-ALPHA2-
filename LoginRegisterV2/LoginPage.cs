using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace LoginRegisterV2
{
    public partial class LoginPage : Form
    {

        SqlConnection sqlConnect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ICE\Documents\LoginRegisterDB.mdf;Integrated Security=True;Connect Timeout=30");

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void buttonloginRegister_Click(object sender, EventArgs e)
        {

            RegisterPage register = new RegisterPage();
            register.Show();
            this.Hide();

        }

        private void labelloginExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void buttonloginLogin_Click(object sender, EventArgs e)
        {



            if (textBoxloginEM.Text == "" || textBoxloginPW.Text == "")
            {
                MessageBox.Show("Please fill in all the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {





                if (sqlConnect.State != ConnectionState.Open)
                {
                    try
                    {
                        sqlConnect.Open();

                        string selectAccount = "SELECT * FROM admin WHERE email = @email AND Password = @password";
                        using (SqlCommand process = new SqlCommand(selectAccount, sqlConnect))
                        {
                            process.Parameters.AddWithValue("@email", textBoxloginEM.Text);
                            process.Parameters.AddWithValue("@password", textBoxloginPW.Text);

                            SqlDataAdapter adapter = new SqlDataAdapter(process);
                            DataTable table = new DataTable();
                            adapter.Fill(table);




                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logged In Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                SuccessfulLogin loggedin = new SuccessfulLogin();
                                loggedin.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }





                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnect.Close();
                    }
                }




            }







        }

        private void buttonshowlogPW_Click(object sender, EventArgs e)
        {
            textBoxloginPW.PasswordChar = '\0';
            buttonhidelogPW.BringToFront();
        }

        private void buttonhidelogPW_Click(object sender, EventArgs e)
        {
            textBoxloginPW.PasswordChar = '*';
            buttonshowlogPW.BringToFront();
        }
    }
}
