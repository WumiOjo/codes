namespace fingerprintStaffAttendance
{
    partial class frmUniversityEvent
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
            this.btnCloseC = new System.Windows.Forms.Button();
            this.btnDeleteCalenda = new System.Windows.Forms.Button();
            this.btnInsertCalenda = new System.Windows.Forms.Button();
            this.btnViewAllCalenda = new System.Windows.Forms.Button();
            this.btnMonthCalenda = new System.Windows.Forms.Button();
            this.dgvPublicHoliday = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicHoliday)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseC
            // 
            this.btnCloseC.Location = new System.Drawing.Point(854, 416);
            this.btnCloseC.Name = "btnCloseC";
            this.btnCloseC.Size = new System.Drawing.Size(127, 45);
            this.btnCloseC.TabIndex = 13;
            this.btnCloseC.Text = "Close";
            this.btnCloseC.UseVisualStyleBackColor = true;
            this.btnCloseC.Click += new System.EventHandler(this.btnCloseC_Click);
            // 
            // btnDeleteCalenda
            // 
            this.btnDeleteCalenda.Location = new System.Drawing.Point(854, 349);
            this.btnDeleteCalenda.Name = "btnDeleteCalenda";
            this.btnDeleteCalenda.Size = new System.Drawing.Size(127, 45);
            this.btnDeleteCalenda.TabIndex = 12;
            this.btnDeleteCalenda.Text = "Delete";
            this.btnDeleteCalenda.UseVisualStyleBackColor = true;
            // 
            // btnInsertCalenda
            // 
            this.btnInsertCalenda.Location = new System.Drawing.Point(854, 282);
            this.btnInsertCalenda.Name = "btnInsertCalenda";
            this.btnInsertCalenda.Size = new System.Drawing.Size(127, 45);
            this.btnInsertCalenda.TabIndex = 11;
            this.btnInsertCalenda.Text = "Insert";
            this.btnInsertCalenda.UseVisualStyleBackColor = true;
            // 
            // btnViewAllCalenda
            // 
            this.btnViewAllCalenda.Location = new System.Drawing.Point(854, 215);
            this.btnViewAllCalenda.Name = "btnViewAllCalenda";
            this.btnViewAllCalenda.Size = new System.Drawing.Size(127, 45);
            this.btnViewAllCalenda.TabIndex = 10;
            this.btnViewAllCalenda.Text = "View All";
            this.btnViewAllCalenda.UseVisualStyleBackColor = true;
            // 
            // btnMonthCalenda
            // 
            this.btnMonthCalenda.Location = new System.Drawing.Point(854, 148);
            this.btnMonthCalenda.Name = "btnMonthCalenda";
            this.btnMonthCalenda.Size = new System.Drawing.Size(127, 45);
            this.btnMonthCalenda.TabIndex = 9;
            this.btnMonthCalenda.Text = "Current Month";
            this.btnMonthCalenda.UseVisualStyleBackColor = true;
            this.btnMonthCalenda.Click += new System.EventHandler(this.btnMonthCalenda_Click);
            // 
            // dgvPublicHoliday
            // 
            this.dgvPublicHoliday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublicHoliday.Location = new System.Drawing.Point(-32, 148);
            this.dgvPublicHoliday.Name = "dgvPublicHoliday";
            this.dgvPublicHoliday.Size = new System.Drawing.Size(871, 321);
            this.dgvPublicHoliday.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Mistral", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(-40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(931, 84);
            this.label1.TabIndex = 7;
            this.label1.Text = "Caleb University Annual Event / Academic Calendar";
            // 
            // frmUniversityEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 488);
            this.Controls.Add(this.btnCloseC);
            this.Controls.Add(this.btnDeleteCalenda);
            this.Controls.Add(this.btnInsertCalenda);
            this.Controls.Add(this.btnViewAllCalenda);
            this.Controls.Add(this.btnMonthCalenda);
            this.Controls.Add(this.dgvPublicHoliday);
            this.Controls.Add(this.label1);
            this.Name = "frmUniversityEvent";
            this.Text = "frmUniversityEvent";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicHoliday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCloseC;
        private System.Windows.Forms.Button btnDeleteCalenda;
        private System.Windows.Forms.Button btnInsertCalenda;
        private System.Windows.Forms.Button btnViewAllCalenda;
        private System.Windows.Forms.Button btnMonthCalenda;
        private System.Windows.Forms.DataGridView dgvPublicHoliday;
        private System.Windows.Forms.Label label1;
    }
}