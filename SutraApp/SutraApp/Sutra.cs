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
    }
}
