using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YM
{
    public partial class FormUserScreen : Form
    {
        public FormUserScreen()
        {
            InitializeComponent();
            labelNickname.Text = Helper.nickname;
            userControlClasses1.Show();
            userControlCourses1.Hide();
            userControlTeachers1.Hide();
            userControlStudents1.Hide();

            if (Helper.userType == UserType.admin)
                buttonProfile.Visible = false;
        }

        private void buttonClasses_Click(object sender, EventArgs e)
        {
            userControlClasses1.Show();
            userControlCourses1.Hide();
            userControlTeachers1.Hide();
            userControlStudents1.Hide();
        }

        private void buttonCourses_Click(object sender, EventArgs e)
        {
            userControlCourses1.Show();
            userControlClasses1.Hide();
            userControlTeachers1.Hide();
            userControlStudents1.Hide();
        }

        private void buttonTeachers_Click(object sender, EventArgs e)
        {
            userControlTeachers1.Show();
            userControlCourses1.Hide();
            userControlClasses1.Hide();
            userControlStudents1.Hide();
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            userControlStudents1.Show();
            userControlCourses1.Hide();
            userControlTeachers1.Hide();
            userControlClasses1.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            FormLoginScreen loginScreen = new FormLoginScreen();
            loginScreen.Show();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            if (Helper.userType == UserType.student)
            {
                FormStudentProfile formStudentProfile = new FormStudentProfile();
                formStudentProfile.Show();
            }
            else if (Helper.userType == UserType.teacher)
            {
                FormTeacherProfile formTeacherProfile = new FormTeacherProfile();
                formTeacherProfile.Show();
            }
        }
    }
}