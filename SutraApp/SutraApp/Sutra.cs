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
                string QueryP = "Select Distinct Size from products;";

                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(Query, conn);

                    SqlDataAdapter dap = new SqlDataAdapter(QueryP,conn);

                    DataSet schDs = new DataSet();

                    dap.Fill(schDs,"Products");
                    da.Fill(schDs, "School");



                    foreach (DataRow row in schDs.Tables["School"].Rows)
                    {
                        comboBoxSC.Items.Add(row["SchoolID"].ToString());

                    }

                    foreach(DataRow row in schDs.Tables["Products"].Rows)
                    {
                        comboBoxShirt.Items.Add(row["Size"].ToString());
                        comboBoxShrtSkrt.Items.Add(row["Size"].ToString());
                        comboBoxTShirt.Items.Add(row["Size"].ToString());
                        comboBoxShort.Items.Add(row["Size"].ToString());
                        comboBoxHodiee.Items.Add(row["Size"].ToString());
                        comboBoxBelt.Items.Add(row["Size"].ToString());
                        comboBoxShoes.Items.Add(row["Size"].ToString());
                        comboBoxShoeSz.Items.Add(row["Size"].ToString());
                        comboBoxCShoeSz.Items.Add(row["Size"].ToString());


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
            TxtStdNm.Text = "";
            TxtConcatNum.Text = "";
            dateTimePickerDt.Text = "";
            textBox1.Text = "";
            comboBoxGender.Text = "";
            comboBoxGrade.Text = "";
            comboBoxShirt.Text = "";
            textBoxShirt.Text = "";
            comboBoxShrtSkrt.Text = "";
            textBoxShrtSkrt.Text = "";
            comboBoxTShirt.Text = "";
            textBoxSTShrt.Text = "";
            comboBoxShort.Text = "";
            textBoxSShort.Text = "";
            comboBoxHodiee.Text = "";
            textBoxHdJac.Text = "";
            comboBoxBelt.Text = "";
            textBoxBlt.Text = "";
            comboBoxShoes.Text = "";
            textBox2.Text = "";
            comboBoxShoeSz.Text = "";
            textBoxskx.Text = "";
            comboBoxCShoeSz.Text = "";
            textBoxCSh.Text = "";
            textBox4.Text = "";
            comboBoxPOP.Text = "";
            textBox3.Text = "";
            comboBoxPSts.Text = "";
            comboBox1OrderSts.Text = "";

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

            toolStripComboBox1.Text = "";
            dataGridViewPrdt.DataSource = null;
            this.productsTableAdapter.FillBy(this.sutraDataSet1.Products);
            //.FillData(this.sutraDataSet1.Products, toolStripComboBox1.Text);
            dataGridViewStock.DataSource = this.sutraDataSet1.Products;
            dataGridViewStock.Refresh();

            if(dataGridViewSchool.Visible==true)
            {
               // dataGridViewSchool.DataSource = null;
                dataGridViewSchool.Visible = false;
            }
            //if (parenttabcontrol.TabPages["tabPagesSE"].Text== "Stock Entry")
            //{
               
            //    dataGridViewPrdt.DataSource = null;
            //}
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
                    cmd.Parameters.Add(new SqlParameter("@mobile",Convert.ToInt64(TxtConcatNum.Text)));
                    cmd.Parameters.Add(new SqlParameter("@Date",Convert.ToDateTime( (dateTimePickerDt.Text).Trim())));
                    cmd.Parameters.Add(new SqlParameter("@email", (textBox1.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@gender", (comboBoxGender.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@grade", (comboBoxGrade.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@ShirtSz", (comboBoxShirt.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@ShirtQnt",Convert.ToInt32( (textBoxShirt.Text).Trim())));
                    cmd.Parameters.Add(new SqlParameter("@ShrtSkrtSz", (comboBoxShrtSkrt.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@ShrtSkrtQnt", (Convert.ToInt32((textBoxShrtSkrt.Text).Trim()))));
                    cmd.Parameters.Add(new SqlParameter("@TshirtSz", (comboBoxTShirt.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@TshirtQnt", (Convert.ToInt32( (textBoxSTShrt.Text).Trim()))));
                    cmd.Parameters.Add(new SqlParameter("@ShortSz", (comboBoxShort.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@ShortQnt", (Convert.ToInt32( (textBoxSShort.Text).Trim()))));
                    cmd.Parameters.Add(new SqlParameter("@HDJacSz", (comboBoxHodiee.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@HDJacQnt",Convert.ToInt32( (textBoxHdJac.Text).Trim())));
                    cmd.Parameters.Add(new SqlParameter("@beltSz", (comboBoxBelt.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@beltQnt", Convert.ToInt32((textBoxBlt.Text).Trim())));
                    cmd.Parameters.Add(new SqlParameter("@shoeSz", (comboBoxShoes.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@ShoeQnt", Convert.ToInt32((textBox2.Text).Trim())));
                    cmd.Parameters.Add(new SqlParameter("@SocusSz", (comboBoxShoeSz.Text).Trim()));

                    cmd.Parameters.Add(new SqlParameter("@SocusQnt", Convert.ToInt32((textBoxskx.Text).Trim())));
                    cmd.Parameters.Add(new SqlParameter("@CShoeSz", (comboBoxCShoeSz.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@CShoeQnt", Convert.ToInt32((textBoxCSh.Text).Trim())));
                    cmd.Parameters.Add(new SqlParameter("@Amount", Convert.ToDouble((textBox4.Text).Trim())));
                    cmd.Parameters.Add(new SqlParameter("@Pay_Optn", (comboBoxPOP.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@pay_Ref", (textBox3.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@pay_Status", (comboBoxPSts.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@order_Status", (comboBox1OrderSts.Text).Trim()));


                    // SqlDataReader count = cmd.ExecuteReader();
                   int count = cmd.ExecuteNonQuery();

                    if (count > 0)
                    { MessageBox.Show("Data Inserted Successfully!"); }


                }
                catch (Exception ex)
                { MessageBox.Show("Excepion occured-"+ex.Message); }
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
            dataGridViewStock.Refresh();
            MessageBox.Show("Data Updated Successfully");
        }

        private void buttonStdUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SutraApp.Properties.Settings.Connection"].ConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Student_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@StdID", (TxtCustNbr.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@pay_Status", (comboBoxPSts.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@order_Status", (comboBox1OrderSts.Text).Trim()));
                    int count = cmd.ExecuteNonQuery();

                    if (count > 0)
                    { MessageBox.Show("Data Updated Successfully!"); }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Excelption occuered with the following "+ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SutraApp.Properties.Settings.Connection"].ConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Get_Std_Details", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@StdID",String.IsNullOrWhiteSpace(textBoxFCNM.Text)? null:( textBoxFCNM.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@StdNm",String.IsNullOrWhiteSpace(textBoxFnm.Text)?null:(textBoxFnm.Text).Trim()));
                    cmd.Parameters.Add(new SqlParameter("@mobile",String.IsNullOrWhiteSpace(textBoxFM.Text)?null:(textBoxFM.Text).Trim()));
                    SqlDataReader reader= cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            TxtCustNbr.Text=reader["StdID"].ToString();
                            TxtStdNm.Text = reader["StdNm"].ToString();
                            comboBoxSC.Text = reader["SchoolID"].ToString();
                            TxtConcatNum.Text= reader["Mobile"].ToString();
                            dateTimePickerDt.Text= reader["Date"].ToString();
                            comboBoxGender.Text= reader["Gender"].ToString();
                            textBox1.Text= reader["Email"].ToString();
                            textBox4.Text= reader["Amount"].ToString();
                            textBoxBlt.Text= reader["BeltQnt"].ToString();
                            comboBoxBelt.Text= reader["BeltSz"].ToString();
                            textBoxCSh.Text= reader["CycShoesQnt"].ToString();
                            comboBoxCShoeSz.Text= reader["CycShoesSz"].ToString();
                            comboBoxGrade.Text= reader["Grade"].ToString();
                            textBoxHdJac.Text= reader["HodJackQnt"].ToString();
                            comboBoxHodiee.Text= reader["HodJackSz"].ToString();
                            comboBox1OrderSts.Text= reader["Order_Status"].ToString();
                            comboBoxPOP.Text= reader["Pay_Optn"].ToString();
                            textBox3.Text= reader["Pay_Ref"].ToString();
                            comboBoxPSts.Text= reader["Pay_Status"].ToString();
                            textBoxShirt.Text= reader["ShirtQnt"].ToString();
                            comboBoxShirt.Text= reader["ShirtSz"].ToString();
                            textBoxSShort.Text= reader["ShortQnt"].ToString();
                            comboBoxShort.Text= reader["ShortSz"].ToString();
                            textBoxShrtSkrt.Text= reader["ShrtSkrtQnt"].ToString();
                            comboBoxShrtSkrt.Text= reader["ShrtSkrtSz"].ToString();
                            textBoxskx.Text= reader["SocusQnt"].ToString();
                            comboBoxShoeSz.Text= reader["SocusSz"].ToString();
                            textBoxSTShrt.Text= reader["TShirtQnt"].ToString();
                            comboBoxTShirt.Text= reader["TShirtSz"].ToString();
                            //reader["SchoolID"].ToString();
                            //reader["SchoolID"].ToString();
                            //reader["SchoolID"].ToString();
                            //reader["SchoolID"].ToString();
                            //reader["SchoolID"].ToString();
                            //reader["SchoolID"].ToString();
                            //reader["SchoolID"].ToString();
                            //reader["SchoolID"].ToString();
                            //reader["SchoolID"].ToString();
                            //reader["SchoolID"].ToString();
                            //reader["SchoolID"].ToString();
                            //reader["SchoolID"].ToString();
                        }
                        
                    }
                    else
                    { MessageBox.Show("No Data Found"); }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excelption occuered with the following " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

        }
    }
}
