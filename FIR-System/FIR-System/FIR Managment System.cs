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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            Menu obj = new Menu();
            obj.Show();
            this.Hide();
            
        }

        private void linkAbout_Click(object sender, EventArgs e)
        {
            About obj = new About();
            obj.Show();
        }
    }
}
