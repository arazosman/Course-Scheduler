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
    public partial class FormNewUser : Form
    {
        public FormNewUser()
        {
            InitializeComponent();
            radioButtonStudent.Checked = true;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Trim().Length > 0 && textBoxSurname.Text.Trim().Length > 0 &&
                textBoxNickname.Text.Trim().Length > 0 && textBoxPassword.Text.Trim().Length > 0)
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
                {
                    mySqlConn.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("addOrUpdatePerson", mySqlConn);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;

                    mySqlCmd.Parameters.AddWithValue("_nickname", textBoxNickname.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_password", textBoxPassword.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_fname", textBoxName.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_lname", textBoxSurname.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_mobilePhone", textBoxMobile.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_homePhone", textBoxHome.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_address", textBoxAddress.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_email", textBoxEmail.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_isTeacher", radioButtonTeacher.Checked);
                    mySqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Yeni Kayıt Oluşturuldu.", "Mesaj");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen zorunlu (*) alanları doğru şekilde doldurun.", "Uyarı");
            }
        }
    }
}
