using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

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
            tabControl1.Visible = false;
            //tabControl1.TabPages.Remove(tabPage4);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void lblLDSubHead_Click(object sender, EventArgs e)
        {

        }

        private void btnWDClr_Click(object sender, EventArgs e)
        {
            txtWDTypeID.Text = "";
            txtWDWgnAmt.Text = "";
            txtWDRDAmt.Text = "";
            txtWDHLAmt.Text = "";
            COBXWDTypeNM.Text = "";
        }

        private void btnBDClr_Click(object sender, EventArgs e)
        {
            COBXBDBNO.Text = "";
            txtBDBNM.Text = "";
        }

        private void btnPLDClr_Click(object sender, EventArgs e)
        {
            txtboxPLDTknNo.Text = "";
            textBoxPLDPF.Text = "";
            txtboxPLDNM.Text = "";
            txtboxPLDFNM.Text = "";
            txtboxPLDSINo.Text = "";
            dateTimePickerPLDDOB.Text = "";
            dateTimePickerPLDJNDt.Text = "";
            lblPLDYASDtVal.Text = "";
            lblPLDDofRet.Text = "";
            if( radioButtonPFYes.Checked)
            { radioButtonPFYes.Checked = false; }
            if(radioButtonPFNo.Checked)
            { radioButtonPFNo.Checked = false; }
            comboBoxPLDTypID.Text = "";
            comboBoxPLDBtchNo.Text = "";
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            comboBoxLDBtchNo.Text = "";
            dateTimePickerLDDt.Text = "";
            comboBoxLDShft.Text = "";
            textBoxLDRdTns.Text = "";
            textBoxLDWgTns.Text = "";
            textBoxLDDWWagTns.Text = "";
            textBoxLDHLTns.Text = "";
            textBoxLDTotTns.Text = "";
            textBoxLDNoLdrs.Text = "";
            textBoxLDNoPkrs.Text = "";
            textBoxLDLDAmtRd.Text = "";
            textBoxLDPkrAmtRd.Text = "";
            textBoxLDLDAmtWg.Text = "";
            textBoxLDPkrAmtWg.Text = "";
            textBoxLDLDAmtHL.Text = "";
            textBoxLDPkrAmtHL.Text = "";
            textBoxLDLDAmtOldWgn.Text = "";
            textBoxLDPkrAmtOldWgn.Text = "";
            textBoxLDLDTotAmt.Text = "";
            textBoxLDPkrTotAmt.Text = "";
        }

        private void personalDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
        }

        private void btnLDOtrbtch_Click(object sender, EventArgs e)
        {
            if(panOtherContractor.Visible==true)
            { panOtherContractor.Visible = false; }
            panOtherBatch.Visible = true;

        }

        private void btnLDOthrCntrct_Click(object sender, EventArgs e)
        {
            if (panOtherBatch.Visible == true)
            { panOtherBatch.Visible = false; }
            panOtherContractor.Visible = true;
        }

        private void radioButtonPFNo_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonPFNo.Checked)
            { textBoxPLDPF.Visible = false; }
        }

        private void txtWDWgnAmt_MouseHover(object sender, EventArgs e)
        {
            //txtWDWgnAmt.Text = "BCN Wagon";
        }

        private void txtWDWgnAmt_MouseLeave(object sender, EventArgs e)
        {
            //txtWDWgnAmt.Text = "";
        }

        private void btnWDUpdate_Click(object sender, EventArgs e)
        {
            btnWDUpdate.Text = "Update";
        }

        private void textBoxLDRdTns_TextChanged(object sender, EventArgs e)
        {
            //textBoxLDTotTns.Text = Convert.ToString(Convert.ToInt32(textBoxLDRdTns.Text) + Convert.ToInt32(textBoxLDWgTns.Text) + Convert.ToInt32(textBoxLDDWWagTns.Text) + Convert.ToInt32(textBoxLDHLTns.Text));

        }

        private void textBoxLDRdTns_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = char.IsDigit(e.KeyChar);
            //if(!e.Handled)
            //{ MessageBox.Show("You can enter Number only"); }

        }

        private void txtWDTypeID_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
