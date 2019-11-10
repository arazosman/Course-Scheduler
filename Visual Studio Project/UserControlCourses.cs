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
    public partial class UserControlCourses : UserControl
    {
        public static int courseID = 0;

        public UserControlCourses()
        {
            InitializeComponent();
            clearForm();
            dateTimePicker.CustomFormat = "      dd - MM - yyyy";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Value = DateTime.Now;
            dateTimePicker.MinDate = DateTime.Now;

            if (Helper.userType != UserType.admin)
            {
                buttonAddCourse.Visible = buttonClearCourse.Visible = buttonDeleteCourse.Visible = false;
            }
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            int weeks, price;

            if (textBoxCourseName.Text.Trim().Length > 0 && Int32.TryParse(textBoxCoursePrice.Text.Trim(), out price)
                && Int32.TryParse(textBoxCourseWeeks.Text.Trim(), out weeks))
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
                {
                    mySqlConn.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("addOrUpdateCourse", mySqlConn);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;

                    mySqlCmd.Parameters.AddWithValue("_courseID", courseID);
                    mySqlCmd.Parameters.AddWithValue("_courseName", textBoxCourseName.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_courseWeeks", Int32.Parse(textBoxCourseWeeks.Text.Trim()));
                    mySqlCmd.Parameters.AddWithValue("_price", textBoxCoursePrice.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_courseBeg", dateTimePicker.Text.Trim());
                    mySqlCmd.ExecuteNonQuery();

                    MessageBox.Show(courseID == 0 ? "Yeni kurs eklendi." : "Kurs güncellendi.", "Mesaj");
                    clearForm();
                }
            }
            else
            {
                MessageBox.Show("Lütfen zorunlu (*) alanları doğru şekilde doldurun.", "Uyarı");
            }
        }

        private void fillGrid()
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
            {
                mySqlConn.Open();
                MySqlDataAdapter sqlDA = new MySqlDataAdapter("viewCourses", mySqlConn);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dgvCourses.DataSource = dt;
                dgvCourses.Columns[0].Visible = false;
            }
        }

        private void clearForm()
        {
            textBoxCourseName.Text = textBoxCourseWeeks.Text = textBoxCoursePrice.Text = textBoxSearchCourse.Text = "";
            courseID = 0;
            buttonAddCourse.Text = "Ekle";
            buttonCourseSelectClasses.Text = "Önce Kurs Ekleyin / Görüntüleyin";
            buttonCourseSelectClasses.Enabled = false;
            buttonDeleteCourse.Enabled = false;
            fillGrid();
        }

        private void buttonDeleteCourse_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kurs silinsin mi?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
                {
                    mySqlConn.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("deleteCourse", mySqlConn);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;

                    mySqlCmd.Parameters.AddWithValue("_courseID", courseID);
                    mySqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Kurs silindi.", "Mesaj");
                    clearForm();
                }
            }
        }

        private void dgvCourses_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCourses.CurrentRow != null)
            {
                courseID = Convert.ToInt32(dgvCourses.CurrentRow.Cells[0].Value.ToString());
                textBoxCourseName.Text = dgvCourses.CurrentRow.Cells[1].Value.ToString();
                textBoxCoursePrice.Text = dgvCourses.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker.Value = (System.DateTime) dgvCourses.CurrentRow.Cells[3].Value;
                textBoxCourseWeeks.Text = dgvCourses.CurrentRow.Cells[4].Value.ToString();
                buttonAddCourse.Text = "Güncelle";
                buttonCourseSelectClasses.Text = "Dersleri Seçin / Görüntlüleyin";
                buttonCourseSelectClasses.Enabled = true;
                buttonDeleteCourse.Enabled = true;
            }
        }

        private void buttonCleanCourse_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void buttonSearchCourse_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
            {
                mySqlConn.Open();
                MySqlDataAdapter sqlDA = new MySqlDataAdapter("searchCourse", mySqlConn);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("_searchValue", textBoxSearchCourse.Text);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dgvCourses.DataSource = dt;
                dgvCourses.Columns[0].Visible = false;
            }
        }

        private void buttonCourseSelectClasses_Click(object sender, EventArgs e)
        {
            FormCourseClasses courseClasses = new FormCourseClasses();
            courseClasses.Show();
        }
    }
}
