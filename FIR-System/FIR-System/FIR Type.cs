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
    public partial class FIR_Type : MetroFramework.Forms.MetroForm
    {
        public FIR_Type()
        {
            InitializeComponent();
        }

        private void FIR_Type_Load(object sender, EventArgs e)
        {

        }

        private void tileMobile_Click(object sender, EventArgs e)
        {
            MobileTheft obj = new MobileTheft();
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
