namespace YM
{
    partial class FormTeacherClasses
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTeacherClasses = new System.Windows.Forms.DataGridView();
            this.buttonCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(141, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğretmenin Verdiği Dersler";
            // 
            // dgvTeacherClasses
            // 
            this.dgvTeacherClasses.AllowUserToAddRows = false;
            this.dgvTeacherClasses.AllowUserToDeleteRows = false;
            this.dgvTeacherClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeacherClasses.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTeacherClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherClasses.Location = new System.Drawing.Point(24, 84);
            this.dgvTeacherClasses.Name = "dgvTeacherClasses";
            this.dgvTeacherClasses.RowTemplate.Height = 24;
            this.dgvTeacherClasses.Size = new System.Drawing.Size(483, 269);
            this.dgvTeacherClasses.TabIndex = 1;
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.Turquoise;
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.ForeColor = System.Drawing.Color.White;
            this.buttonCheck.Location = new System.Drawing.Point(191, 381);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(138, 36);
            this.buttonCheck.TabIndex = 2;
            this.buttonCheck.Text = "GÜNCELLE";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // FormTeacherClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(532, 453);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.dgvTeacherClasses);
            this.Controls.Add(this.label1);
            this.Name = "FormTeacherClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurs Sistemi - Öğretmenin Verdiği Dersler";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTeacherClasses;
        private System.Windows.Forms.Button buttonCheck;
    }
}