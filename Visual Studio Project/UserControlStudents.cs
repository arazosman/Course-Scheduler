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
    public partial class UserControlStudents : UserControl
    {
        public UserControlStudents()
        {
            InitializeComponent();
            clearForm();

            if (Helper.userType != UserType.admin)
            {
                buttonAddStudent.Visible = buttonDeleteStudent.Visible = buttonClearStudent.Visible = label6.Visible =
                label7.Visible = textBoxStudentNickname.Visible = textBoxStudentPassword.Visible = false;
            }
        }

        private void clearForm()
        {
            fillGrid();
            textBoxStudentNickname.Text = textBoxStudentPassword.Text = textBoxStudentName.Text =
            textBoxStudentSurname.Text = textBoxStudentMobile.Text = textBoxStudentHome.Text =
            textBoxStudentAddress.Text = textBoxStudentEmail.Text = textBoxSearchStudent.Text = "";
            buttonAddStudent.Text = "Ekle";
            buttonStudentSelectCourses.Text = "Önce Öğrenci Ekleyin / Seçin";
            buttonStudentSelectCourses.Enabled = false;
            textBoxStudentPassword.Enabled = true;
            textBoxStudentNickname.Enabled = true;
            buttonDeleteStudent.Enabled = false;
        }

        private void fillGrid()
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
            {
                mySqlConn.Open();
                MySqlDataAdapter sqlDA = new MySqlDataAdapter("viewPersons", mySqlConn);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("_isTeacher", false);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dgvStudents.DataSource = dt;
                dgvStudents.Columns[3].Visible = false;
                dgvStudents.Columns[5].Visible = false;
                dgvStudents.Columns[6].Visible = false;
                dgvStudents.Columns[7].Visible = false;
            }
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            if (textBoxStudentName.Text.Trim().Length > 0 && textBoxStudentSurname.Text.Trim().Length > 0 &&
                textBoxStudentNickname.Text.Trim().Length > 0 && textBoxStudentPassword.Text.Trim().Length > 0)
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

                    MessageBox.Show(buttonAddStudent.Text.Equals("Ekle") ? "Yeni öğrenci eklendi." : "Öğrenci bilgileri güncellendi.", "Mesaj");
                    clearForm();
                }
            }
            else
            {
                MessageBox.Show("Lütfen zorunlu (*) alanları doğru şekilde doldurun.", "Uyarı");
            }
        }

        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Öğrenci silinsin mi?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
                {
                    mySqlConn.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("deletePerson", mySqlConn);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;

                    mySqlCmd.Parameters.AddWithValue("_nickname", textBoxStudentNickname.Text.Trim());
                    mySqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Öğrenci silindi.", "Mesaj");
                    clearForm();
                }
            }
        }

        private void buttonClearStudent_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void dgvTeachers_DoubleClick(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow != null)
            {
                textBoxStudentName.Text = dgvStudents.CurrentRow.Cells[0].Value.ToString();
                textBoxStudentSurname.Text = dgvStudents.CurrentRow.Cells[1].Value.ToString();
                textBoxStudentMobile.Text = dgvStudents.CurrentRow.Cells[2].Value.ToString();
                textBoxStudentHome.Text = dgvStudents.CurrentRow.Cells[3].Value.ToString();
                textBoxStudentEmail.Text = dgvStudents.CurrentRow.Cells[4].Value.ToString();
                textBoxStudentAddress.Text = dgvStudents.CurrentRow.Cells[5].Value.ToString();
                textBoxStudentNickname.Text = dgvStudents.CurrentRow.Cells[6].Value.ToString();
                textBoxStudentPassword.Text = dgvStudents.CurrentRow.Cells[7].Value.ToString();
                Helper.selectedNickname = textBoxStudentNickname.Text;
                buttonAddStudent.Text = "Güncelle";
                buttonStudentSelectCourses.Text = "Kursları Seçin / Görüntlüleyin";
                buttonStudentSelectCourses.Enabled = true;
                textBoxStudentPassword.Enabled = false;
                textBoxStudentNickname.Enabled = false;
                buttonDeleteStudent.Enabled = true;
            }
        }

        private void buttonSearchStudent_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
            {
                mySqlConn.Open();
                MySqlDataAdapter sqlDA = new MySqlDataAdapter("searchPerson", mySqlConn);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("_searchValue", textBoxSearchStudent.Text);
                sqlDA.SelectCommand.Parameters.AddWithValue("_isTeacher", false);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dgvStudents.DataSource = dt;
                dgvStudents.Columns[3].Visible = false;
                dgvStudents.Columns[5].Visible = false;
                dgvStudents.Columns[6].Visible = false;
                dgvStudents.Columns[7].Visible = false;
            }
        }

        private void buttonStudentSelectCourses_Click(object sender, EventArgs e)
        {
            FormStudentCourses studentCourses = new FormStudentCourses();
            studentCourses.Show();
        }
    }
}