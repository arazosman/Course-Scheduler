using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace YM
{
    public partial class UserControlTeachers : UserControl
    {
        public UserControlTeachers()
        {
            InitializeComponent();
            clearForm();

            if (Helper.userType != UserType.admin)
            {
                buttonAddTeacher.Visible = buttonDeleteTeacher.Visible = buttonClearTeacher.Visible = label6.Visible =
                label7.Visible = textBoxTeacherNickname.Visible = textBoxTeacherPassword.Visible = false;
            }
        }

        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            if (textBoxTeacherName.Text.Trim().Length > 0 && textBoxTeacherSurname.Text.Trim().Length > 0 &&
                textBoxTeacherNickname.Text.Trim().Length > 0 && textBoxTeacherPassword.Text.Trim().Length > 0)
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

                    MessageBox.Show(buttonAddTeacher.Text.Equals("Ekle") ? "Yeni öğretmen eklendi." : "Öğretmen bilgileri güncellendi.", "Mesaj");
                    clearForm();
                    fillGrid();
                }
            }
            else
            {
                MessageBox.Show("Lütfen zorunlu (*) alanları doğru şekilde doldurun.", "Uyarı");
            }
        }

        private void clearForm()
        {
            fillGrid();
            textBoxTeacherNickname.Text = textBoxTeacherPassword.Text = textBoxTeacherName.Text =
            textBoxTeacherSurname.Text = textBoxTeacherMobile.Text = textBoxTeacherHome.Text =
            textBoxTeacherAddress.Text = textBoxTeacherEmail.Text = textBoxSearchTeacher.Text = "";
            buttonAddTeacher.Text = "Ekle";
            buttonTeacherSelectClasses.Text = "Önce Öğretmen Ekleyin / Görüntüleyin";
            buttonTeacherSelectClasses.Enabled = false;
            textBoxTeacherPassword.Enabled = true;
            textBoxTeacherNickname.Enabled = true;
            buttonDeleteTeacher.Enabled = false;
        }

        private void fillGrid()
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
            {
                mySqlConn.Open();
                MySqlDataAdapter sqlDA = new MySqlDataAdapter("viewPersons", mySqlConn);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("_isTeacher", true);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dgvTeachers.DataSource = dt;
                dgvTeachers.Columns[3].Visible = false;
                dgvTeachers.Columns[5].Visible = false;
                dgvTeachers.Columns[6].Visible = false;
                dgvTeachers.Columns[7].Visible = false;
            }
        }

        private void buttonClearTeacher_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void buttonDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Öğretmen silinsin mi?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
                {
                    mySqlConn.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("deletePerson", mySqlConn);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;

                    mySqlCmd.Parameters.AddWithValue("_nickname", textBoxTeacherNickname.Text.Trim());
                    mySqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Öğretmen silindi.", "Mesaj");
                    clearForm();
                }
            }
        }

        private void dgvTeachers_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTeachers.CurrentRow != null)
            {
                textBoxTeacherName.Text = dgvTeachers.CurrentRow.Cells[0].Value.ToString();
                textBoxTeacherSurname.Text = dgvTeachers.CurrentRow.Cells[1].Value.ToString();
                textBoxTeacherMobile.Text = dgvTeachers.CurrentRow.Cells[2].Value.ToString();
                textBoxTeacherHome.Text = dgvTeachers.CurrentRow.Cells[3].Value.ToString();
                textBoxTeacherEmail.Text = dgvTeachers.CurrentRow.Cells[4].Value.ToString();
                textBoxTeacherAddress.Text = dgvTeachers.CurrentRow.Cells[5].Value.ToString();
                textBoxTeacherNickname.Text = dgvTeachers.CurrentRow.Cells[6].Value.ToString();
                textBoxTeacherPassword.Text = dgvTeachers.CurrentRow.Cells[7].Value.ToString();
                Helper.selectedNickname = textBoxTeacherNickname.Text;
                buttonAddTeacher.Text = "Güncelle";
                buttonTeacherSelectClasses.Text = "Dersleri Seçin / Görüntlüleyin";
                buttonTeacherSelectClasses.Enabled = true;
                textBoxTeacherPassword.Enabled = false;
                textBoxTeacherNickname.Enabled = false;
                buttonDeleteTeacher.Enabled = true;
            }
        }

        private void buttonSearchTeacher_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
            {
                mySqlConn.Open();
                MySqlDataAdapter sqlDA = new MySqlDataAdapter("searchPerson", mySqlConn);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("_searchValue", textBoxSearchTeacher.Text);
                sqlDA.SelectCommand.Parameters.AddWithValue("_isTeacher", true);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dgvTeachers.DataSource = dt;
                dgvTeachers.Columns[3].Visible = false;
                dgvTeachers.Columns[5].Visible = false;
                dgvTeachers.Columns[6].Visible = false;
                dgvTeachers.Columns[7].Visible = false;
            }
        }

        private void buttonTeacherSelectClasses_Click(object sender, EventArgs e)
        {
            FormTeacherClasses teacherClasses = new FormTeacherClasses();
            teacherClasses.Show();
        }
    }
}