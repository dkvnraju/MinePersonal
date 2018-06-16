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

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panelFind.Visible = true;
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
            MessageBox.Show("Data Inserted/Upated Successfully");
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
    }
}
