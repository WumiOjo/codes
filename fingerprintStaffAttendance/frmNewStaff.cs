using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Enrollment;
using System.Diagnostics;


namespace fingerprintStaffAttendance
{
    public partial class frmNewStaff : Form
    {
        public frmNewStaff()
        {
            InitializeComponent();
        }

        private void frmNewStaff_Load(object sender, EventArgs e)
        {
            //picFingerprint.Image = Enrollment.CaptureForm;
        }

        private void lsbTittle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void picFingerprint_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDashboard myNewForm = new frmDashboard();
            myNewForm.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveStaffDetails_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Enrollment.MainForm myNewForm = new Enrollment.MainForm();
            myNewForm.Show();
        }

        private void picStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
