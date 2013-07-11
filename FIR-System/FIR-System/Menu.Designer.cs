namespace FIR_System
{
    partial class Menu
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
            this.tilePolice = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.tileSearch = new MetroFramework.Controls.MetroTile();
            this.btnAbout = new MetroFramework.Controls.MetroButton();
            this.lblU = new MetroFramework.Controls.MetroLabel();
            this.lblUser = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // tilePolice
            // 
            this.tilePolice.ActiveControl = null;
            this.tilePolice.CustomBackground = false;
            this.tilePolice.CustomForeColor = false;
            this.tilePolice.Location = new System.Drawing.Point(23, 199);
            this.tilePolice.Name = "tilePolice";
            this.tilePolice.PaintTileCount = true;
            this.tilePolice.Size = new System.Drawing.Size(165, 95);
            this.tilePolice.Style = MetroFramework.MetroColorStyle.Purple;
            this.tilePolice.StyleManager = null;
            this.tilePolice.TabIndex = 2;
            this.tilePolice.Text = "Police User Registration";
            this.tilePolice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tilePolice.TileCount = 0;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.CustomBackground = false;
            this.metroTile2.CustomForeColor = false;
            this.metroTile2.Location = new System.Drawing.Point(23, 79);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.PaintTileCount = true;
            this.metroTile2.Size = new System.Drawing.Size(165, 95);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile2.StyleManager = null;
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "FIR Registration";
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile2.TileCount = 0;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // tileSearch
            // 
            this.tileSearch.ActiveControl = null;
            this.tileSearch.CustomBackground = false;
            this.tileSearch.CustomForeColor = false;
            this.tileSearch.Location = new System.Drawing.Point(209, 79);
            this.tileSearch.Name = "tileSearch";
            this.tileSearch.PaintTileCount = true;
            this.tileSearch.Size = new System.Drawing.Size(165, 95);
            this.tileSearch.Style = MetroFramework.MetroColorStyle.Lime;
            this.tileSearch.StyleManager = null;
            this.tileSearch.TabIndex = 4;
            this.tileSearch.Text = "Search FIR";
            this.tileSearch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileSearch.TileCount = 0;
            // 
            // btnAbout
            // 
            this.btnAbout.Highlight = false;
            this.btnAbout.Location = new System.Drawing.Point(23, 329);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(94, 23);
            this.btnAbout.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAbout.StyleManager = null;
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "About Project";
            this.btnAbout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblU
            // 
            this.lblU.AutoSize = true;
            this.lblU.CustomBackground = false;
            this.lblU.CustomForeColor = false;
            this.lblU.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblU.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblU.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblU.Location = new System.Drawing.Point(196, 40);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(91, 19);
            this.lblU.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblU.StyleManager = null;
            this.lblU.TabIndex = 6;
            this.lblU.Text = "Logged in as, ";
            this.lblU.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblU.UseStyleColors = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.CustomBackground = false;
            this.lblUser.CustomForeColor = false;
            this.lblUser.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.lblUser.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.lblUser.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.lblUser.Location = new System.Drawing.Point(288, 40);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(86, 19);
            this.lblUser.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblUser.StyleManager = null;
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Ebrahim Haq";
            this.lblUser.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblUser.UseStyleColors = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 361);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblU);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.tileSearch);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.tilePolice);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile tilePolice;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile tileSearch;
        private MetroFramework.Controls.MetroButton btnAbout;
        private MetroFramework.Controls.MetroLabel lblU;
        private MetroFramework.Controls.MetroLabel lblUser;
    }
}