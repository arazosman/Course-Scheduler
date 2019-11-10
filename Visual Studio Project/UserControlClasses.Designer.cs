namespace YM
{
    partial class UserControlClasses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlClasses));
            this.labelClassName = new System.Windows.Forms.Label();
            this.textBoxClassName = new System.Windows.Forms.TextBox();
            this.labelClassHours = new System.Windows.Forms.Label();
            this.textBoxClassHours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddClass = new System.Windows.Forms.Button();
            this.buttonSearchClass = new System.Windows.Forms.Button();
            this.buttonClearClass = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitleClasses = new System.Windows.Forms.Label();
            this.textBoxSearchClass = new System.Windows.Forms.TextBox();
            this.buttonDeleteClass = new System.Windows.Forms.Button();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClassName
            // 
            this.labelClassName.AutoSize = true;
            this.labelClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassName.Location = new System.Drawing.Point(35, 271);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(98, 20);
            this.labelClassName.TabIndex = 0;
            this.labelClassName.Text = "Ders İsmi: *";
            this.labelClassName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxClassName
            // 
            this.textBoxClassName.AccessibleDescription = "";
            this.textBoxClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClassName.Location = new System.Drawing.Point(155, 265);
            this.textBoxClassName.Name = "textBoxClassName";
            this.textBoxClassName.Size = new System.Drawing.Size(227, 26);
            this.textBoxClassName.TabIndex = 1;
            this.textBoxClassName.Tag = "";
            // 
            // labelClassHours
            // 
            this.labelClassHours.AutoSize = true;
            this.labelClassHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassHours.Location = new System.Drawing.Point(28, 322);
            this.labelClassHours.Name = "labelClassHours";
            this.labelClassHours.Size = new System.Drawing.Size(115, 20);
            this.labelClassHours.TabIndex = 0;
            this.labelClassHours.Text = "Ders Süresi: *";
            // 
            // textBoxClassHours
            // 
            this.textBoxClassHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClassHours.Location = new System.Drawing.Point(154, 319);
            this.textBoxClassHours.Name = "textBoxClassHours";
            this.textBoxClassHours.Size = new System.Drawing.Size(227, 26);
            this.textBoxClassHours.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "(saat)";
            // 
            // buttonAddClass
            // 
            this.buttonAddClass.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddClass.ForeColor = System.Drawing.Color.White;
            this.buttonAddClass.Location = new System.Drawing.Point(32, 423);
            this.buttonAddClass.Name = "buttonAddClass";
            this.buttonAddClass.Size = new System.Drawing.Size(100, 40);
            this.buttonAddClass.TabIndex = 3;
            this.buttonAddClass.Text = "Ekle";
            this.buttonAddClass.UseVisualStyleBackColor = false;
            this.buttonAddClass.Click += new System.EventHandler(this.buttonAddClass_Click);
            // 
            // buttonSearchClass
            // 
            this.buttonSearchClass.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonSearchClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchClass.ForeColor = System.Drawing.Color.White;
            this.buttonSearchClass.Location = new System.Drawing.Point(929, 15);
            this.buttonSearchClass.Name = "buttonSearchClass";
            this.buttonSearchClass.Size = new System.Drawing.Size(138, 35);
            this.buttonSearchClass.TabIndex = 3;
            this.buttonSearchClass.Text = "Ders Ara";
            this.buttonSearchClass.UseVisualStyleBackColor = false;
            this.buttonSearchClass.Click += new System.EventHandler(this.buttonSearchClass_Click);
            // 
            // buttonClearClass
            // 
            this.buttonClearClass.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonClearClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearClass.ForeColor = System.Drawing.Color.White;
            this.buttonClearClass.Location = new System.Drawing.Point(281, 423);
            this.buttonClearClass.Name = "buttonClearClass";
            this.buttonClearClass.Size = new System.Drawing.Size(100, 40);
            this.buttonClearClass.TabIndex = 6;
            this.buttonClearClass.Text = "Temizle";
            this.buttonClearClass.UseVisualStyleBackColor = false;
            this.buttonClearClass.Click += new System.EventHandler(this.buttonCleanClass_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitleClasses
            // 
            this.labelTitleClasses.AutoSize = true;
            this.labelTitleClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleClasses.ForeColor = System.Drawing.Color.Indigo;
            this.labelTitleClasses.Location = new System.Drawing.Point(153, 189);
            this.labelTitleClasses.Name = "labelTitleClasses";
            this.labelTitleClasses.Size = new System.Drawing.Size(132, 29);
            this.labelTitleClasses.TabIndex = 5;
            this.labelTitleClasses.Text = "DERSLER";
            // 
            // textBoxSearchClass
            // 
            this.textBoxSearchClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchClass.Location = new System.Drawing.Point(426, 19);
            this.textBoxSearchClass.Name = "textBoxSearchClass";
            this.textBoxSearchClass.Size = new System.Drawing.Size(479, 26);
            this.textBoxSearchClass.TabIndex = 7;
            // 
            // buttonDeleteClass
            // 
            this.buttonDeleteClass.BackColor = System.Drawing.Color.Crimson;
            this.buttonDeleteClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteClass.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteClass.Location = new System.Drawing.Point(155, 423);
            this.buttonDeleteClass.Name = "buttonDeleteClass";
            this.buttonDeleteClass.Size = new System.Drawing.Size(100, 40);
            this.buttonDeleteClass.TabIndex = 4;
            this.buttonDeleteClass.Text = "Sil";
            this.buttonDeleteClass.UseVisualStyleBackColor = false;
            this.buttonDeleteClass.Click += new System.EventHandler(this.buttonDeleteClass_Click);
            // 
            // dgvClasses
            // 
            this.dgvClasses.AllowUserToAddRows = false;
            this.dgvClasses.AllowUserToDeleteRows = false;
            this.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasses.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvClasses.ColumnHeadersHeight = 25;
            this.dgvClasses.Location = new System.Drawing.Point(426, 83);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowTemplate.Height = 24;
            this.dgvClasses.Size = new System.Drawing.Size(641, 380);
            this.dgvClasses.TabIndex = 6;
            this.dgvClasses.DoubleClick += new System.EventHandler(this.dgvClasses_DoubleClick);
            // 
            // UserControlClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dgvClasses);
            this.Controls.Add(this.labelTitleClasses);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonClearClass);
            this.Controls.Add(this.buttonSearchClass);
            this.Controls.Add(this.buttonDeleteClass);
            this.Controls.Add(this.buttonAddClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxClassHours);
            this.Controls.Add(this.labelClassHours);
            this.Controls.Add(this.textBoxSearchClass);
            this.Controls.Add(this.textBoxClassName);
            this.Controls.Add(this.labelClassName);
            this.Name = "UserControlClasses";
            this.Size = new System.Drawing.Size(1100, 500);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClassName;
        private System.Windows.Forms.TextBox textBoxClassName;
        private System.Windows.Forms.Label labelClassHours;
        private System.Windows.Forms.TextBox textBoxClassHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddClass;
        private System.Windows.Forms.Button buttonSearchClass;
        private System.Windows.Forms.Button buttonClearClass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitleClasses;
        private System.Windows.Forms.TextBox textBoxSearchClass;
        private System.Windows.Forms.Button buttonDeleteClass;
        private System.Windows.Forms.DataGridView dgvClasses;
    }
}
