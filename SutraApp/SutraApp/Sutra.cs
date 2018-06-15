using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
    }
}
