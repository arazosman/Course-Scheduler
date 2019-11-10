namespace YM
{
    partial class UserControlStudents
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlStudents));
            this.buttonStudentSelectCourses = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.labelTitleTeachers = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClearStudent = new System.Windows.Forms.Button();
            this.buttonSearchStudent = new System.Windows.Forms.Button();
            this.buttonDeleteStudent = new System.Windows.Forms.Button();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.textBoxSearchStudent = new System.Windows.Forms.TextBox();
            this.textBoxStudentPassword = new System.Windows.Forms.TextBox();
            this.textBoxStudentAddress = new System.Windows.Forms.TextBox();
            this.textBoxStudentHome = new System.Windows.Forms.TextBox();
            this.textBoxStudentSurname = new System.Windows.Forms.TextBox();
            this.textBoxStudentNickname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxStudentEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStudentMobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCourseClasses = new System.Windows.Forms.Label();
            this.labelTeacherName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStudentSelectCourses
            // 
            this.buttonStudentSelectCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudentSelectCourses.Location = new System.Drawing.Point(157, 383);
            this.buttonStudentSelectCourses.Name = "buttonStudentSelectCourses";
            this.buttonStudentSelectCourses.Size = new System.Drawing.Size(300, 26);
            this.buttonStudentSelectCourses.TabIndex = 44;
            this.buttonStudentSelectCourses.Text = "Kursları Seçin";
            this.buttonStudentSelectCourses.UseVisualStyleBackColor = true;
            this.buttonStudentSelectCourses.Click += new System.EventHandler(this.buttonStudentSelectCourses_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvStudents.ColumnHeadersHeight = 25;
            this.dgvStudents.Location = new System.Drawing.Point(485, 94);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(594, 380);
            this.dgvStudents.TabIndex = 61;
            this.dgvStudents.DoubleClick += new System.EventHandler(this.dgvTeachers_DoubleClick);
            // 
            // labelTitleTeachers
            // 
            this.labelTitleTeachers.AutoSize = true;
            this.labelTitleTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleTeachers.ForeColor = System.Drawing.Color.Indigo;
            this.labelTitleTeachers.Location = new System.Drawing.Point(152, 165);
            this.labelTitleTeachers.Name = "labelTitleTeachers";
            this.labelTitleTeachers.Size = new System.Drawing.Size(180, 29);
            this.labelTitleTeachers.TabIndex = 60;
            this.labelTitleTeachers.Text = "ÖĞRENCİLER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // buttonClearStudent
            // 
            this.buttonClearStudent.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonClearStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearStudent.ForeColor = System.Drawing.Color.White;
            this.buttonClearStudent.Location = new System.Drawing.Point(308, 441);
            this.buttonClearStudent.Name = "buttonClearStudent";
            this.buttonClearStudent.Size = new System.Drawing.Size(100, 40);
            this.buttonClearStudent.TabIndex = 47;
            this.buttonClearStudent.Text = "Temizle";
            this.buttonClearStudent.UseVisualStyleBackColor = false;
            this.buttonClearStudent.Click += new System.EventHandler(this.buttonClearStudent_Click);
            // 
            // buttonSearchStudent
            // 
            this.buttonSearchStudent.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchStudent.ForeColor = System.Drawing.Color.White;
            this.buttonSearchStudent.Location = new System.Drawing.Point(941, 26);
            this.buttonSearchStudent.Name = "buttonSearchStudent";
            this.buttonSearchStudent.Size = new System.Drawing.Size(138, 35);
            this.buttonSearchStudent.TabIndex = 49;
            this.buttonSearchStudent.Text = "Öğrenci Ara";
            this.buttonSearchStudent.UseVisualStyleBackColor = false;
            this.buttonSearchStudent.Click += new System.EventHandler(this.buttonSearchStudent_Click);
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.BackColor = System.Drawing.Color.Crimson;
            this.buttonDeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteStudent.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteStudent.Location = new System.Drawing.Point(182, 441);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(100, 40);
            this.buttonDeleteStudent.TabIndex = 46;
            this.buttonDeleteStudent.Text = "Sil";
            this.buttonDeleteStudent.UseVisualStyleBackColor = false;
            this.buttonDeleteStudent.Click += new System.EventHandler(this.buttonDeleteStudent_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStudent.ForeColor = System.Drawing.Color.White;
            this.buttonAddStudent.Location = new System.Drawing.Point(59, 441);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(100, 40);
            this.buttonAddStudent.TabIndex = 45;
            this.buttonAddStudent.Text = "Ekle";
            this.buttonAddStudent.UseVisualStyleBackColor = false;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // textBoxSearchStudent
            // 
            this.textBoxSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchStudent.Location = new System.Drawing.Point(485, 30);
            this.textBoxSearchStudent.Name = "textBoxSearchStudent";
            this.textBoxSearchStudent.Size = new System.Drawing.Size(432, 26);
            this.textBoxSearchStudent.TabIndex = 48;
            // 
            // textBoxStudentPassword
            // 
            this.textBoxStudentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentPassword.Location = new System.Drawing.Point(338, 339);
            this.textBoxStudentPassword.Name = "textBoxStudentPassword";
            this.textBoxStudentPassword.Size = new System.Drawing.Size(128, 26);
            this.textBoxStudentPassword.TabIndex = 43;
            // 
            // textBoxStudentAddress
            // 
            this.textBoxStudentAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentAddress.Location = new System.Drawing.Point(338, 299);
            this.textBoxStudentAddress.Name = "textBoxStudentAddress";
            this.textBoxStudentAddress.Size = new System.Drawing.Size(128, 26);
            this.textBoxStudentAddress.TabIndex = 41;
            // 
            // textBoxStudentHome
            // 
            this.textBoxStudentHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentHome.Location = new System.Drawing.Point(338, 259);
            this.textBoxStudentHome.Name = "textBoxStudentHome";
            this.textBoxStudentHome.Size = new System.Drawing.Size(128, 26);
            this.textBoxStudentHome.TabIndex = 39;
            // 
            // textBoxStudentSurname
            // 
            this.textBoxStudentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentSurname.Location = new System.Drawing.Point(338, 219);
            this.textBoxStudentSurname.Name = "textBoxStudentSurname";
            this.textBoxStudentSurname.Size = new System.Drawing.Size(128, 26);
            this.textBoxStudentSurname.TabIndex = 37;
            // 
            // textBoxStudentNickname
            // 
            this.textBoxStudentNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentNickname.Location = new System.Drawing.Point(100, 339);
            this.textBoxStudentNickname.Name = "textBoxStudentNickname";
            this.textBoxStudentNickname.Size = new System.Drawing.Size(128, 26);
            this.textBoxStudentNickname.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(248, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Şifre: *";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxStudentEmail
            // 
            this.textBoxStudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentEmail.Location = new System.Drawing.Point(100, 299);
            this.textBoxStudentEmail.Name = "textBoxStudentEmail";
            this.textBoxStudentEmail.Size = new System.Drawing.Size(128, 26);
            this.textBoxStudentEmail.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Adres:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxStudentMobile
            // 
            this.textBoxStudentMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentMobile.Location = new System.Drawing.Point(100, 259);
            this.textBoxStudentMobile.Name = "textBoxStudentMobile";
            this.textBoxStudentMobile.Size = new System.Drawing.Size(128, 26);
            this.textBoxStudentMobile.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Ev Tel.:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Kul. Adı: *";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentName.Location = new System.Drawing.Point(100, 219);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(128, 26);
            this.textBoxStudentName.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "E-Mail:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Soyisim: *";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Cep Tel.:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCourseClasses
            // 
            this.labelCourseClasses.AutoSize = true;
            this.labelCourseClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseClasses.Location = new System.Drawing.Point(25, 386);
            this.labelCourseClasses.Name = "labelCourseClasses";
            this.labelCourseClasses.Size = new System.Drawing.Size(114, 20);
            this.labelCourseClasses.TabIndex = 58;
            this.labelCourseClasses.Text = "Aldığı Kurslar:";
            this.labelCourseClasses.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTeacherName
            // 
            this.labelTeacherName.AutoSize = true;
            this.labelTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeacherName.Location = new System.Drawing.Point(11, 222);
            this.labelTeacherName.Name = "labelTeacherName";
            this.labelTeacherName.Size = new System.Drawing.Size(56, 20);
            this.labelTeacherName.TabIndex = 54;
            this.labelTeacherName.Text = "İsim: *";
            this.labelTeacherName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserControlStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonStudentSelectCourses);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.labelTitleTeachers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonClearStudent);
            this.Controls.Add(this.buttonSearchStudent);
            this.Controls.Add(this.buttonDeleteStudent);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.textBoxSearchStudent);
            this.Controls.Add(this.textBoxStudentPassword);
            this.Controls.Add(this.textBoxStudentAddress);
            this.Controls.Add(this.textBoxStudentHome);
            this.Controls.Add(this.textBoxStudentSurname);
            this.Controls.Add(this.textBoxStudentNickname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxStudentEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxStudentMobile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCourseClasses);
            this.Controls.Add(this.labelTeacherName);
            this.Name = "UserControlStudents";
            this.Size = new System.Drawing.Size(1100, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStudentSelectCourses;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label labelTitleTeachers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClearStudent;
        private System.Windows.Forms.Button buttonSearchStudent;
        private System.Windows.Forms.Button buttonDeleteStudent;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.TextBox textBoxSearchStudent;
        private System.Windows.Forms.TextBox textBoxStudentPassword;
        private System.Windows.Forms.TextBox textBoxStudentAddress;
        private System.Windows.Forms.TextBox textBoxStudentHome;
        private System.Windows.Forms.TextBox textBoxStudentSurname;
        private System.Windows.Forms.TextBox textBoxStudentNickname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxStudentEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStudentMobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCourseClasses;
        private System.Windows.Forms.Label labelTeacherName;
    }
}
