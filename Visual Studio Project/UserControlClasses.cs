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
    public partial class UserControlClasses : UserControl
    {
        int classID = 0;

        public UserControlClasses()
        {
            InitializeComponent();
            clearForm();

            if (Helper.userType != UserType.admin)
            {
                buttonAddClass.Visible = buttonClearClass.Visible = buttonDeleteClass.Visible = false;
            }
        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            int hours;

            if (textBoxClassName.Text.Trim().Length > 0 && Int32.TryParse(textBoxClassHours.Text.Trim(), out hours))
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
                {
                    mySqlConn.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("addOrUpdateClass", mySqlConn);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;

                    mySqlCmd.Parameters.AddWithValue("_classID", classID);
                    mySqlCmd.Parameters.AddWithValue("_className", textBoxClassName.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_classHours", hours);
                    mySqlCmd.ExecuteNonQuery();

                    MessageBox.Show(classID == 0 ? "Yeni ders eklendi." : "Ders güncellendi.", "Mesaj");
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
                MySqlDataAdapter sqlDA = new MySqlDataAdapter("viewClasses", mySqlConn);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dgvClasses.DataSource = dt;
                dgvClasses.Columns[0].Visible = false;
            }
        }

        private void clearForm()
        {
            textBoxClassName.Text = textBoxClassHours.Text = textBoxSearchClass.Text = "";
            classID = 0;
            buttonAddClass.Text = "Ekle";
            buttonDeleteClass.Enabled = false;
            fillGrid();
        }

        private void buttonDeleteClass_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ders silinsin mi?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
                {
                    mySqlConn.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("deleteClass", mySqlConn);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;

                    mySqlCmd.Parameters.AddWithValue("_classID", classID);
                    mySqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Ders silindi.", "Mesaj");
                    clearForm();
                }
            }
        }

        private void dgvClasses_DoubleClick(object sender, EventArgs e)
        {
            if (dgvClasses.CurrentRow.Index != -1)
            {
                classID = Convert.ToInt32(dgvClasses.CurrentRow.Cells[0].Value.ToString());
                textBoxClassName.Text = dgvClasses.CurrentRow.Cells[1].Value.ToString();
                textBoxClassHours.Text = dgvClasses.CurrentRow.Cells[2].Value.ToString();
                buttonAddClass.Text = "Güncelle";
                buttonDeleteClass.Enabled = true;
            }
        }

        private void buttonCleanClass_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void buttonSearchClass_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(Helper.connectionString))
            {
                mySqlConn.Open();
                MySqlDataAdapter sqlDA = new MySqlDataAdapter("searchClass", mySqlConn);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("_searchValue", textBoxSearchClass.Text);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dgvClasses.DataSource = dt;
                dgvClasses.Columns[0].Visible = false;
            }
        }
    }
}