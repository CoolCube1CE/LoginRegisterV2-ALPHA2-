using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LoginRegisterV2
{
    public partial class RegisterPage : Form
    {
        SqlConnection sqlConnect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ICE\Documents\LoginRegisterDB.mdf;Integrated Security=True;Connect Timeout=30");

        public RegisterPage()
        {
            InitializeComponent();
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {
        }

        private void buttonregisterBack_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }

        private void labelregisterExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonregisterRegister_Click(object sender, EventArgs e)
        {


            int min = 5;

            int minNum09 = 11;
            int maxNum09 = 11;
            int minNum63 = 13;
            int maxNum63 = 13;

            DateTime userbd = dateTimeBirthDate.Value;
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - userbd.Year;

            bool valid = true;
            bool notBlank = true;


            if (textBoxFN.Text == "")
            {
                labelinvalidFN.Text = "Full Name is required";
                notBlank = false;
            }
            else if (!Regex.IsMatch(textBoxFN.Text, @"^[a-z A-Z'-]+$"))
            {
                labelinvalidFN.Text = "Invalid, must only contain letters, hypens, and apostrophes";
                valid = false;
            }
            else if (textBoxFN.Text.Length < min)
            {
                labelinvalidFN.Text = "Full Name is too short";
            }
            else if (valid && notBlank)
            {

                labelinvalidFN.Text = "";
            }



            if (textBoxAdd.Text == "")
            {
                labelinvalidAdd.Text = "Address is required";
                notBlank = false;
            }
            else if (!Regex.IsMatch(textBoxAdd.Text, @"^[a-zA-Z0-9!#$%&'*+-/=?^_`{|}~,]+$"))
            {
                labelinvalidAdd.Text = "Invalid address";
                valid = false;
            }
            else if (valid && notBlank)
            {
                labelinvalidAdd.Text = "";
            }
            else if (textBoxAdd.Text.Length < min)
            {
                labelinvalidAdd.Text = "Addess is too short";
            }



            if (textBoxEM.Text == "")
            {
                labelinvalidEM.Text = "E-mail is required";
                notBlank = false;
            }
            else if (!Regex.IsMatch(textBoxEM.Text, @"^[a-zA-Z0-9!#$%&'*+-/=?^_`{|}~,@]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                labelinvalidEM.Text = "Invalid E-mail";
                valid = false;
            }
            else if (textBoxEM.Text.Length < min)
            {
                labelinvalidEM.Text = "E-mail is too short";
            }
            else if (valid && notBlank)
            {
                labelinvalidEM.Text = "";
            }



            if (textBoxNum.Text == "")
            {
                labelinvalidNum.Text = "Phone Number is required";
                notBlank = false;
            }
            else if (Regex.IsMatch(textBoxNum.Text, @"^09[0-9]{9}$"))
            {
                labelinvalidNum.Text = "";
            }
            else if (Regex.IsMatch(textBoxNum.Text, @"^\+639[0-9]{9}$"))
            {
                labelinvalidNum.Text = "";

            }
            else
            {
                labelinvalidNum.Text = "Invalid Phone Number. Must be in the format 09XXXXXXXXX or +639XXXXXXXXX";
                valid = false;
            }


            if (userbd.AddYears(age) < currentDate)
            {
                labelinvalidBD.Text = "Invalid Birthdate. You must be at least 18 years old.";
            }
            else
            {
                labelinvalidBD.Text = "";
            }



            if (comboBoxAcc.Text == "")
            {
                labelAccess.Text = "Access Type is required";
            }

            if (textBoxregisterPW.Text == "")
            {
                labelinvalidPW.Text = "Password is required";
            }

            if (textBoxregisterCPW.Text == "")
            {
                labelinvalidCPW.Text = "Confirm Password is required";
            }


            else
            {




                if (sqlConnect.State != ConnectionState.Open)
                {
                    try
                    {
                        sqlConnect.Open();
                        string validateEmailadd = "SELECT * FROM admin WHERE email = '" + textBoxEM.Text.Trim() + "'";

                        using (SqlCommand validateEmail = new SqlCommand(validateEmailadd, sqlConnect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(validateEmail);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(textBoxEM.Text + " already exist", "Error Message", MessageBoxButtons.OK);
                            }
                            else
                            {
                                string insertINFO = "INSERT INTO admin (fullname, birthdate, address, email, number, accesstype, password)" +
                                    "VALUES(@fullname, @birthdate, @address, @email, @number, @accesstype, @password)";

                                using (SqlCommand process = new SqlCommand(insertINFO, sqlConnect))
                                {
                                    process.Parameters.AddWithValue("@fullname", textBoxFN.Text.Trim());
                                    process.Parameters.AddWithValue("@birthdate", dateTimeBirthDate.Text.Trim());
                                    process.Parameters.AddWithValue("@address", textBoxAdd.Text.Trim());
                                    process.Parameters.AddWithValue("@email", textBoxEM.Text.Trim());
                                    process.Parameters.AddWithValue("@number", textBoxNum.Text.Trim());
                                    process.Parameters.AddWithValue("@accesstype", comboBoxAcc.Text.Trim());
                                    process.Parameters.AddWithValue("@password", textBoxregisterPW.Text.Trim());

                                    process.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                    LoginPage loginpage = new LoginPage();
                                    loginpage.Show();
                                    this.Hide();

                                }
                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting" + ex, "Error  Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnect.Close();
                    }

                }








            }








        }




        private void buttonshowregPW_Click(object sender, EventArgs e)
        {
            textBoxregisterPW.PasswordChar = '\0';
            buttonhideregPW.BringToFront();
        }

        private void buttonhideregPW_Click(object sender, EventArgs e)
        {
            textBoxregisterPW.PasswordChar = '*';
            buttonshowregPW.BringToFront();
        }

        private void buttonshowregCPW_Click(object sender, EventArgs e)
        {
            textBoxregisterCPW.PasswordChar = '\0';
            buttonhideregCPW.BringToFront();
        }

        private void buttonhideregCPW_Click(object sender, EventArgs e)
        {
            textBoxregisterCPW.PasswordChar = '*';
            buttonshowregCPW.BringToFront();
        }
    }
}
