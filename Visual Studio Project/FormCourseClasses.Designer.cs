namespace YM
{
    partial class FormCourseClasses
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
            this.buttonCheck = new System.Windows.Forms.Button();
            this.dgvCourseClasses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.Turquoise;
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.ForeColor = System.Drawing.Color.White;
            this.buttonCheck.Location = new System.Drawing.Point(192, 385);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(138, 36);
            this.buttonCheck.TabIndex = 5;
            this.buttonCheck.Text = "GÜNCELLE";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // dgvCourseClasses
            // 
            this.dgvCourseClasses.AllowUserToAddRows = false;
            this.dgvCourseClasses.AllowUserToDeleteRows = false;
            this.dgvCourseClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourseClasses.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCourseClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseClasses.Location = new System.Drawing.Point(25, 88);
            this.dgvCourseClasses.Name = "dgvCourseClasses";
            this.dgvCourseClasses.RowTemplate.Height = 24;
            this.dgvCourseClasses.Size = new System.Drawing.Size(483, 269);
            this.dgvCourseClasses.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(187, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kurstaki Dersler";
            // 
            // FormCourseClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(532, 453);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.dgvCourseClasses);
            this.Controls.Add(this.label1);
            this.Name = "FormCourseClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurs Sistemi - Kurstaki Dersler";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.DataGridView dgvCourseClasses;
        private System.Windows.Forms.Label label1;
    }
}