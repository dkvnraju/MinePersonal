using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RassiCements_LTD
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clciking on the details menu set the pages names
            tabControl1.Visible = true;
            tabPage1.Text = "Type Details";
            tabPage2.Text = "Batch Details";
            tabPage3.Text = "Packing Loading Details";
            tabPage4.Text = "Loading Details";
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Would you like to exit?", "Exit Window", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { Application.Exit(); }

        }

        private void allowancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tabControl1.Visible = true;
            //tabControl1.TabPages.Remove(tabPage4);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
