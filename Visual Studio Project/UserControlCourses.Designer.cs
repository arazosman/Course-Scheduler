namespace YM
{
    partial class UserControlCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCourses));
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.labelTitleCourses = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClearCourse = new System.Windows.Forms.Button();
            this.buttonSearchCourse = new System.Windows.Forms.Button();
            this.buttonDeleteCourse = new System.Windows.Forms.Button();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCourseWeeks = new System.Windows.Forms.TextBox();
            this.labelCourseWeeks = new System.Windows.Forms.Label();
            this.textBoxSearchCourse = new System.Windows.Forms.TextBox();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.labelCourseName = new System.Windows.Forms.Label();
            this.labelCourseBeg = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelCourseClasses = new System.Windows.Forms.Label();
            this.buttonCourseSelectClasses = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCoursePrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCourses.ColumnHeadersHeight = 25;
            this.dgvCourses.Location = new System.Drawing.Point(430, 85);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowTemplate.Height = 24;
            this.dgvCourses.Size = new System.Drawing.Size(641, 380);
            this.dgvCourses.TabIndex = 18;
            this.dgvCourses.DoubleClick += new System.EventHandler(this.dgvCourses_DoubleClick);
            // 
            // labelTitleCourses
            // 
            this.labelTitleCourses.AutoSize = true;
            this.labelTitleCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleCourses.ForeColor = System.Drawing.Color.Indigo;
            this.labelTitleCourses.Location = new System.Drawing.Point(158, 120);
            this.labelTitleCourses.Name = "labelTitleCourses";
            this.labelTitleCourses.Size = new System.Drawing.Size(131, 29);
            this.labelTitleCourses.TabIndex = 17;
            this.labelTitleCourses.Text = "KURSLAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // buttonClearCourse
            // 
            this.buttonClearCourse.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonClearCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearCourse.ForeColor = System.Drawing.Color.White;
            this.buttonClearCourse.Location = new System.Drawing.Point(285, 425);
            this.buttonClearCourse.Name = "buttonClearCourse";
            this.buttonClearCourse.Size = new System.Drawing.Size(100, 40);
            this.buttonClearCourse.TabIndex = 8;
            this.buttonClearCourse.Text = "Temizle";
            this.buttonClearCourse.UseVisualStyleBackColor = false;
            this.buttonClearCourse.Click += new System.EventHandler(this.buttonCleanCourse_Click);
            // 
            // buttonSearchCourse
            // 
            this.buttonSearchCourse.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonSearchCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchCourse.ForeColor = System.Drawing.Color.White;
            this.buttonSearchCourse.Location = new System.Drawing.Point(933, 17);
            this.buttonSearchCourse.Name = "buttonSearchCourse";
            this.buttonSearchCourse.Size = new System.Drawing.Size(138, 35);
            this.buttonSearchCourse.TabIndex = 10;
            this.buttonSearchCourse.Text = "Kurs Ara";
            this.buttonSearchCourse.UseVisualStyleBackColor = false;
            this.buttonSearchCourse.Click += new System.EventHandler(this.buttonSearchCourse_Click);
            // 
            // buttonDeleteCourse
            // 
            this.buttonDeleteCourse.BackColor = System.Drawing.Color.Crimson;
            this.buttonDeleteCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteCourse.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteCourse.Location = new System.Drawing.Point(159, 425);
            this.buttonDeleteCourse.Name = "buttonDeleteCourse";
            this.buttonDeleteCourse.Size = new System.Drawing.Size(100, 40);
            this.buttonDeleteCourse.TabIndex = 7;
            this.buttonDeleteCourse.Text = "Sil";
            this.buttonDeleteCourse.UseVisualStyleBackColor = false;
            this.buttonDeleteCourse.Click += new System.EventHandler(this.buttonDeleteCourse_Click);
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCourse.ForeColor = System.Drawing.Color.White;
            this.buttonAddCourse.Location = new System.Drawing.Point(36, 425);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(100, 40);
            this.buttonAddCourse.TabIndex = 6;
            this.buttonAddCourse.Text = "Ekle";
            this.buttonAddCourse.UseVisualStyleBackColor = false;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "(hafta)";
            // 
            // textBoxCourseWeeks
            // 
            this.textBoxCourseWeeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseWeeks.Location = new System.Drawing.Point(151, 229);
            this.textBoxCourseWeeks.Name = "textBoxCourseWeeks";
            this.textBoxCourseWeeks.Size = new System.Drawing.Size(227, 26);
            this.textBoxCourseWeeks.TabIndex = 2;
            // 
            // labelCourseWeeks
            // 
            this.labelCourseWeeks.AutoSize = true;
            this.labelCourseWeeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseWeeks.Location = new System.Drawing.Point(25, 229);
            this.labelCourseWeeks.Name = "labelCourseWeeks";
            this.labelCourseWeeks.Size = new System.Drawing.Size(113, 20);
            this.labelCourseWeeks.TabIndex = 8;
            this.labelCourseWeeks.Text = "Kurs Süresi: *";
            // 
            // textBoxSearchCourse
            // 
            this.textBoxSearchCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchCourse.Location = new System.Drawing.Point(430, 21);
            this.textBoxSearchCourse.Name = "textBoxSearchCourse";
            this.textBoxSearchCourse.Size = new System.Drawing.Size(479, 26);
            this.textBoxSearchCourse.TabIndex = 9;
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseName.Location = new System.Drawing.Point(152, 181);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(227, 26);
            this.textBoxCourseName.TabIndex = 1;
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseName.Location = new System.Drawing.Point(32, 187);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(96, 20);
            this.labelCourseName.TabIndex = 9;
            this.labelCourseName.Text = "Kurs İsmi: *";
            this.labelCourseName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCourseBeg
            // 
            this.labelCourseBeg.AutoSize = true;
            this.labelCourseBeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseBeg.Location = new System.Drawing.Point(2, 326);
            this.labelCourseBeg.Name = "labelCourseBeg";
            this.labelCourseBeg.Size = new System.Drawing.Size(143, 20);
            this.labelCourseBeg.TabIndex = 9;
            this.labelCourseBeg.Text = "Kurs Başlangıcı: *";
            this.labelCourseBeg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(151, 324);
            this.dateTimePicker.MinDate = new System.DateTime(2019, 5, 6, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(227, 26);
            this.dateTimePicker.TabIndex = 4;
            // 
            // labelCourseClasses
            // 
            this.labelCourseClasses.AutoSize = true;
            this.labelCourseClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseClasses.Location = new System.Drawing.Point(26, 376);
            this.labelCourseClasses.Name = "labelCourseClasses";
            this.labelCourseClasses.Size = new System.Drawing.Size(70, 20);
            this.labelCourseClasses.TabIndex = 9;
            this.labelCourseClasses.Text = "Dersler:";
            this.labelCourseClasses.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonCourseSelectClasses
            // 
            this.buttonCourseSelectClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCourseSelectClasses.Location = new System.Drawing.Point(118, 373);
            this.buttonCourseSelectClasses.Name = "buttonCourseSelectClasses";
            this.buttonCourseSelectClasses.Size = new System.Drawing.Size(261, 26);
            this.buttonCourseSelectClasses.TabIndex = 5;
            this.buttonCourseSelectClasses.Text = "Dersleri Seçin";
            this.buttonCourseSelectClasses.UseVisualStyleBackColor = true;
            this.buttonCourseSelectClasses.Click += new System.EventHandler(this.buttonCourseSelectClasses_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kurs Fiyatı: *";
            // 
            // textBoxCoursePrice
            // 
            this.textBoxCoursePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCoursePrice.Location = new System.Drawing.Point(151, 277);
            this.textBoxCoursePrice.Name = "textBoxCoursePrice";
            this.textBoxCoursePrice.Size = new System.Drawing.Size(227, 26);
            this.textBoxCoursePrice.TabIndex = 3;
            // 
            // UserControlCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.buttonCourseSelectClasses);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dgvCourses);
            this.Controls.Add(this.labelTitleCourses);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonClearCourse);
            this.Controls.Add(this.buttonSearchCourse);
            this.Controls.Add(this.buttonDeleteCourse);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCoursePrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCourseWeeks);
            this.Controls.Add(this.labelCourseWeeks);
            this.Controls.Add(this.textBoxSearchCourse);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.labelCourseClasses);
            this.Controls.Add(this.labelCourseBeg);
            this.Controls.Add(this.labelCourseName);
            this.Name = "UserControlCourses";
            this.Size = new System.Drawing.Size(1100, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Label labelTitleCourses;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClearCourse;
        private System.Windows.Forms.Button buttonSearchCourse;
        private System.Windows.Forms.Button buttonDeleteCourse;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCourseWeeks;
        private System.Windows.Forms.Label labelCourseWeeks;
        private System.Windows.Forms.TextBox textBoxSearchCourse;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.Label labelCourseBeg;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelCourseClasses;
        private System.Windows.Forms.Button buttonCourseSelectClasses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCoursePrice;
    }
}
