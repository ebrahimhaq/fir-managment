using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIR_System
{
    public partial class ApplicantInfo : MetroFramework.Forms.MetroForm
    {
        public ApplicantInfo()
        {
            InitializeComponent();
        }

        private void ApplicantInfo_Load(object sender, EventArgs e)
        {
           
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            FIR_Type obj = new FIR_Type();
            obj.Show();
            this.Hide();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About obj = new About();
            obj.Show();
        }
    }
}
