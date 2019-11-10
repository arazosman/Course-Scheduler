using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace YM
{
    public partial class FormLoginScreen : Form
    {
        public FormLoginScreen()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Equals("admin") && textBoxPassword.Text.Equals("admin"))
            {
                Helper.userType = UserType.admin;
                openUserScreen();
            }
            else
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
                {
                    mySqlConn.Open();
                    MySqlCommand cmd = new MySqlCommand("getUserType", mySqlConn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_nickname", textBoxID.Text);
                    cmd.Parameters.AddWithValue("_password", textBoxPassword.Text);

                    var returnParameter = cmd.Parameters.Add("@ReturnVal", MySqlDbType.Int32);
                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();
                    var result = returnParameter.Value;

                    if (result.Equals(0) || result.Equals(1))
                    {
                        if (result.Equals(0))
                            Helper.userType = UserType.student;
                        else
                            Helper.userType = UserType.teacher;

                        openUserScreen();
                    }
                    else
                        labelError.Visible = true;
                }
            }
        }

        private void openUserScreen()
        {
            Helper.nickname = textBoxID.Text;

            FormUserScreen userScreen = new FormUserScreen();
            this.Hide();
            userScreen.Show();
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            FormNewUser formNewUser = new FormNewUser();
            formNewUser.Show();
        }
    }
}