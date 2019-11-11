using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_CSap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.MdiParent = this;
            this.panel_Login.Controls.Add(Login);
            Login.Show();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.panel_Login.Location = new Point((this.Width - this.panel_Login.Width) / 2 - 5, this.panel_Login.Top);
        }
    }
}
