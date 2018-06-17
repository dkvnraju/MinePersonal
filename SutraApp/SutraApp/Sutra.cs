using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace SutraApp
{
    public partial class Sutra : Form
    {
        public Sutra()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to exit?", "Exit Window", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { Application.Exit(); }
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbltextShrtSkrt();
        }

        private void  lbltextShrtSkrt()
        {
            if (comboBoxGrade.SelectedIndex !=1 && comboBoxGrade.SelectedIndex >=0 && comboBoxGrade.SelectedIndex <=2)
                { labelShrtSkrt.Text = "Dungree :"; }

            else if (comboBoxGender.Text=="Boy")
            {                
                if (comboBoxGrade.SelectedIndex <=9 && comboBoxGrade.SelectedIndex != -1)
                {
                    labelShrtSkrt.Text = "Short :";
                } else if(comboBoxGrade.SelectedIndex > 9 && comboBoxGrade.SelectedIndex != -1)
                { labelShrtSkrt.Text = "Pant :"; }
            }else if (comboBoxGender.Text=="Girl")
            { if(comboBoxGrade.SelectedIndex <= 9 && comboBoxGrade.SelectedIndex != -1)
                { labelShrtSkrt.Text = "Skirt :"; } else if (comboBoxGrade.SelectedIndex > 9 && comboBoxGrade.SelectedIndex != -1) { labelShrtSkrt.Text = "Skirt :"; }      
                        
             }

        }

        private void comboBoxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbltextShrtSkrt();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parenttabcontrol.Visible = true;
           
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SutraApp.Properties.Settings.Connection"].ConnectionString))
            {
                string Query = "Select SchoolID from School;";

                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(Query, conn);

                    DataSet schDs = new DataSet();
                    da.Fill(schDs, "School");



                    foreach (DataRow row in schDs.Tables["School"].Rows)
                    {
                        comboBoxSC.Items.Add(row["SchoolID"].ToString());

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Following error Occured" + ex.Message);
                }
              
            }
            

        }

        private void comboBoxSC_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SutraApp.Properties.Settings.Connection"].ConnectionString))
            {
                        
                string Query = "Select SchoolNM from School where SchoolID="+"'"+ comboBoxSC.Text +"'"+ ";";

                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(Query, conn);

                    DataSet schDs = new DataSet();
                    da.Fill(schDs, "School");



                    foreach (DataRow row in schDs.Tables["School"].Rows)
                    {

                        LblSchoolname.Text = row["SchoolNM"].ToString();

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Following error Occured" + ex.Message);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LblSchoolname.Text = "";
            comboBoxSC.Text = "";
            TxtCustNbr.Text = "";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (panelFind.Visible == true)
            { panelFind.Visible = false; }
            else { panelFind.Visible = true;  }
            
        }

        private void buttonFclean_Click(object sender, EventArgs e)
        {
            textBoxFnm.Text = "";
            textBoxFCNM.Text = "";
            textBoxFM.Text = "";
        }

        private void buttonAddschool_Click(object sender, EventArgs e)
        {

            if(textBoxSchoolNm.Text!="" && textBoxSchoolCd.Text!="")
            { 
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SutraApp.Properties.Settings.Connection"].ConnectionString))
                {
                            try { 
                            string Query = "Insert into  School (SchoolNm,SchoolID) Values (" + "'" + textBoxSchoolNm.Text.Trim() + "' , '"+ textBoxSchoolCd.Text.Trim() + "' ) ;";

                            SqlCommand cmd = new SqlCommand(Query,conn);
                        conn.Open();
                            int count = cmd.ExecuteNonQuery();
                            if (count !=0)
                            { MessageBox.Show("Data Inserted successfully");
                            buttonClear_Click(sender,e);
                            }
                            else
                            { MessageBox.Show("Data was not inserted"); }
                            }
                    catch(Exception ex)
                    { MessageBox.Show("Following Exception occured while inserting data" +ex.Message); }
                    finally
                    {
                        conn.Close();
                    }
                }

            }
            else
            { MessageBox.Show("Please check the Input's and try again");
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSchoolNm.Text = "";
            textBoxSchoolCd.Text = "";
        }

        private void Sutra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sutraDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.sutraDataSet1.Products);
            // TODO: This line of code loads data into the 'sutraDataSet.School' table. You can move, or remove it, as needed.
            this.schoolTableAdapter.Fill(this.sutraDataSet.School);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridViewSchool.Visible = true;
        }


        private void buttonSSave_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.Update(this.sutraDataSet1.Products);
            this.sutraDataSet1.Products.AcceptChanges();
            MessageBox.Show("Data Inserted Successfully");
        }

       

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillData(this.sutraDataSet1.Products, toolStripComboBox1.Text);
                dataGridViewPrdt.DataSource = this.sutraDataSet1.Products;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void parenttabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (parenttabcontrol.TabPages["tabPagesSE"].Text== "Stock Entry")
            {
                toolStripComboBox1.Text = "";
                dataGridViewPrdt.DataSource = null;
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillBy(this.sutraDataSet1.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SutraApp.Properties.Settings.Connection"].ConnectionString))
            {

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Student_insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@StdID", (TxtCustNbr.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@SchoolCd", (comboBoxSC.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@StdNm", (TxtStdNm.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@mobile",Convert.ToInt32( (TxtConcatNum.Text))));
                    cmd.Parameters.Add(new SqlParameter("@landline",Convert.ToInt32( (TxtLndLine.Text).Trim())));
                    cmd.Parameters.Add(new SqlParameter("@email", (textBox1.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@gender", (comboBoxGender.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@grade", (comboBoxGrade.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@ShirtSz", (comboBoxShirt.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@ShirtQnt",Convert.ToInt16( (textBoxShirt.Text).Trim())));
                    cmd.Parameters.Add(new SqlParameter("@ShrtSkrtSz", (comboBoxShrtSkrt.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@ShrtSkrtQnt", (Convert.ToInt16((textBoxShrtSkrt.Text).Trim()))));
                    cmd.Parameters.Add(new SqlParameter("@TshirtSz", (comboBoxTShirt.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@TshirtQnt", (Convert.ToInt16( (textBoxSTShrt.Text).Trim()))));
                    cmd.Parameters.Add(new SqlParameter("@ShortSz", (comboBoxShort.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@ShortQnt", (Convert.ToInt16( (textBoxSShort.Text).Trim()))));
                    cmd.Parameters.Add(new SqlParameter("@HDJacSz", (comboBoxHodiee.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@HDJacQnt",Convert.ToInt16( (textBoxHdJac.Text).Trim())));
                    cmd.Parameters.Add(new SqlParameter("@beltSz", (comboBoxBelt.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@beltQnt", Convert.ToInt16((textBoxBlt.Text).Trim())));
                    cmd.Parameters.Add(new SqlParameter("@shoeSz", (comboBoxShoes.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@ShoeQnt", Convert.ToInt16((textBox2.Text).Trim())));
                    cmd.Parameters.Add(new SqlParameter("@SocusSz", (comboBoxShoeSz.Text).Trim()));

                    cmd.Parameters.Add(new SqlParameter("@SocusQnt", Convert.ToInt16((textBoxskx.Text).Trim())));
                    cmd.Parameters.Add(new SqlParameter("@CShoeSz", (comboBoxCShoeSz.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@CShoeQnt", Convert.ToInt16((textBoxCSh.Text).Trim())));
                    cmd.Parameters.Add(new SqlParameter("@Amount", Convert.ToDouble((textBox4.Text).Trim())));
                    cmd.Parameters.Add(new SqlParameter("@Pay_Optn", (comboBoxPOP.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@pay_Ref", (textBox3.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@pay_Status", (comboBoxPSts.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@order_Status", (comboBox1OrderSts.Text).Trim()));


                    int count = cmd.ExecuteNonQuery();
                    if (count != 0)
                    { MessageBox.Show("Data Inserted Successfully!"); }
                    else { MessageBox.Show("Data Not Inserted"); }
                }
                catch(Exception ex)
                { MessageBox.Show("Excepion occured"+ex.Message); }
                finally { conn.Close(); }
            }
        }

        private void TxtCustNbr_Leave(object sender, EventArgs e)
        {
            if(TxtCustNbr.Text=="")
            {
                MessageBox.Show("Student Number Cannot be Blank");
            }
            else
            {
                TxtCustNbr.Text = comboBoxSC.Text + TxtCustNbr.Text;
                TxtCustNbr.Enabled = false;
            }
           
        }

        private void TxtStdNm_Leave(object sender, EventArgs e)
        {
            if (TxtStdNm.Text=="")
            { MessageBox.Show("Student name cannot be left blank"); }
        }

        private void TxtConcatNum_Leave(object sender, EventArgs e)
        {
            if(TxtConcatNum.Text=="")
            { MessageBox.Show("Mobile Number cannot be blank"); }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            { MessageBox.Show("Email Cannot  be blank"); }
        }

        private void buttonStUpdt_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.Update(this.sutraDataSet1.Products);
            dataGridViewPrdt.Refresh();
            MessageBox.Show("Data Updated Successfully");
        }
    }
}
