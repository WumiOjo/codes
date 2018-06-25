namespace fingerprintStaffAttendance
{
    partial class frmPublicHolidayReport
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
            this.dgvPublicHoliday = new System.Windows.Forms.DataGridView();
            this.btnCurrentMonth = new System.Windows.Forms.Button();
            this.btnViewAllHoliday = new System.Windows.Forms.Button();
            this.btnInsertHoliday = new System.Windows.Forms.Button();
            this.btnDeleteHoliday = new System.Windows.Forms.Button();
            this.btnCloseH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicHoliday)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Mistral", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(284, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Public Holiday";
            // 
            // dgvPublicHoliday
            // 
            this.dgvPublicHoliday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublicHoliday.Location = new System.Drawing.Point(12, 154);
            this.dgvPublicHoliday.Name = "dgvPublicHoliday";
            this.dgvPublicHoliday.Size = new System.Drawing.Size(871, 321);
            this.dgvPublicHoliday.TabIndex = 1;
            // 
            // btnCurrentMonth
            // 
            this.btnCurrentMonth.Location = new System.Drawing.Point(898, 154);
            this.btnCurrentMonth.Name = "btnCurrentMonth";
            this.btnCurrentMonth.Size = new System.Drawing.Size(127, 45);
            this.btnCurrentMonth.TabIndex = 2;
            this.btnCurrentMonth.Text = "Current Month";
            this.btnCurrentMonth.UseVisualStyleBackColor = true;
            // 
            // btnViewAllHoliday
            // 
            this.btnViewAllHoliday.Location = new System.Drawing.Point(898, 221);
            this.btnViewAllHoliday.Name = "btnViewAllHoliday";
            this.btnViewAllHoliday.Size = new System.Drawing.Size(127, 45);
            this.btnViewAllHoliday.TabIndex = 3;
            this.btnViewAllHoliday.Text = "View All";
            this.btnViewAllHoliday.UseVisualStyleBackColor = true;
            // 
            // btnInsertHoliday
            // 
            this.btnInsertHoliday.Location = new System.Drawing.Point(898, 288);
            this.btnInsertHoliday.Name = "btnInsertHoliday";
            this.btnInsertHoliday.Size = new System.Drawing.Size(127, 45);
            this.btnInsertHoliday.TabIndex = 4;
            this.btnInsertHoliday.Text = "Insert";
            this.btnInsertHoliday.UseVisualStyleBackColor = true;
            // 
            // btnDeleteHoliday
            // 
            this.btnDeleteHoliday.Location = new System.Drawing.Point(898, 355);
            this.btnDeleteHoliday.Name = "btnDeleteHoliday";
            this.btnDeleteHoliday.Size = new System.Drawing.Size(127, 45);
            this.btnDeleteHoliday.TabIndex = 5;
            this.btnDeleteHoliday.Text = "Delete";
            this.btnDeleteHoliday.UseVisualStyleBackColor = true;
            // 
            // btnCloseH
            // 
            this.btnCloseH.Location = new System.Drawing.Point(898, 422);
            this.btnCloseH.Name = "btnCloseH";
            this.btnCloseH.Size = new System.Drawing.Size(127, 45);
            this.btnCloseH.TabIndex = 6;
            this.btnCloseH.Text = "Close";
            this.btnCloseH.UseVisualStyleBackColor = true;
            this.btnCloseH.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmPublicHolidayReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 487);
            this.Controls.Add(this.btnCloseH);
            this.Controls.Add(this.btnDeleteHoliday);
            this.Controls.Add(this.btnInsertHoliday);
            this.Controls.Add(this.btnViewAllHoliday);
            this.Controls.Add(this.btnCurrentMonth);
            this.Controls.Add(this.dgvPublicHoliday);
            this.Controls.Add(this.label1);
            this.Name = "frmPublicHolidayReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Public Holiday";
            this.Load += new System.EventHandler(this.frmPublicHolidayReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicHoliday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPublicHoliday;
        private System.Windows.Forms.Button btnCurrentMonth;
        private System.Windows.Forms.Button btnViewAllHoliday;
        private System.Windows.Forms.Button btnInsertHoliday;
        private System.Windows.Forms.Button btnDeleteHoliday;
        private System.Windows.Forms.Button btnCloseH;
    }
}