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
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About obj = new About();
            obj.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            FIR_Type obj = new FIR_Type();
            obj.Show();
            this.Hide();
        }
    }
}
