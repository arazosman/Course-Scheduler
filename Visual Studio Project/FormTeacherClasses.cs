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
    public partial class FormTeacherClasses : Form
    {
        public FormTeacherClasses()
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
                MySqlDataAdapter sqlDA = new MySqlDataAdapter("viewClasses", mySqlConn);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dgvTeacherClasses.DataSource = dt;

                foreach (DataGridViewColumn col in dgvTeacherClasses.Columns)
                    col.ReadOnly = true;

                dt.Columns.Add("checkCell", typeof(bool));
                dgvTeacherClasses.Columns["checkCell"].HeaderText = "Onay";

                foreach (DataGridViewColumn col in dgvTeacherClasses.Columns)
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                foreach (DataGridViewRow row in dgvTeacherClasses.Rows)
                {
                    MySqlCommand cmd = new MySqlCommand("isTeacherClass", mySqlConn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_classID", row.Cells[0].Value);
                    cmd.Parameters.AddWithValue("_teacherNickname", Helper.selectedNickname);

                    var returnParameter = cmd.Parameters.Add("@ReturnVal", MySqlDbType.Int32);
                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();
                    var result = returnParameter.Value;

                    if (result.Equals(1))
                        row.Cells["checkCell"].Value = true;
                }

                dgvTeacherClasses.Columns[0].Visible = false;
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
            {
                mySqlConn.Open();

                foreach (DataGridViewRow row in dgvTeacherClasses.Rows)
                {
                    MySqlCommand cmd = new MySqlCommand("updateTeacherClass", mySqlConn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_classID", row.Cells[0].Value);
                    cmd.Parameters.AddWithValue("_teacherNickname", Helper.selectedNickname);
                    cmd.Parameters.AddWithValue("addOrNot", row.Cells["checkCell"].Value);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Öğretmen dersleri güncellendi.", "Bilgi");
                this.Close();
            }
        }
    }
}