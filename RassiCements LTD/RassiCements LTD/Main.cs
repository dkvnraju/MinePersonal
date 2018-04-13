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
            if(txtWDJCAmt.Visible)
            { txtWDJCAmt.Visible = false; }
            txtWDTypeID.Text = "";
            txtWDWgnAmt.Text = "";
            txtWDRDAmt.Text = "";
            txtWDHLAmt.Text = "";
            COBXWDTypeNM.Text = "";
            txtWDJCAmt.Text = "";
            textBoxOWAMT.Text = "";
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
            if(btnWDUpdate.Text=="Modify")
            {
                btnWDUpdate.Text = "Update";

                if(txtWDTypeID.Enabled==true)
                { txtWDTypeID.Enabled = false; }
                if(COBXWDTypeNM.Enabled==true)
                { COBXWDTypeNM.Enabled = false; }
                if(txtWDWgnAmt.Text !="")
                { txtWDWgnAmt.Enabled = true; }
                if (txtWDRDAmt.Text != "")
                { txtWDRDAmt.Enabled = true; }
                if(txtWDHLAmt.Text !="")
                { txtWDHLAmt.Enabled = true; }
               if (textBoxOWAMT.Text !="")
                { textBoxOWAMT.Enabled = true; }
               if(txtWDJCAmt.Visible=true && txtWDJCAmt.Text !="")
                { txtWDJCAmt.Enabled = true; }
              
            }else if(btnWDUpdate.Text == "Update")
            {
                //update logic

                if (txtWDTypeID.Text=="1" || txtWDTypeID.Text=="2")
                {
                    string connstring = "UPDATE WAGEDETAILS SET WAGONAMT=" + "'" + txtWDWgnAmt.Text + "'" + " ,ROADAMT=" + "'" + txtWDRDAmt.Text + "'" + " ,HLAMT=" + "'" + txtWDHLAmt.Text + "'" + " ,OPENWAGONAMT=" + "'" + textBoxOWAMT.Text + "'" + " WHERE ID=" + txtWDTypeID.Text + " AND TYPE=" + "'" + COBXWDTypeNM.Text + "'" + ";";
                    OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
                    OleDbCommand cmd = new OleDbCommand(connstring, conn);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception occured.Data not saved Please try updating it again" + ex);
                    }
                    finally
                    {
                        conn.Close();
                    }

                } else if (txtWDTypeID.Text == "3" || txtWDTypeID.Text == "4")
                {
                    txtWDWgnAmt.Text = "";
                    txtWDRDAmt.Text = "";
                    txtWDHLAmt.Text = "";
                    textBoxOWAMT.Text = "";
                    txtWDJCAmt.Visible = true;
                    string connstring = "";
                    if (txtWDTypeID.Text == "3")
                    {
                        connstring = "UPDATE WageDetails SET JAGGERYAMT=" + "'" + txtWDJCAmt.Text + "'" + " WHERE id = " + txtWDTypeID.Text + "AND TYPE=" + "'" + COBXWDTypeNM.Text + "'" + ";";
                    }
                    else if (txtWDTypeID.Text == "4")
                    {
                        connstring = "UPDATE WageDetails SET COCONUTOILAMT=" + "'" + txtWDJCAmt.Text + "'" + " WHERE id = " + txtWDTypeID.Text + "AND TYPE=" + "'" + COBXWDTypeNM.Text + "'" + ";";
                    }

                    OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
                    OleDbCommand cmd = new OleDbCommand(connstring, conn);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteReader();
                        MessageBox.Show("Data Updated Successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception occured.Data not saved Please try updating it again" + ex);
                    }
                    finally
                    {
                        conn.Close();
                    }

                }



                //getback to previous state
                btnWDUpdate.Text = "Modify";
                if (txtWDTypeID.Enabled == false)
                { txtWDTypeID.Enabled = true; }
                if (COBXWDTypeNM.Enabled == false)
                { COBXWDTypeNM.Enabled = true; }
                if(txtWDJCAmt.Visible)
                { txtWDJCAmt.Enabled = false; }
                if(txtWDWgnAmt.Enabled==true)
                { txtWDWgnAmt.Enabled = false; }
                if(txtWDHLAmt.Enabled==true)
                { txtWDHLAmt.Enabled = false; }
                if(txtWDRDAmt.Enabled==true)
                { txtWDRDAmt.Enabled = false; }
                if(textBoxOWAMT.Enabled==true)
                { textBoxOWAMT.Enabled = false; }

            }
            
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

            if (txtWDTypeID.Text=="")
            {
              //donothing
            }
            else if(txtWDTypeID.Text == "1" || txtWDTypeID.Text == "2")
            {
               
             
            string connstring = "SELECT id,type,wagonamt,roadamt,hlamt,openwagonamt FROM  WageDetails WHERE id = " + txtWDTypeID.Text;
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
            OleDbCommand cmd = new OleDbCommand(connstring, conn);

            try
            {                
                conn.Open();
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    txtWDTypeID.Text = Convert.ToString(dr.GetValue(0));
                    COBXWDTypeNM.Text = Convert.ToString(dr.GetValue(1));
                    txtWDWgnAmt.Text = Convert.ToString(dr.GetValue(2));
                    txtWDRDAmt.Text = Convert.ToString(dr.GetValue(3));
                    txtWDHLAmt.Text = Convert.ToString(dr.GetValue(4));
                    textBoxOWAMT.Text = Convert.ToString(dr.GetValue(5));
                }
                else
                {
                    MessageBox.Show("Invalid TypeID. TypeID you have entered doesn't exist. Please enter a valid TypeID ");
                }

                }
            catch(Exception ex)
            {
                MessageBox.Show("Exception occured"+ ex);
            }
            finally
            {
                conn.Close();
            }

            }//Ends else if for id 1 or 2
          else if(txtWDTypeID.Text == "3" || txtWDTypeID.Text == "4")
            {

                txtWDWgnAmt.Text = "";
                txtWDRDAmt.Text = "";
                txtWDHLAmt.Text = "";
                textBoxOWAMT.Text = "";
                txtWDJCAmt.Visible = true;
                string connstring = "SELECT id,type,JaggeryAmt,CoconutOilAmt FROM  WageDetails WHERE id = " + txtWDTypeID.Text;
                OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
                OleDbCommand cmd = new OleDbCommand(connstring, conn);

                try
                {
                    conn.Open();
                    OleDbDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        dr.Read();
                        txtWDTypeID.Text = Convert.ToString(dr.GetValue(0));
                        COBXWDTypeNM.Text = Convert.ToString(dr.GetValue(1));
                        if (txtWDTypeID.Text == "3")
                        { 
                        txtWDJCAmt.Text = Convert.ToString(dr.GetValue(2));
                        }
                        if (txtWDTypeID.Text == "4")
                        {
                            txtWDJCAmt.Text = Convert.ToString(dr.GetValue(3));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid TypeID. TypeID you have entered doesn't exist. Please enter a valid TypeID ");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception occured" + ex);
                }
                finally
                {
                    conn.Close();
                }

            }
            else
            {
                MessageBox.Show("Please check the TypeID you have entered");
            }



        }

        private void COBXWDTypeNM_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(COBXWDTypeNM.SelectedIndex == 1 || COBXWDTypeNM.SelectedIndex==2)
            {
                string connstring = "SELECT id,type,wagonamt,roadamt,hlamt,openwagonamt FROM  WageDetails WHERE type = " +"'"+ COBXWDTypeNM.Text+"';";
                OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
                OleDbCommand cmd = new OleDbCommand(connstring, conn);

                try
                {
                    conn.Open();
                    OleDbDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        dr.Read();
                        txtWDTypeID.Text = Convert.ToString(dr.GetValue(0));
                        COBXWDTypeNM.Text = Convert.ToString(dr.GetValue(1));
                        txtWDWgnAmt.Text = Convert.ToString(dr.GetValue(2));
                        txtWDRDAmt.Text = Convert.ToString(dr.GetValue(3));
                        txtWDHLAmt.Text = Convert.ToString(dr.GetValue(4));
                        textBoxOWAMT.Text = Convert.ToString(dr.GetValue(5));
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception occured" + ex);
                }
                finally
                {
                    conn.Close();
                }

            }
            else if(COBXWDTypeNM.SelectedIndex == 3 || COBXWDTypeNM.SelectedIndex == 4)
            {
                txtWDWgnAmt.Text = "";
                txtWDRDAmt.Text = "";
                txtWDHLAmt.Text = "";
                textBoxOWAMT.Text = "";
                txtWDJCAmt.Visible = true;
                string connstring = "SELECT id,type,JaggeryAmt,CoconutOilAmt FROM  WageDetails WHERE type = " + "'"+ COBXWDTypeNM.Text+"';";
                OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
                OleDbCommand cmd = new OleDbCommand(connstring, conn);

                try
                {
                    conn.Open();
                    OleDbDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        dr.Read();
                        txtWDTypeID.Text = Convert.ToString(dr.GetValue(0));
                        COBXWDTypeNM.Text = Convert.ToString(dr.GetValue(1));
                        if (txtWDTypeID.Text == "3")
                        {
                            txtWDJCAmt.Text = Convert.ToString(dr.GetValue(2));
                        }
                        if (txtWDTypeID.Text == "4")
                        {
                            txtWDJCAmt.Text = Convert.ToString(dr.GetValue(3));
                        }
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception occured" + ex);
                }
                finally
                {
                    conn.Close();
                }
            }
            else { }
        }

        private void btnWDDel_Click(object sender, EventArgs e)
        {
            
            if (txtWDTypeID.Text!="" && COBXWDTypeNM.Text!="")
            {
                MessageBox.Show("Type ID or TypeName cannot be empty. Please chack and try deleting again");
            }
            else
            { 
            // WD delete Button.
            string connstring = "DELETE FROM WAGEDETAILS  WHERE ID=" + txtWDTypeID.Text + " AND TYPE=" + "'" + COBXWDTypeNM.Text + "'" + ";";
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
            OleDbCommand cmd = new OleDbCommand(connstring, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception occured.Data not Deleted Please try Deleting it again" + ex);
            }
            finally
            {
                conn.Close();
            }
            }
        }

        private void btnBDDel_Click(object sender, EventArgs e)
            {
            if(COBXBDBNO.Text!="" && txtBDBNM.Text!="")
            {
                MessageBox.Show("Batch Name or batch Number cannot be empty. Please chack and try deleting again");
            }
            else
            { 
            string connstring = "DELETE FROM BATCHDETAILS  WHERE BatchNum=" + COBXBDBNO.Text + " AND Name=" + "'" + txtBDBNM.Text + "'" + ";";
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
            OleDbCommand cmd = new OleDbCommand(connstring, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception occured.Data not Deleted Please try Deleting it again" + ex);
            }
            finally
            {
                conn.Close();
            }
            }
        }

        private void btnBDSave_Click(object sender, EventArgs e)
        {
            if (COBXBDBNO.Text != "" && txtBDBNM.Text != "")
            {
                MessageBox.Show("Batch Name or batch Number cannot be empty. Please chack and try deleting again");
            }
            else
            {
                string connstring = "INSERT INTO BATCHDETAILS (BATCHNUM,NAME) VALUES (" + COBXBDBNO.Text + "," + "'" + txtBDBNM.Text + "'" + ");";
                OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
                OleDbCommand cmd = new OleDbCommand(connstring, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception occured.Data not Inserted Please try Inserting it again" + ex);
                }
                finally
                {
                    conn.Close();
                }
            }

            }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("You clicked on the tab page");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if(tabControl1.SelectedTab.Text=="BatchDetails")
            { }
        }

        private void btnWDSave_Click(object sender, EventArgs e)
        {

        }
    }
}
