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
    public partial class FormStudentProfile : Form
    {
        public FormStudentProfile()
        {
            InitializeComponent();
            textBoxStudentNickname.Enabled = false;
            fillInfo();
        }

        private void fillInfo()
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
            {
                mySqlConn.Open();
                MySqlDataAdapter sqlDA = new MySqlDataAdapter("getPerson", mySqlConn);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("_nickname", Helper.nickname);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                textBoxStudentName.Text = dt.Rows[0][0].ToString();
                textBoxStudentSurname.Text = dt.Rows[0][1].ToString();
                textBoxStudentMobile.Text = dt.Rows[0][2].ToString();
                textBoxStudentHome.Text = dt.Rows[0][3].ToString();
                textBoxStudentEmail.Text = dt.Rows[0][4].ToString();
                textBoxStudentAddress.Text = dt.Rows[0][5].ToString();
                textBoxStudentNickname.Text = labelNickname.Text = Helper.nickname;
                textBoxStudentPassword.Text = dt.Rows[0][6].ToString();
            }
        }

        private void buttonUpdateStudent_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
            {
                mySqlConn.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("addOrUpdatePerson", mySqlConn);
                mySqlCmd.CommandType = CommandType.StoredProcedure;

                mySqlCmd.Parameters.AddWithValue("_nickname", textBoxStudentNickname.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_password", textBoxStudentPassword.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_fname", textBoxStudentName.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_lname", textBoxStudentSurname.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_mobilePhone", textBoxStudentMobile.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_homePhone", textBoxStudentHome.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_address", textBoxStudentAddress.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_email", textBoxStudentEmail.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_isTeacher", false);
                mySqlCmd.ExecuteNonQuery();

                MessageBox.Show("Bilgileriniz güncellendi.", "Mesaj");
                this.Close();
            }
        }

        private void buttonStudentSelectCourses_Click(object sender, EventArgs e)
        {
            Helper.selectedNickname = Helper.nickname;
            FormStudentCourses studentCourses = new FormStudentCourses();
            studentCourses.Show();
        }

        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hesabınız silinsin mi?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
                {
                    mySqlConn.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("deletePerson", mySqlConn);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;

                    mySqlCmd.Parameters.AddWithValue("_nickname", textBoxStudentNickname.Text.Trim());
                    mySqlCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Hesabınız silindi.", "Mesaj");
                this.Close();
                FormUserScreen.ActiveForm.Hide();
                new FormLoginScreen().Show();
            }
        }
    }
}