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
        DataTable emp = new DataTable();
        DataTable Nemp = new DataTable();











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

            //if (txtboxPLDSINo.Enabled == false) { txtboxPLDSINo.Enabled = true; }
            if (txtboxPLDTknNo.Enabled == false) { txtboxPLDTknNo.Enabled = true; }
            if (comboBoxPLDTypID.Enabled == false) { comboBoxPLDTypID.Enabled = true; }
            if (comboBoxPLDBtchNo.Enabled == false) { comboBoxPLDBtchNo.Enabled = true; }
            if (dateTimePickerPLDJNDt.Enabled == false) { dateTimePickerPLDJNDt.Enabled = true; }
            if (radioButtonPFNo.Enabled == false || radioButtonPFNo.Enabled == false) { radioButtonPFNo.Enabled = true; radioButtonPFNo.Enabled = true; }
            if (textBoxPLDPF.Enabled == false) { textBoxPLDPF.Enabled = true; }
            if (txtboxPLDNM.Enabled == false) { txtboxPLDNM.Enabled = true; }
            if (txtboxPLDFNM.Enabled == false) { txtboxPLDFNM.Enabled = true; }
            if (dateTimePickerPLDDOB.Enabled == false) { dateTimePickerPLDDOB.Enabled = true; }
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
            //Do nothing
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
           if(tabControl1.SelectedTab.Text == "Packing Loading Details")
            {
                if(radioButtonPFYes.Checked==false)
                { radioButtonPFYes.Checked = true; }
                if(radioButtonPFYes.Checked==true)
                { textBoxPLDPF.Visible = true; }
            }



            if(tabControl1.SelectedTab.Text=="Batch Details")
            {
                string connstring = "SELECT BatchNum FROM  BatchDetails ;";
                OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
                OleDbCommand cmd = new OleDbCommand(connstring, conn);
                
                try
                {
                    conn.Open();
                    OleDbDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                       COBXBDBNO.Items.Add(dr.GetValue(0));
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


            if(tabControl1.SelectedTab.Text=="Loading Details")
            {
                string connstring = "SELECT BatchNum FROM  BatchDetails ;";
                OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
                OleDbCommand cmd = new OleDbCommand(connstring, conn);
                

                try
                {
                    conn.Open();
                    OleDbDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        comboBoxLDBtchNo.Items.Add(dr.GetValue(0));
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


        }

        private void btnWDSave_Click(object sender, EventArgs e)
        {

        }

        private void txtWDTypeID_TabIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("tab index chnaged");
        }

        private void txtWDTypeID_Leave(object sender, EventArgs e)
        {

            if (txtWDTypeID.Text == "")
            {
                //donothing
            }
            else if (txtWDTypeID.Text == "1" || txtWDTypeID.Text == "2")
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
                        if(txtWDTypeID.Enabled==true)   { txtWDTypeID.Enabled = false; }
                        if(COBXWDTypeNM.Enabled==true)  { COBXWDTypeNM.Enabled = false; }
                        if(txtWDWgnAmt.Enabled==true)   { txtWDWgnAmt.Enabled = false; }
                        if (txtWDRDAmt.Enabled == true) { txtWDRDAmt.Enabled = false; }
                        if (txtWDHLAmt.Enabled == true) { txtWDHLAmt.Enabled = false; }
                        if (textBoxOWAMT.Enabled == true) { textBoxOWAMT.Enabled = false; }
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

            }//Ends else if for id 1 or 2
            else if (txtWDTypeID.Text == "3" || txtWDTypeID.Text == "4")
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
                            if (txtWDJCAmt.Enabled == true) { txtWDJCAmt.Enabled = false; }
                        }
                        if (txtWDTypeID.Text == "4")
                        {
                            txtWDJCAmt.Text = Convert.ToString(dr.GetValue(3));
                            if (txtWDJCAmt.Enabled == true) { txtWDJCAmt.Enabled = false; }
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

        private void COBXBDBNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ill the text box with the data

            string connstring = "SELECT BatchNum,Name FROM  BatchDetails WHERE BatchNum = " + COBXBDBNO.Text;
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
            OleDbCommand cmd = new OleDbCommand(connstring, conn);

            try
            {
                conn.Open();
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    COBXBDBNO.Text = Convert.ToString(dr.GetValue(0));
                    txtBDBNM.Text = Convert.ToString(dr.GetValue(1));
                    
                    if (txtBDBNM.Enabled == true) { txtBDBNM.Enabled = false; }
                    
                }
                else
                {
                    MessageBox.Show("Invalid BatchNUmber. BatchNumber you have entered doesn't exist. Please enter a valid TypeID or click on Add button to add it to Database.");
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

        private void btnBDUpdate_Click(object sender, EventArgs e)
        {
            btnBDUpdate.Text = "Update";
            if (txtBDBNM.Enabled == false) { txtBDBNM.Enabled = true; }
            if(txtBDBNM.Text!="")
            {
               string connstring = "UPDATE BatchDetails SET Name=" + "'" + txtBDBNM.Text + "'" + " WHERE BatchNum = " + COBXBDBNO.Text +";";
                OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
                OleDbCommand cmd = new OleDbCommand(connstring, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteReader();
                    MessageBox.Show("Data Updated Successfully");
                    btnBDUpdate.Text = "Modify";
                    if (txtBDBNM.Enabled == true) { txtBDBNM.Enabled = false; }

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
            else
            { MessageBox.Show("Batch Name need to be entered"); }

        }

        private void dateTimePickerPLDJNDt_ValueChanged(object sender, EventArgs e)
        {
            lblPLDYASDtVal.Visible = true;
            lblPLDYASDtVal.Text = Convert.ToString( DateTime.Now.Year- dateTimePickerPLDJNDt.Value.Year);

        }

        private void dateTimePickerPLDDOB_ValueChanged(object sender, EventArgs e)
        {
            lblPLDDofRet.Visible = true;
            lblPLDDofRet.Text = dateTimePickerPLDDOB.Value.AddYears(60).Date.ToShortDateString();
        }

        private void txtboxPLDTknNo_Leave(object sender, EventArgs e)
        {
            if(txtboxPLDTknNo.Text!="")
            {
                string connstring = "SELECT ID,TokenNumber,TypeID,BatchNo,JoiningDate,PF,EmpName,EmpFName,Dateofbirth,PFno FROM  EmployeeDetails WHERE TokenNumber = " + txtboxPLDTknNo.Text;
                OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
                OleDbCommand cmd = new OleDbCommand(connstring, conn);

                try
                {
                    conn.Open();
                    OleDbDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        dr.Read();
                        txtboxPLDSINo.Text = Convert.ToString(dr.GetValue(0));
                        txtboxPLDTknNo.Text = Convert.ToString(dr.GetValue(1));
                        comboBoxPLDTypID.Text = Convert.ToString(dr.GetValue(2));
                        comboBoxPLDBtchNo.Text = Convert.ToString(dr.GetValue(3));
                        dateTimePickerPLDJNDt.Text = Convert.ToString(dr.GetValue(4));
                        if (dr.GetBoolean(5) == true)
                        { radioButtonPFYes.Checked = true;
                            textBoxPLDPF.Visible = true;
                        } else
                        { radioButtonPFNo.Checked = false;
                            textBoxPLDPF.Visible = false;
                        }
                        txtboxPLDNM.Text = dr["EmpName"].ToString();
                        txtboxPLDFNM.Text = dr["EmpFName"].ToString();
                        dateTimePickerPLDDOB.Text = dr["Dateofbirth"].ToString();

                       // if (txtboxPLDSINo.Enabled == true) { txtboxPLDSINo.Enabled = false; }
                        if (txtboxPLDTknNo.Enabled == true) { txtboxPLDTknNo.Enabled = false; }
                        if (comboBoxPLDTypID.Enabled == true) { comboBoxPLDTypID.Enabled = false; }
                        if (comboBoxPLDBtchNo.Enabled == true) { comboBoxPLDBtchNo.Enabled = false; }
                        if (dateTimePickerPLDJNDt.Enabled == true) { dateTimePickerPLDJNDt.Enabled = false; }
                        if (radioButtonPFNo.Enabled == true || radioButtonPFNo.Enabled == true) { radioButtonPFNo.Enabled = false; radioButtonPFNo.Enabled = false; }
                        if (textBoxPLDPF.Enabled == true) { textBoxPLDPF.Enabled = false; }
                        if (txtboxPLDNM.Enabled == true) { txtboxPLDNM.Enabled = false; }
                        if (txtboxPLDFNM.Enabled == true) { txtboxPLDFNM.Enabled = false; }
                        if (dateTimePickerPLDDOB.Enabled == true) { dateTimePickerPLDDOB.Enabled = false; }

                    }
                    else
                    {
                        MessageBox.Show("Invalid TokenNumber. Token Number you have entered doesn't exist. Please enter a valid Token ID.");
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

        }

        private void btnPLDUpdate_Click(object sender, EventArgs e)
        {

            if(btnPLDUpdate.Text=="Modify")
            {
                btnPLDUpdate.Text = "Update";
               // if (txtboxPLDSINo.Enabled == false) { txtboxPLDSINo.Enabled = true; }
                if (txtboxPLDTknNo.Enabled == false) { txtboxPLDTknNo.Enabled = true; }
                if (comboBoxPLDTypID.Enabled == false) { comboBoxPLDTypID.Enabled = true; }
                if (comboBoxPLDBtchNo.Enabled == false) { comboBoxPLDBtchNo.Enabled = true; }
                if (dateTimePickerPLDJNDt.Enabled == false) { dateTimePickerPLDJNDt.Enabled = true; }
                if (radioButtonPFNo.Enabled == false || radioButtonPFNo.Enabled == true) { radioButtonPFNo.Enabled = false; radioButtonPFNo.Enabled = true; }
                if (textBoxPLDPF.Enabled == false) { textBoxPLDPF.Enabled = true; }
                if (txtboxPLDNM.Enabled == false) { txtboxPLDNM.Enabled = true; }
                if (txtboxPLDFNM.Enabled == false) { txtboxPLDFNM.Enabled = true; }
                if (dateTimePickerPLDDOB.Enabled == false) { dateTimePickerPLDDOB.Enabled = true; }


            }else if(btnPLDUpdate.Text == "Update")
            {
                int PFYN=0;
                int PFNo = 0;
                if(radioButtonPFYes.Checked)
                { PFYN = 1;
                    PFNo = Convert.ToInt16(textBoxPLDPF.Text);
                }
                else if(radioButtonPFNo.Checked)
                { PFYN = 0; }
                string connstring = "UPDATE EmployeeDetails SET TypeID=" + "'" + comboBoxPLDTypID.Text + "'" + " ,BatchNo=" + "'" 
                    + comboBoxPLDBtchNo.Text + "'" + " ,JoiningDate=" + "'" + dateTimePickerPLDJNDt.Text + "'" + " ,PF=" + "'" 
                    + PFYN + "'"+",EmpName="+"'"+ txtboxPLDNM .Text+ "'"+",EmpFName="+"'"+ txtboxPLDFNM.Text+"'"+
                    ",DateOfBirth="+"'"+ dateTimePickerPLDDOB.Text+"'"+",PFNo="+ PFNo
                    + " WHERE ID=" + txtboxPLDSINo.Text + " AND TokenNumber=" + txtboxPLDTknNo.Text + ";";

                OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
                OleDbCommand cmd = new OleDbCommand(connstring, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfully");
                    
                   // if (txtboxPLDSINo.Enabled == true) { txtboxPLDSINo.Enabled = false; }
                    if (txtboxPLDTknNo.Enabled == true) { txtboxPLDTknNo.Enabled = false; }
                    if (comboBoxPLDTypID.Enabled == true) { comboBoxPLDTypID.Enabled = false; }
                    if (comboBoxPLDBtchNo.Enabled == true) { comboBoxPLDBtchNo.Enabled = false; }
                    if (dateTimePickerPLDJNDt.Enabled == true) { dateTimePickerPLDJNDt.Enabled = false; }
                    if (radioButtonPFNo.Enabled == true || radioButtonPFNo.Enabled == true) { radioButtonPFNo.Enabled = false; radioButtonPFNo.Enabled = false; }
                    if (textBoxPLDPF.Enabled == true) { textBoxPLDPF.Enabled = false; }
                    if (txtboxPLDNM.Enabled == true) { txtboxPLDNM.Enabled = false; }
                    if (txtboxPLDFNM.Enabled == true) { txtboxPLDFNM.Enabled = false; }
                    if (dateTimePickerPLDDOB.Enabled == true) { dateTimePickerPLDDOB.Enabled = false; }
                    btnPLDUpdate.Text = "Modify";

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


        }

        private void btnPLDDel_Click(object sender, EventArgs e)
        {
            if (txtboxPLDTknNo.Text == "")
            {
                MessageBox.Show("Token Number cannot be empty. Please chack and try deleting again");
            }
            else
            {
                string connstring = "DELETE FROM EmployeeDetails  WHERE TokenNumber=" + txtboxPLDTknNo.Text + ";";
                OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
                OleDbCommand cmd = new OleDbCommand(connstring, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Deleted Successfully");

                    txtboxPLDTknNo.Text = "";
                    textBoxPLDPF.Text = "";
                    txtboxPLDNM.Text = "";
                    txtboxPLDFNM.Text = "";
                    txtboxPLDSINo.Text = "";
                    dateTimePickerPLDDOB.Text = "";
                    dateTimePickerPLDJNDt.Text = "";
                    lblPLDYASDtVal.Text = "";
                    lblPLDDofRet.Text = "";
                    if (radioButtonPFYes.Checked)
                    { radioButtonPFYes.Checked = false; }
                    if (radioButtonPFNo.Checked)
                    { radioButtonPFNo.Checked = false; }
                    comboBoxPLDTypID.Text = "";
                    comboBoxPLDBtchNo.Text = "";

                    //if (txtboxPLDSINo.Enabled == false) { txtboxPLDSINo.Enabled = true; }
                    if (txtboxPLDTknNo.Enabled == false) { txtboxPLDTknNo.Enabled = true; }
                    if (comboBoxPLDTypID.Enabled == false) { comboBoxPLDTypID.Enabled = true; }
                    if (comboBoxPLDBtchNo.Enabled == false) { comboBoxPLDBtchNo.Enabled = true; }
                    if (dateTimePickerPLDJNDt.Enabled == false) { dateTimePickerPLDJNDt.Enabled = true; }
                    if (radioButtonPFNo.Enabled == false || radioButtonPFNo.Enabled == false) { radioButtonPFNo.Enabled = true; radioButtonPFNo.Enabled = true; }
                    if (textBoxPLDPF.Enabled == false) { textBoxPLDPF.Enabled = true; }
                    if (txtboxPLDNM.Enabled == false) { txtboxPLDNM.Enabled = true; }
                    if (txtboxPLDFNM.Enabled == false) { txtboxPLDFNM.Enabled = true; }
                    if (dateTimePickerPLDDOB.Enabled == false) { dateTimePickerPLDDOB.Enabled = true; }
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

        private void btnPLDAdd_Click(object sender, EventArgs e)
        {
            Boolean validation = true;
            if (txtboxPLDTknNo.Text == "")
            {
                MessageBox.Show("Token Number cannot be empty. Please chack and try again");

            }
            else
            {
                if(comboBoxPLDTypID.Text=="")
                { MessageBox.Show("Type cannot be blank"); validation = false; }
                if(comboBoxPLDBtchNo.Text=="")
                { MessageBox.Show("Batch No cannot be blank"); validation = false; }
                if(radioButtonPFYes.Checked==false && radioButtonPFNo.Checked==false)
                { MessageBox.Show("PF cannot be blank"); validation = false; }
                if(txtboxPLDNM.Text=="")
                { MessageBox.Show("Name cannot be blank"); validation = false; }
                if(txtboxPLDFNM.Text=="")
                { MessageBox.Show("Father Name cannot be blank"); validation = false; }
                if(textBoxPLDPF.Text=="" && radioButtonPFYes.Checked)
                { MessageBox.Show("PF NO  cannot be blank"); validation = false; }

                if(validation)
                {
                    int pfyn = 0;
                    if(radioButtonPFYes.Checked)
                    { pfyn = 1; }
                    string connstring = "INSERT INTO EmployeeDetails (TokenNumber,TypeID,BatchNo,JoiningDate,PF,EmpName,EmpFname," +
                        "Dateofbirth,PFNo) VALUES (" + txtboxPLDTknNo.Text + "," + "'" + comboBoxPLDTypID.Text + "'" +","+
                        "'"+ comboBoxPLDBtchNo.Text+"'"+","+"'"+ dateTimePickerPLDJNDt.Text+"'"+","+pfyn+","+"'"+ txtboxPLDNM.Text+"'"+
                        ","+"'"+ txtboxPLDFNM.Text+"'"+","+"'"+ dateTimePickerPLDDOB.Text+"'"+","+ textBoxPLDPF.Text+
                        ");";
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
                        validation = true;
                    }

                }   
                    
                
              }

        }

        private void radioButtonPFYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPFYes.Checked)
            { textBoxPLDPF.Visible = true; }

        }

        private void textBoxLDRdTns_Leave(object sender, EventArgs e)
        {

            //Bring the rate from databse and didvide and enter the emount in the respective text boxes
            string connstring = "SELECT ID,Type,WagonAmt,RoadAmt,HLAmt,OpenWagonAmt FROM  WageDetails where ID = 1  ;";
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
            OleDbCommand cmd = new OleDbCommand(connstring, conn);

            try
            {
                conn.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    textBoxLDLDAmtRd.Text = Convert.ToString(textBoxLDRdTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDRdTns.Text)
                                                                * Convert.ToDouble(dr["Roadamt"].ToString()));
                }
             }
             
             catch (Exception ex)
            {
                MessageBox.Show("Exception occured." + ex);
            }
            finally
            {
                conn.Close();
                
            }

            string connstring1 = "SELECT ID,Type,WagonAmt,RoadAmt,HLAmt,OpenWagonAmt FROM  WageDetails where ID = 2  ;";
            OleDbConnection conn1 = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
            OleDbCommand cmd1 = new OleDbCommand(connstring1, conn1);

            try
            {
                conn1.Open();
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {

                    textBoxLDPkrAmtRd.Text = Convert.ToString((textBoxLDRdTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDRdTns.Text))
                                                                    * (Convert.ToDouble(dr1["Roadamt"].ToString())));
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception occured." + ex);
            }
            finally
            {
                conn.Close();

            }


            textBoxLDTotTns.Text = Convert.ToString((textBoxLDRdTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDRdTns.Text)) +
                                                   (textBoxLDWgTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDWgTns.Text)) +
                                                  ( textBoxLDDWWagTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDDWWagTns.Text)) +
                                                   ( textBoxLDHLTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDHLTns.Text)));





            textBoxLDLDTotAmt.Text = Convert.ToString((textBoxLDLDAmtRd.Text==""?0:Convert.ToDouble(textBoxLDLDAmtRd.Text))+
                                                     (textBoxLDLDAmtWg.Text==""?0:Convert.ToDouble(textBoxLDLDAmtWg.Text))+
                                                     (textBoxLDLDAmtHL.Text==""?0:Convert.ToDouble(textBoxLDLDAmtHL.Text))+
                                                     (textBoxLDLDAmtOldWgn.Text==""?0:Convert.ToDouble(textBoxLDLDAmtOldWgn.Text)));

            textBoxLDPkrTotAmt.Text = Convert.ToString((textBoxLDPkrAmtRd.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtRd.Text)) +
                                                        (textBoxLDPkrAmtWg.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtWg.Text)) +
                                                        (textBoxLDPkrAmtHL.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtHL.Text)) +
                                                       ( textBoxLDPkrAmtOldWgn.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtOldWgn.Text)));


        }

        private void textBoxLDLDAmtRd_Leave(object sender, EventArgs e)
        {


            textBoxLDTotTns.Text = Convert.ToString((textBoxLDRdTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDRdTns.Text)) +
                                                  ( textBoxLDWgTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDWgTns.Text)) +
                                                   (textBoxLDDWWagTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDDWWagTns.Text)) +
                                                  ( textBoxLDHLTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDHLTns.Text)));

            textBoxLDLDTotAmt.Text = Convert.ToString((textBoxLDLDAmtRd.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtRd.Text)) +
                                                     (textBoxLDLDAmtWg.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtWg.Text)) +
                                                     (textBoxLDLDAmtHL.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtHL.Text)) +
                                                     (textBoxLDLDAmtOldWgn.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtOldWgn.Text)));

           
        }

        private void textBoxLDLDAmtWg_Leave(object sender, EventArgs e)
        {

            textBoxLDTotTns.Text = Convert.ToString((textBoxLDRdTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDRdTns.Text)) +
                                                   (textBoxLDWgTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDWgTns.Text)) +
                                                   (textBoxLDDWWagTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDDWWagTns.Text)) +
                                                   (textBoxLDHLTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDHLTns.Text)));

            textBoxLDLDTotAmt.Text = Convert.ToString((textBoxLDLDAmtRd.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtRd.Text)) +
                                                     (textBoxLDLDAmtWg.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtWg.Text)) +
                                                     (textBoxLDLDAmtHL.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtHL.Text)) +
                                                     (textBoxLDLDAmtOldWgn.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtOldWgn.Text)));
        }

        private void textBoxLDLDAmtHL_Leave(object sender, EventArgs e)
        {

            textBoxLDTotTns.Text = Convert.ToString((textBoxLDRdTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDRdTns.Text)) +
                                                  ( textBoxLDWgTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDWgTns.Text)) +
                                                   (textBoxLDDWWagTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDDWWagTns.Text)) +
                                                  ( textBoxLDHLTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDHLTns.Text)));

            textBoxLDLDTotAmt.Text = Convert.ToString((textBoxLDLDAmtRd.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtRd.Text)) +
                                                     (textBoxLDLDAmtWg.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtWg.Text)) +
                                                     (textBoxLDLDAmtHL.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtHL.Text)) +
                                                     (textBoxLDLDAmtOldWgn.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtOldWgn.Text)));
        }

        private void textBoxLDLDAmtOldWgn_Leave(object sender, EventArgs e)
        {
            textBoxLDTotTns.Text = Convert.ToString((textBoxLDRdTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDRdTns.Text)) +
                                                   (textBoxLDWgTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDWgTns.Text)) +
                                                   (textBoxLDDWWagTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDDWWagTns.Text)) +
                                                   (textBoxLDHLTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDHLTns.Text)));


            textBoxLDLDTotAmt.Text = Convert.ToString((textBoxLDLDAmtRd.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtRd.Text)) +
                                                     (textBoxLDLDAmtWg.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtWg.Text)) +
                                                     (textBoxLDLDAmtHL.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtHL.Text)) +
                                                     (textBoxLDLDAmtOldWgn.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtOldWgn.Text)));
        }

        private void textBoxLDPkrAmtRd_Leave(object sender, EventArgs e)
        {

            textBoxLDTotTns.Text = Convert.ToString((textBoxLDRdTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDRdTns.Text)) +
                                                  ( textBoxLDWgTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDWgTns.Text)) +
                                                  ( textBoxLDDWWagTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDDWWagTns.Text)) +
                                                   (textBoxLDHLTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDHLTns.Text)));


            textBoxLDPkrTotAmt.Text = Convert.ToString((textBoxLDPkrAmtRd.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtRd.Text)) +
                                                      (textBoxLDPkrAmtWg.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtWg.Text)) +
                                                      (textBoxLDPkrAmtHL.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtHL.Text)) +
                                                      (textBoxLDPkrAmtOldWgn.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtOldWgn.Text)));
        }

        private void textBoxLDPkrAmtWg_Leave(object sender, EventArgs e)
        {

            textBoxLDTotTns.Text = Convert.ToString((textBoxLDRdTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDRdTns.Text)) +
                                                   (textBoxLDWgTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDWgTns.Text)) +
                                                   (textBoxLDDWWagTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDDWWagTns.Text)) +
                                                   (textBoxLDHLTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDHLTns.Text)));

            textBoxLDPkrTotAmt.Text = Convert.ToString((textBoxLDPkrAmtRd.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtRd.Text)) +
                                                      (textBoxLDPkrAmtWg.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtWg.Text)) +
                                                      (textBoxLDPkrAmtHL.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtHL.Text)) +
                                                      (textBoxLDPkrAmtOldWgn.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtOldWgn.Text)));
        }

        private void textBoxLDPkrAmtHL_Leave(object sender, EventArgs e)
        {
            textBoxLDTotTns.Text = Convert.ToString((textBoxLDRdTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDRdTns.Text)) +
                                                   (textBoxLDWgTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDWgTns.Text)) +
                                                   (textBoxLDDWWagTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDDWWagTns.Text)) +
                                                   (textBoxLDHLTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDHLTns.Text)));


            textBoxLDPkrTotAmt.Text = Convert.ToString((textBoxLDPkrAmtRd.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtRd.Text)) +
                                                      (textBoxLDPkrAmtWg.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtWg.Text)) +
                                                      (textBoxLDPkrAmtHL.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtHL.Text)) +
                                                      (textBoxLDPkrAmtOldWgn.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtOldWgn.Text)));
        }

        private void textBoxLDPkrAmtOldWgn_Leave(object sender, EventArgs e)
        {


            textBoxLDTotTns.Text = Convert.ToString((textBoxLDRdTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDRdTns.Text)) +
                                                   (textBoxLDWgTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDWgTns.Text)) +
                                                   (textBoxLDDWWagTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDDWWagTns.Text)) +
                                                   (textBoxLDHLTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDHLTns.Text)));

            textBoxLDPkrTotAmt.Text = Convert.ToString((textBoxLDPkrAmtRd.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtRd.Text)) +
                                                      (textBoxLDPkrAmtWg.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtWg.Text)) +
                                                      (textBoxLDPkrAmtHL.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtHL.Text)) +
                                                      (textBoxLDPkrAmtOldWgn.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtOldWgn.Text)));
        }

        private void textBoxLDNoPkrs_Leave(object sender, EventArgs e)
        {
            if(comboBoxLDBtchNo.Text!="" && comboBoxLDShft.Text!=""&& textBoxLDRdTns.Text!=""&& textBoxLDWgTns.Text!="" && textBoxLDDWWagTns.Text!=""&& textBoxLDHLTns.Text!=""
                && textBoxLDTotTns.Text!="" && textBoxLDNoLdrs.Text!=""&& textBoxLDNoPkrs.Text!="")
            { buttonOK.Visible = true; }
        }

        private void textBoxLDWgTns_Leave(object sender, EventArgs e)
        {
            string connstring = "SELECT ID,Type,WagonAmt,RoadAmt,HLAmt,OpenWagonAmt FROM  WageDetails where ID = 1  ;";
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
            OleDbCommand cmd = new OleDbCommand(connstring, conn);

            try
            {
                conn.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBoxLDLDAmtWg.Text = Convert.ToString(textBoxLDWgTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDWgTns.Text)
                                                                * Convert.ToDouble(dr["WagonAmt"].ToString()));
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception occured." + ex);
            }
            finally
            {
                conn.Close();

            }

            string connstring1 = "SELECT ID,Type,WagonAmt,RoadAmt,HLAmt,OpenWagonAmt FROM  WageDetails where ID = 2  ;";
            OleDbConnection conn1 = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
            OleDbCommand cmd1 = new OleDbCommand(connstring1, conn1);

            try
            {
                conn1.Open();
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {

                    textBoxLDPkrAmtWg.Text = Convert.ToString((textBoxLDWgTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDWgTns.Text))
                                                                    * (Convert.ToDouble(dr1["WagonAmt"].ToString())));
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception occured." + ex);
            }
            finally
            {
                conn.Close();

            }


            textBoxLDTotTns.Text = Convert.ToString((textBoxLDRdTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDRdTns.Text)) +
                                                  (textBoxLDWgTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDWgTns.Text)) +
                                                 (textBoxLDDWWagTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDDWWagTns.Text)) +
                                                  (textBoxLDHLTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDHLTns.Text)));





            textBoxLDLDTotAmt.Text = Convert.ToString((textBoxLDLDAmtRd.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtRd.Text)) +
                                                     (textBoxLDLDAmtWg.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtWg.Text)) +
                                                     (textBoxLDLDAmtHL.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtHL.Text)) +
                                                     (textBoxLDLDAmtOldWgn.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtOldWgn.Text)));

            textBoxLDPkrTotAmt.Text = Convert.ToString((textBoxLDPkrAmtRd.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtRd.Text)) +
                                                        (textBoxLDPkrAmtWg.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtWg.Text)) +
                                                        (textBoxLDPkrAmtHL.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtHL.Text)) +
                                                       (textBoxLDPkrAmtOldWgn.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtOldWgn.Text)));

        }

        private void textBoxLDDWWagTns_Leave(object sender, EventArgs e)
        {
            string connstring = "SELECT ID,Type,WagonAmt,RoadAmt,HLAmt,OpenWagonAmt FROM  WageDetails where ID = 1  ;";
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
            OleDbCommand cmd = new OleDbCommand(connstring, conn);

            try
            {
                conn.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBoxLDLDAmtOldWgn.Text = Convert.ToString(textBoxLDDWWagTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDDWWagTns.Text)
                                                                * Convert.ToDouble(dr["OpenWagonAmt"].ToString()));
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception occured." + ex);
            }
            finally
            {
                conn.Close();

            }

            string connstring1 = "SELECT ID,Type,WagonAmt,RoadAmt,HLAmt,OpenWagonAmt FROM  WageDetails where ID = 2  ;";
            OleDbConnection conn1 = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
            OleDbCommand cmd1 = new OleDbCommand(connstring1, conn1);

            try
            {
                conn1.Open();
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {

                    textBoxLDPkrAmtOldWgn.Text = Convert.ToString((textBoxLDDWWagTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDDWWagTns.Text))
                                                                    * (Convert.ToDouble(dr1["OpenWagonAmt"].ToString())));
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception occured." + ex);
            }
            finally
            {
                conn.Close();

            }

            textBoxLDTotTns.Text = Convert.ToString((textBoxLDRdTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDRdTns.Text)) +
                                                  (textBoxLDWgTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDWgTns.Text)) +
                                                 (textBoxLDDWWagTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDDWWagTns.Text)) +
                                                  (textBoxLDHLTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDHLTns.Text)));

            textBoxLDLDTotAmt.Text = Convert.ToString((textBoxLDLDAmtRd.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtRd.Text)) +
                                                     (textBoxLDLDAmtWg.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtWg.Text)) +
                                                     (textBoxLDLDAmtHL.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtHL.Text)) +
                                                     (textBoxLDLDAmtOldWgn.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtOldWgn.Text)));

            textBoxLDPkrTotAmt.Text = Convert.ToString((textBoxLDPkrAmtRd.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtRd.Text)) +
                                                        (textBoxLDPkrAmtWg.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtWg.Text)) +
                                                        (textBoxLDPkrAmtHL.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtHL.Text)) +
                                                       (textBoxLDPkrAmtOldWgn.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtOldWgn.Text)));

        }

        private void textBoxLDHLTns_Leave(object sender, EventArgs e)
        {
            string connstring = "SELECT ID,Type,WagonAmt,RoadAmt,HLAmt,OpenWagonAmt FROM  WageDetails where ID = 1  ;";
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
            OleDbCommand cmd = new OleDbCommand(connstring, conn);

            try
            {
                conn.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBoxLDLDAmtHL.Text = Convert.ToString(textBoxLDHLTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDHLTns.Text)
                                                                * Convert.ToDouble(dr["HLAmt"].ToString()));
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception occured." + ex);
            }
            finally
            {
                conn.Close();

            }

            string connstring1 = "SELECT ID,Type,WagonAmt,RoadAmt,HLAmt,OpenWagonAmt FROM  WageDetails where ID = 2  ;";
            OleDbConnection conn1 = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
            OleDbCommand cmd1 = new OleDbCommand(connstring1, conn1);

            try
            {
                conn1.Open();
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {

                    textBoxLDPkrAmtHL.Text = Convert.ToString((textBoxLDHLTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDHLTns.Text))
                                                                    * (Convert.ToDouble(dr1["HLAmt"].ToString())));
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception occured." + ex);
            }
            finally
            {
                conn.Close();

            }

            textBoxLDTotTns.Text = Convert.ToString((textBoxLDRdTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDRdTns.Text)) +
                                                  (textBoxLDWgTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDWgTns.Text)) +
                                                 (textBoxLDDWWagTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDDWWagTns.Text)) +
                                                  (textBoxLDHLTns.Text == "" ? 0 : Convert.ToDouble(textBoxLDHLTns.Text)));

            textBoxLDLDTotAmt.Text = Convert.ToString((textBoxLDLDAmtRd.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtRd.Text)) +
                                                     (textBoxLDLDAmtWg.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtWg.Text)) +
                                                     (textBoxLDLDAmtHL.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtHL.Text)) +
                                                     (textBoxLDLDAmtOldWgn.Text == "" ? 0 : Convert.ToDouble(textBoxLDLDAmtOldWgn.Text)));

            textBoxLDPkrTotAmt.Text = Convert.ToString((textBoxLDPkrAmtRd.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtRd.Text)) +
                                                        (textBoxLDPkrAmtWg.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtWg.Text)) +
                                                        (textBoxLDPkrAmtHL.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtHL.Text)) +
                                                       (textBoxLDPkrAmtOldWgn.Text == "" ? 0 : Convert.ToDouble(textBoxLDPkrAmtOldWgn.Text)));

        }

        public void buttonOK_Click(object sender, EventArgs e)
        {
            string connstring = "SELECT ID,EmpName,BatchNo,TypeID,TokenNumber FROM  EmployeeDetails where BatchNo ="+"'" + comboBoxLDBtchNo.Text +"'"+ ";";
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["RassiCements_LTD.Properties.Settings.RassiCementLTDConnectionString"].ConnectionString);
            OleDbCommand cmd = new OleDbCommand(connstring, conn);

            try
            {
                conn.Open();
                OleDbDataReader dr = cmd.ExecuteReader();

                
               
                        emp.Columns.Add("Sel",typeof(bool));
                        emp.Columns.Add("SNO", typeof(int));
                        emp.Columns.Add("Name", typeof(string));
                        emp.Columns.Add("BatchNo", typeof(int));
                        emp.Columns.Add("Type",typeof(string));
                        emp.Columns.Add("TokenNo",typeof(int));
                        emp.Columns.Add("Shift",typeof(string));
                        emp.Columns.Add("Date", typeof(string));
                        emp.Columns.Add("DayAmount",typeof(double));
                        emp.Columns.Add("Contractor",typeof(string));

                

                    while (dr.Read())
                    {
                        emp.Rows.Add( false,Convert.ToInt16(dr["ID"].ToString()),dr["EmpName"].ToString(),Convert.ToInt16(dr["BatchNo"].ToString())
                        ,dr["TypeID"].ToString(), Convert.ToInt16(dr["TokenNumber"].ToString()), comboBoxLDShft.Text, dateTimePickerLDDt.Text,
                        dr["TypeID"].ToString()=="Loader"?Convert.ToDouble(textBoxLDLDTotAmt.Text):Convert.ToDouble(textBoxLDPkrTotAmt.Text),
                        textBoxOCCNM.Text);
                    }
                
                dataGridView1.DataSource = emp;
                dataGridView1.Columns[0].Width = 0;
                //Datatable initiliase
                Nemp.Columns.Add("Sel", typeof(bool));
                Nemp.Columns.Add("SNO", typeof(int));
                Nemp.Columns.Add("Name", typeof(string));
                Nemp.Columns.Add("BatchNo", typeof(int));
                Nemp.Columns.Add("Type", typeof(string));
                Nemp.Columns.Add("TokenNo", typeof(int));
                Nemp.Columns.Add("Shift", typeof(string));
                Nemp.Columns.Add("Date", typeof(string));
                Nemp.Columns.Add("DayAmount", typeof(double));
                Nemp.Columns.Add("Contractor", typeof(string));


            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception occured." + ex);
            }
            finally
            {
                conn.Close();

            }
        }

        private void btnRi8_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in emp.Rows)
            {
                if(Convert.ToBoolean( dr["Sel"].ToString())==true)
                {
                    Nemp.ImportRow(dr);
                    dr.Delete();
                }
                
            }
            dataGridView2.DataSource = Nemp;
            dataGridView2.Columns[0].Width = 0;
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //Donothing
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            if(dataGridView1.SelectedRows.Count>0)
            {
                if ( Convert.ToBoolean( dataGridView1.SelectedRows[0].Cells[0].Value) == false)
                {
                    dataGridView1.SelectedRows[0].Cells[0].Value = true;
                    dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
                    emp.AcceptChanges();
                }
                else
                {
                    dataGridView1.SelectedRows[0].Cells[0].Value = false;
                    dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
                    emp.AcceptChanges();

                }

            }
           
        }

        private void btnLft_Click(object sender, EventArgs e)
        {

            foreach(DataRow dr in Nemp.Rows)
            {
                if ( Convert.ToBoolean( dr["Sel"].ToString()) ==true)
                {
                    emp.ImportRow(dr);
                    dr.Delete();
                }
               
            }
            dataGridView1.DataSource = emp;
            
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                if ( Convert.ToBoolean( dataGridView2.SelectedRows[0].Cells[0].Value) == false)
                {
                    dataGridView2.SelectedRows[0].Cells[0].Value = true;
                    dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Blue;
                    Nemp.AcceptChanges();
                }
                else
                {
                    dataGridView2.SelectedRows[0].Cells[0].Value = false;
                    dataGridView2.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
                    Nemp.AcceptChanges();
                }

            }
        }
    }
}
