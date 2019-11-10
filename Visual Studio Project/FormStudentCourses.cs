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
    public partial class FormStudentCourses : Form
    {
        public FormStudentCourses()
        {
            InitializeComponent();
            fillGrid();

            if (Helper.nickname != "admin" && Helper.selectedNickname != Helper.nickname)
                buttonCheck.Visible = false;
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
                dgvStudentCourses.DataSource = dt;

                foreach (DataGridViewColumn col in dgvStudentCourses.Columns)
                    col.ReadOnly = true;

                dt.Columns.Add("checkCell", typeof(bool));
                dgvStudentCourses.Columns["checkCell"].HeaderText = "Onay";

                foreach (DataGridViewColumn col in dgvStudentCourses.Columns)
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                foreach (DataGridViewRow row in dgvStudentCourses.Rows)
                {
                    MySqlCommand cmd = new MySqlCommand("isStudentCourse", mySqlConn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_courseID", row.Cells[0].Value);
                    cmd.Parameters.AddWithValue("_studentNickname", Helper.selectedNickname);

                    var returnParameter = cmd.Parameters.Add("@ReturnVal", MySqlDbType.Int32);
                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();
                    var result = returnParameter.Value;

                    if (result.Equals(1))
                        row.Cells["checkCell"].Value = true;
                }

                dgvStudentCourses.Columns[0].Visible = false;
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
            {
                mySqlConn.Open();

                foreach (DataGridViewRow row in dgvStudentCourses.Rows)
                {
                    MySqlCommand cmd = new MySqlCommand("updateStudentCourse", mySqlConn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_courseID", row.Cells[0].Value.ToString().Trim());
                    cmd.Parameters.AddWithValue("_studentNickname", Helper.selectedNickname);
                    cmd.Parameters.AddWithValue("_price", row.Cells[2].Value.ToString().Trim());
                    cmd.Parameters.AddWithValue("addOrNot", row.Cells["checkCell"].Value);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Öğrenci kursları güncellendi.", "Bilgi");
                this.Close();
            }
        }
    }
}
