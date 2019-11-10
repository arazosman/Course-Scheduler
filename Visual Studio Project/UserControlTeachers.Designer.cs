namespace YM
{
    partial class UserControlTeachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTeachers));
            this.buttonTeacherSelectClasses = new System.Windows.Forms.Button();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.labelTitleTeachers = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClearTeacher = new System.Windows.Forms.Button();
            this.buttonSearchTeacher = new System.Windows.Forms.Button();
            this.buttonDeleteTeacher = new System.Windows.Forms.Button();
            this.buttonAddTeacher = new System.Windows.Forms.Button();
            this.textBoxSearchTeacher = new System.Windows.Forms.TextBox();
            this.textBoxTeacherName = new System.Windows.Forms.TextBox();
            this.labelCourseClasses = new System.Windows.Forms.Label();
            this.labelTeacherName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTeacherSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTeacherMobile = new System.Windows.Forms.TextBox();
            this.textBoxTeacherHome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTeacherEmail = new System.Windows.Forms.TextBox();
            this.textBoxTeacherAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTeacherNickname = new System.Windows.Forms.TextBox();
            this.textBoxTeacherPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTeacherSelectClasses
            // 
            this.buttonTeacherSelectClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTeacherSelectClasses.Location = new System.Drawing.Point(165, 386);
            this.buttonTeacherSelectClasses.Name = "buttonTeacherSelectClasses";
            this.buttonTeacherSelectClasses.Size = new System.Drawing.Size(288, 26);
            this.buttonTeacherSelectClasses.TabIndex = 9;
            this.buttonTeacherSelectClasses.Text = "Dersleri Seçin";
            this.buttonTeacherSelectClasses.UseVisualStyleBackColor = true;
            this.buttonTeacherSelectClasses.Click += new System.EventHandler(this.buttonTeacherSelectClasses_Click);
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.AllowUserToAddRows = false;
            this.dgvTeachers.AllowUserToDeleteRows = false;
            this.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeachers.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTeachers.ColumnHeadersHeight = 25;
            this.dgvTeachers.Location = new System.Drawing.Point(484, 94);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.RowTemplate.Height = 24;
            this.dgvTeachers.Size = new System.Drawing.Size(594, 380);
            this.dgvTeachers.TabIndex = 35;
            this.dgvTeachers.DoubleClick += new System.EventHandler(this.dgvTeachers_DoubleClick);
            // 
            // labelTitleTeachers
            // 
            this.labelTitleTeachers.AutoSize = true;
            this.labelTitleTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleTeachers.ForeColor = System.Drawing.Color.Indigo;
            this.labelTitleTeachers.Location = new System.Drawing.Point(122, 162);
            this.labelTitleTeachers.Name = "labelTitleTeachers";
            this.labelTitleTeachers.Size = new System.Drawing.Size(210, 29);
            this.labelTitleTeachers.TabIndex = 34;
            this.labelTitleTeachers.Text = "ÖĞRETMENLER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // buttonClearTeacher
            // 
            this.buttonClearTeacher.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonClearTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearTeacher.ForeColor = System.Drawing.Color.White;
            this.buttonClearTeacher.Location = new System.Drawing.Point(307, 441);
            this.buttonClearTeacher.Name = "buttonClearTeacher";
            this.buttonClearTeacher.Size = new System.Drawing.Size(100, 40);
            this.buttonClearTeacher.TabIndex = 12;
            this.buttonClearTeacher.Text = "Temizle";
            this.buttonClearTeacher.UseVisualStyleBackColor = false;
            this.buttonClearTeacher.Click += new System.EventHandler(this.buttonClearTeacher_Click);
            // 
            // buttonSearchTeacher
            // 
            this.buttonSearchTeacher.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonSearchTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchTeacher.ForeColor = System.Drawing.Color.White;
            this.buttonSearchTeacher.Location = new System.Drawing.Point(940, 26);
            this.buttonSearchTeacher.Name = "buttonSearchTeacher";
            this.buttonSearchTeacher.Size = new System.Drawing.Size(138, 35);
            this.buttonSearchTeacher.TabIndex = 14;
            this.buttonSearchTeacher.Text = "Öğretmen Ara";
            this.buttonSearchTeacher.UseVisualStyleBackColor = false;
            this.buttonSearchTeacher.Click += new System.EventHandler(this.buttonSearchTeacher_Click);
            // 
            // buttonDeleteTeacher
            // 
            this.buttonDeleteTeacher.BackColor = System.Drawing.Color.Crimson;
            this.buttonDeleteTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteTeacher.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteTeacher.Location = new System.Drawing.Point(181, 441);
            this.buttonDeleteTeacher.Name = "buttonDeleteTeacher";
            this.buttonDeleteTeacher.Size = new System.Drawing.Size(100, 40);
            this.buttonDeleteTeacher.TabIndex = 11;
            this.buttonDeleteTeacher.Text = "Sil";
            this.buttonDeleteTeacher.UseVisualStyleBackColor = false;
            this.buttonDeleteTeacher.Click += new System.EventHandler(this.buttonDeleteTeacher_Click);
            // 
            // buttonAddTeacher
            // 
            this.buttonAddTeacher.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonAddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTeacher.ForeColor = System.Drawing.Color.White;
            this.buttonAddTeacher.Location = new System.Drawing.Point(58, 441);
            this.buttonAddTeacher.Name = "buttonAddTeacher";
            this.buttonAddTeacher.Size = new System.Drawing.Size(100, 40);
            this.buttonAddTeacher.TabIndex = 10;
            this.buttonAddTeacher.Text = "Ekle";
            this.buttonAddTeacher.UseVisualStyleBackColor = false;
            this.buttonAddTeacher.Click += new System.EventHandler(this.buttonAddTeacher_Click);
            // 
            // textBoxSearchTeacher
            // 
            this.textBoxSearchTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchTeacher.Location = new System.Drawing.Point(484, 30);
            this.textBoxSearchTeacher.Name = "textBoxSearchTeacher";
            this.textBoxSearchTeacher.Size = new System.Drawing.Size(432, 26);
            this.textBoxSearchTeacher.TabIndex = 13;
            // 
            // textBoxTeacherName
            // 
            this.textBoxTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherName.Location = new System.Drawing.Point(98, 219);
            this.textBoxTeacherName.Name = "textBoxTeacherName";
            this.textBoxTeacherName.Size = new System.Drawing.Size(128, 26);
            this.textBoxTeacherName.TabIndex = 1;
            // 
            // labelCourseClasses
            // 
            this.labelCourseClasses.AutoSize = true;
            this.labelCourseClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseClasses.Location = new System.Drawing.Point(20, 389);
            this.labelCourseClasses.Name = "labelCourseClasses";
            this.labelCourseClasses.Size = new System.Drawing.Size(127, 20);
            this.labelCourseClasses.TabIndex = 25;
            this.labelCourseClasses.Text = "Verdiği Dersler:";
            this.labelCourseClasses.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTeacherName
            // 
            this.labelTeacherName.AutoSize = true;
            this.labelTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeacherName.Location = new System.Drawing.Point(11, 222);
            this.labelTeacherName.Name = "labelTeacherName";
            this.labelTeacherName.Size = new System.Drawing.Size(56, 20);
            this.labelTeacherName.TabIndex = 24;
            this.labelTeacherName.Text = "İsim: *";
            this.labelTeacherName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Soyisim: *";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxTeacherSurname
            // 
            this.textBoxTeacherSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherSurname.Location = new System.Drawing.Point(337, 219);
            this.textBoxTeacherSurname.Name = "textBoxTeacherSurname";
            this.textBoxTeacherSurname.Size = new System.Drawing.Size(128, 26);
            this.textBoxTeacherSurname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cep Tel.:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ev Tel.:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxTeacherMobile
            // 
            this.textBoxTeacherMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherMobile.Location = new System.Drawing.Point(98, 259);
            this.textBoxTeacherMobile.Name = "textBoxTeacherMobile";
            this.textBoxTeacherMobile.Size = new System.Drawing.Size(128, 26);
            this.textBoxTeacherMobile.TabIndex = 3;
            // 
            // textBoxTeacherHome
            // 
            this.textBoxTeacherHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherHome.Location = new System.Drawing.Point(337, 259);
            this.textBoxTeacherHome.Name = "textBoxTeacherHome";
            this.textBoxTeacherHome.Size = new System.Drawing.Size(128, 26);
            this.textBoxTeacherHome.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "E-Mail:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Adres:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxTeacherEmail
            // 
            this.textBoxTeacherEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherEmail.Location = new System.Drawing.Point(98, 299);
            this.textBoxTeacherEmail.Name = "textBoxTeacherEmail";
            this.textBoxTeacherEmail.Size = new System.Drawing.Size(128, 26);
            this.textBoxTeacherEmail.TabIndex = 5;
            // 
            // textBoxTeacherAddress
            // 
            this.textBoxTeacherAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherAddress.Location = new System.Drawing.Point(337, 299);
            this.textBoxTeacherAddress.Name = "textBoxTeacherAddress";
            this.textBoxTeacherAddress.Size = new System.Drawing.Size(128, 26);
            this.textBoxTeacherAddress.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Kul. Adı: *";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(248, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Şifre: *";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxTeacherNickname
            // 
            this.textBoxTeacherNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherNickname.Location = new System.Drawing.Point(98, 339);
            this.textBoxTeacherNickname.Name = "textBoxTeacherNickname";
            this.textBoxTeacherNickname.Size = new System.Drawing.Size(128, 26);
            this.textBoxTeacherNickname.TabIndex = 7;
            // 
            // textBoxTeacherPassword
            // 
            this.textBoxTeacherPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherPassword.Location = new System.Drawing.Point(337, 339);
            this.textBoxTeacherPassword.Name = "textBoxTeacherPassword";
            this.textBoxTeacherPassword.Size = new System.Drawing.Size(128, 26);
            this.textBoxTeacherPassword.TabIndex = 8;
            // 
            // UserControlTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonTeacherSelectClasses);
            this.Controls.Add(this.dgvTeachers);
            this.Controls.Add(this.labelTitleTeachers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonClearTeacher);
            this.Controls.Add(this.buttonSearchTeacher);
            this.Controls.Add(this.buttonDeleteTeacher);
            this.Controls.Add(this.buttonAddTeacher);
            this.Controls.Add(this.textBoxSearchTeacher);
            this.Controls.Add(this.textBoxTeacherPassword);
            this.Controls.Add(this.textBoxTeacherAddress);
            this.Controls.Add(this.textBoxTeacherHome);
            this.Controls.Add(this.textBoxTeacherSurname);
            this.Controls.Add(this.textBoxTeacherNickname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTeacherEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTeacherMobile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTeacherName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCourseClasses);
            this.Controls.Add(this.labelTeacherName);
            this.Name = "UserControlTeachers";
            this.Size = new System.Drawing.Size(1100, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTeacherSelectClasses;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Label labelTitleTeachers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClearTeacher;
        private System.Windows.Forms.Button buttonSearchTeacher;
        private System.Windows.Forms.Button buttonDeleteTeacher;
        private System.Windows.Forms.Button buttonAddTeacher;
        private System.Windows.Forms.TextBox textBoxSearchTeacher;
        private System.Windows.Forms.TextBox textBoxTeacherName;
        private System.Windows.Forms.Label labelCourseClasses;
        private System.Windows.Forms.Label labelTeacherName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTeacherSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTeacherMobile;
        private System.Windows.Forms.TextBox textBoxTeacherHome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTeacherEmail;
        private System.Windows.Forms.TextBox textBoxTeacherAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTeacherNickname;
        private System.Windows.Forms.TextBox textBoxTeacherPassword;
    }
}
