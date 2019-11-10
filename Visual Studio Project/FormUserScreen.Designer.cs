namespace YM
{
    partial class FormUserScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonTeachers = new System.Windows.Forms.Button();
            this.buttonClasses = new System.Windows.Forms.Button();
            this.buttonCourses = new System.Windows.Forms.Button();
            this.labelNickname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControlTeachers1 = new YM.UserControlTeachers();
            this.userControlStudents1 = new YM.UserControlStudents();
            this.userControlCourses1 = new YM.UserControlCourses();
            this.userControlClasses1 = new YM.UserControlClasses();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.buttonProfile);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonStudents);
            this.panel1.Controls.Add(this.buttonTeachers);
            this.panel1.Controls.Add(this.buttonClasses);
            this.panel1.Controls.Add(this.buttonCourses);
            this.panel1.Controls.Add(this.labelNickname);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 511);
            this.panel1.TabIndex = 0;
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.Turquoise;
            this.buttonProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfile.ForeColor = System.Drawing.Color.White;
            this.buttonProfile.Location = new System.Drawing.Point(15, 204);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(180, 40);
            this.buttonProfile.TabIndex = 6;
            this.buttonProfile.Text = "PROFİL";
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Crimson;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(15, 454);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(180, 40);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "ÇIKIŞ";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonStudents
            // 
            this.buttonStudents.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudents.ForeColor = System.Drawing.Color.White;
            this.buttonStudents.Location = new System.Drawing.Point(15, 404);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(180, 40);
            this.buttonStudents.TabIndex = 3;
            this.buttonStudents.Text = "ÖĞRENCİLER";
            this.buttonStudents.UseVisualStyleBackColor = false;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonTeachers
            // 
            this.buttonTeachers.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTeachers.ForeColor = System.Drawing.Color.White;
            this.buttonTeachers.Location = new System.Drawing.Point(15, 354);
            this.buttonTeachers.Name = "buttonTeachers";
            this.buttonTeachers.Size = new System.Drawing.Size(180, 40);
            this.buttonTeachers.TabIndex = 2;
            this.buttonTeachers.Text = "ÖĞRETMENLER";
            this.buttonTeachers.UseVisualStyleBackColor = false;
            this.buttonTeachers.Click += new System.EventHandler(this.buttonTeachers_Click);
            // 
            // buttonClasses
            // 
            this.buttonClasses.BackColor = System.Drawing.Color.Gold;
            this.buttonClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClasses.ForeColor = System.Drawing.Color.White;
            this.buttonClasses.Location = new System.Drawing.Point(15, 254);
            this.buttonClasses.Name = "buttonClasses";
            this.buttonClasses.Size = new System.Drawing.Size(180, 40);
            this.buttonClasses.TabIndex = 0;
            this.buttonClasses.Text = "DERSLER";
            this.buttonClasses.UseVisualStyleBackColor = false;
            this.buttonClasses.Click += new System.EventHandler(this.buttonClasses_Click);
            // 
            // buttonCourses
            // 
            this.buttonCourses.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCourses.ForeColor = System.Drawing.Color.White;
            this.buttonCourses.Location = new System.Drawing.Point(15, 304);
            this.buttonCourses.Name = "buttonCourses";
            this.buttonCourses.Size = new System.Drawing.Size(180, 40);
            this.buttonCourses.TabIndex = 1;
            this.buttonCourses.Text = "KURSLAR";
            this.buttonCourses.UseVisualStyleBackColor = false;
            this.buttonCourses.Click += new System.EventHandler(this.buttonCourses_Click);
            // 
            // labelNickname
            // 
            this.labelNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNickname.Location = new System.Drawing.Point(32, 159);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(150, 20);
            this.labelNickname.TabIndex = 1;
            this.labelNickname.Text = "nickname";
            this.labelNickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userControlTeachers1
            // 
            this.userControlTeachers1.BackColor = System.Drawing.Color.LemonChiffon;
            this.userControlTeachers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlTeachers1.Location = new System.Drawing.Point(213, 0);
            this.userControlTeachers1.Name = "userControlTeachers1";
            this.userControlTeachers1.Size = new System.Drawing.Size(1096, 511);
            this.userControlTeachers1.TabIndex = 4;
            // 
            // userControlStudents1
            // 
            this.userControlStudents1.BackColor = System.Drawing.Color.LemonChiffon;
            this.userControlStudents1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlStudents1.Location = new System.Drawing.Point(213, 0);
            this.userControlStudents1.Name = "userControlStudents1";
            this.userControlStudents1.Size = new System.Drawing.Size(1096, 511);
            this.userControlStudents1.TabIndex = 3;
            // 
            // userControlCourses1
            // 
            this.userControlCourses1.BackColor = System.Drawing.Color.LemonChiffon;
            this.userControlCourses1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlCourses1.Location = new System.Drawing.Point(213, 0);
            this.userControlCourses1.Name = "userControlCourses1";
            this.userControlCourses1.Size = new System.Drawing.Size(1096, 511);
            this.userControlCourses1.TabIndex = 2;
            // 
            // userControlClasses1
            // 
            this.userControlClasses1.BackColor = System.Drawing.Color.LemonChiffon;
            this.userControlClasses1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlClasses1.Location = new System.Drawing.Point(213, 0);
            this.userControlClasses1.Name = "userControlClasses1";
            this.userControlClasses1.Size = new System.Drawing.Size(1096, 511);
            this.userControlClasses1.TabIndex = 1;
            // 
            // FormUserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 511);
            this.Controls.Add(this.userControlTeachers1);
            this.Controls.Add(this.userControlStudents1);
            this.Controls.Add(this.userControlCourses1);
            this.Controls.Add(this.userControlClasses1);
            this.Controls.Add(this.panel1);
            this.Name = "FormUserScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurs Sistemi";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonTeachers;
        private System.Windows.Forms.Button buttonClasses;
        private System.Windows.Forms.Button buttonCourses;
        private System.Windows.Forms.Label labelNickname;
        private UserControlClasses userControlClasses1;
        private UserControlCourses userControlCourses1;
        private UserControlStudents userControlStudents1;
        private UserControlTeachers userControlTeachers1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonProfile;
    }
}