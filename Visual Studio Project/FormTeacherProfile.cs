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
    public partial class FormTeacherProfile : Form
    {
        public FormTeacherProfile()
        {
            InitializeComponent();
            textBoxTeacherNickname.Enabled = false;
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
                textBoxTeacherName.Text = dt.Rows[0][0].ToString();
                textBoxTeacherSurname.Text = dt.Rows[0][1].ToString();
                textBoxTeacherMobile.Text = dt.Rows[0][2].ToString();
                textBoxTeacherHome.Text = dt.Rows[0][3].ToString();
                textBoxTeacherEmail.Text = dt.Rows[0][4].ToString();
                textBoxTeacherAddress.Text = dt.Rows[0][5].ToString();
                textBoxTeacherNickname.Text = labelNickname.Text = Helper.nickname;
                textBoxTeacherPassword.Text = dt.Rows[0][6].ToString();
            }
        }

        private void buttonUpdateStudent_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
            {
                mySqlConn.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("addOrUpdatePerson", mySqlConn);
                mySqlCmd.CommandType = CommandType.StoredProcedure;

                mySqlCmd.Parameters.AddWithValue("_nickname", textBoxTeacherNickname.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_password", textBoxTeacherPassword.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_fname", textBoxTeacherName.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_lname", textBoxTeacherSurname.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_mobilePhone", textBoxTeacherMobile.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_homePhone", textBoxTeacherHome.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_address", textBoxTeacherAddress.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_email", textBoxTeacherEmail.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_isTeacher", true);
                mySqlCmd.ExecuteNonQuery();

                MessageBox.Show("Bilgileriniz güncellendi.", "Mesaj");
                this.Close();
            }
        }

        private void buttonDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hesabınız silinsin mi?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
                {
                    mySqlConn.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("deletePerson", mySqlConn);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;

                    mySqlCmd.Parameters.AddWithValue("_nickname", textBoxTeacherNickname.Text.Trim());
                    mySqlCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Hesabınız silindi.", "Mesaj");
                this.Close();
                FormUserScreen.ActiveForm.Hide();
                new FormLoginScreen().Show();
            }
        }

        private void buttonTeacherSelectClasses_Click(object sender, EventArgs e)
        {
            Helper.selectedNickname = Helper.nickname;
            FormTeacherClasses teacherClasses = new FormTeacherClasses();
            teacherClasses.Show();
        }
    }
}
