using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;






namespace fingerprintStaffAttendance
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblDateDisplay.Text = DateTime.Now.ToString("D");
            lblWelcome.Text = "Welcome to Caleb University Fingerprint Attendance System";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnStaffReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNewStaff myNewForm = new frmNewStaff();
            myNewForm.Show();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public Color white { get; set; }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void lblTimeDisplay_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeDisplay.Text = DateTime.Now.ToString("T");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCalebCalendar_Click(object sender, EventArgs e)
        {
           this.Close();
           frmUniversityEvent myNewForm = new frmUniversityEvent();
           myNewForm.Show();

        }

        private void btnPublicHoliday_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPublicHolidayReport myNewForm = new frmPublicHolidayReport();
            myNewForm.Show();
        }

        private void btnDailyAttendance_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDailyAttendance myNewForm = new frmDailyAttendance();
            myNewForm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      
    }

}
