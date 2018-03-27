namespace RassiCements_LTD
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allowancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblWDHeading = new System.Windows.Forms.Label();
            this.lblWDTypeID = new System.Windows.Forms.Label();
            this.lblWDTypeNM = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWDWgnAmt = new System.Windows.Forms.Label();
            this.lblWDRdAmt = new System.Windows.Forms.Label();
            this.lblWDHLAmt = new System.Windows.Forms.Label();
            this.txtWDTypeID = new System.Windows.Forms.TextBox();
            this.txtWDWgnAmt = new System.Windows.Forms.TextBox();
            this.txtWDRDAmt = new System.Windows.Forms.TextBox();
            this.txtWDHLAmt = new System.Windows.Forms.TextBox();
            this.btnWDSave = new System.Windows.Forms.Button();
            this.btnWDUpdate = new System.Windows.Forms.Button();
            this.btnWDClr = new System.Windows.Forms.Button();
            this.btnWDDel = new System.Windows.Forms.Button();
            this.COBXWDTypeNM = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem,
            this.allowancesToolStripMenuItem,
            this.personalDetailsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // allowancesToolStripMenuItem
            // 
            this.allowancesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.allowancesToolStripMenuItem.Name = "allowancesToolStripMenuItem";
            this.allowancesToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.allowancesToolStripMenuItem.Text = "Allowances";
            this.allowancesToolStripMenuItem.Click += new System.EventHandler(this.allowancesToolStripMenuItem_Click);
            // 
            // personalDetailsToolStripMenuItem
            // 
            this.personalDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.personalDetailsToolStripMenuItem.Name = "personalDetailsToolStripMenuItem";
            this.personalDetailsToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.personalDetailsToolStripMenuItem.Text = "Personal Details";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(619, 425);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.lblWDHeading);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(611, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 202);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(673, 202);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(673, 202);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblWDHeading
            // 
            this.lblWDHeading.AutoSize = true;
            this.lblWDHeading.Font = new System.Drawing.Font("Arial Black", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWDHeading.Location = new System.Drawing.Point(233, 27);
            this.lblWDHeading.Name = "lblWDHeading";
            this.lblWDHeading.Size = new System.Drawing.Size(161, 27);
            this.lblWDHeading.TabIndex = 0;
            this.lblWDHeading.Text = "Wages Details";
            // 
            // lblWDTypeID
            // 
            this.lblWDTypeID.AutoSize = true;
            this.lblWDTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWDTypeID.Location = new System.Drawing.Point(44, 14);
            this.lblWDTypeID.Name = "lblWDTypeID";
            this.lblWDTypeID.Size = new System.Drawing.Size(59, 15);
            this.lblWDTypeID.TabIndex = 1;
            this.lblWDTypeID.Text = "Type ID:";
            // 
            // lblWDTypeNM
            // 
            this.lblWDTypeNM.AutoSize = true;
            this.lblWDTypeNM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWDTypeNM.Location = new System.Drawing.Point(31, 45);
            this.lblWDTypeNM.Name = "lblWDTypeNM";
            this.lblWDTypeNM.Size = new System.Drawing.Size(83, 15);
            this.lblWDTypeNM.TabIndex = 2;
            this.lblWDTypeNM.Text = "Type Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.COBXWDTypeNM);
            this.panel1.Controls.Add(this.btnWDDel);
            this.panel1.Controls.Add(this.btnWDClr);
            this.panel1.Controls.Add(this.btnWDUpdate);
            this.panel1.Controls.Add(this.btnWDSave);
            this.panel1.Controls.Add(this.txtWDHLAmt);
            this.panel1.Controls.Add(this.txtWDRDAmt);
            this.panel1.Controls.Add(this.txtWDWgnAmt);
            this.panel1.Controls.Add(this.txtWDTypeID);
            this.panel1.Controls.Add(this.lblWDHLAmt);
            this.panel1.Controls.Add(this.lblWDRdAmt);
            this.panel1.Controls.Add(this.lblWDWgnAmt);
            this.panel1.Controls.Add(this.lblWDTypeID);
            this.panel1.Controls.Add(this.lblWDTypeNM);
            this.panel1.Location = new System.Drawing.Point(90, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 294);
            this.panel1.TabIndex = 3;
            // 
            // lblWDWgnAmt
            // 
            this.lblWDWgnAmt.AutoSize = true;
            this.lblWDWgnAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWDWgnAmt.Location = new System.Drawing.Point(11, 82);
            this.lblWDWgnAmt.Name = "lblWDWgnAmt";
            this.lblWDWgnAmt.Size = new System.Drawing.Size(107, 15);
            this.lblWDWgnAmt.TabIndex = 3;
            this.lblWDWgnAmt.Text = "Wagon Amount:";
            // 
            // lblWDRdAmt
            // 
            this.lblWDRdAmt.AutoSize = true;
            this.lblWDRdAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWDRdAmt.Location = new System.Drawing.Point(17, 119);
            this.lblWDRdAmt.Name = "lblWDRdAmt";
            this.lblWDRdAmt.Size = new System.Drawing.Size(97, 15);
            this.lblWDRdAmt.TabIndex = 4;
            this.lblWDRdAmt.Text = "Road Amount:";
            // 
            // lblWDHLAmt
            // 
            this.lblWDHLAmt.AutoSize = true;
            this.lblWDHLAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWDHLAmt.Location = new System.Drawing.Point(31, 149);
            this.lblWDHLAmt.Name = "lblWDHLAmt";
            this.lblWDHLAmt.Size = new System.Drawing.Size(81, 15);
            this.lblWDHLAmt.TabIndex = 5;
            this.lblWDHLAmt.Text = "HL Amount:";
            // 
            // txtWDTypeID
            // 
            this.txtWDTypeID.Location = new System.Drawing.Point(124, 9);
            this.txtWDTypeID.Name = "txtWDTypeID";
            this.txtWDTypeID.Size = new System.Drawing.Size(100, 20);
            this.txtWDTypeID.TabIndex = 6;
            // 
            // txtWDWgnAmt
            // 
            this.txtWDWgnAmt.Location = new System.Drawing.Point(124, 82);
            this.txtWDWgnAmt.Name = "txtWDWgnAmt";
            this.txtWDWgnAmt.Size = new System.Drawing.Size(100, 20);
            this.txtWDWgnAmt.TabIndex = 8;
            // 
            // txtWDRDAmt
            // 
            this.txtWDRDAmt.Location = new System.Drawing.Point(124, 114);
            this.txtWDRDAmt.Name = "txtWDRDAmt";
            this.txtWDRDAmt.Size = new System.Drawing.Size(100, 20);
            this.txtWDRDAmt.TabIndex = 9;
            // 
            // txtWDHLAmt
            // 
            this.txtWDHLAmt.Location = new System.Drawing.Point(124, 148);
            this.txtWDHLAmt.Name = "txtWDHLAmt";
            this.txtWDHLAmt.Size = new System.Drawing.Size(100, 20);
            this.txtWDHLAmt.TabIndex = 10;
            // 
            // btnWDSave
            // 
            this.btnWDSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWDSave.Location = new System.Drawing.Point(20, 213);
            this.btnWDSave.Name = "btnWDSave";
            this.btnWDSave.Size = new System.Drawing.Size(75, 23);
            this.btnWDSave.TabIndex = 11;
            this.btnWDSave.Text = "Save";
            this.btnWDSave.UseVisualStyleBackColor = true;
            // 
            // btnWDUpdate
            // 
            this.btnWDUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWDUpdate.Location = new System.Drawing.Point(115, 213);
            this.btnWDUpdate.Name = "btnWDUpdate";
            this.btnWDUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnWDUpdate.TabIndex = 12;
            this.btnWDUpdate.Text = "Update";
            this.btnWDUpdate.UseVisualStyleBackColor = true;
            // 
            // btnWDClr
            // 
            this.btnWDClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWDClr.Location = new System.Drawing.Point(210, 213);
            this.btnWDClr.Name = "btnWDClr";
            this.btnWDClr.Size = new System.Drawing.Size(75, 23);
            this.btnWDClr.TabIndex = 13;
            this.btnWDClr.Text = "Clear";
            this.btnWDClr.UseVisualStyleBackColor = true;
            // 
            // btnWDDel
            // 
            this.btnWDDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWDDel.Location = new System.Drawing.Point(309, 213);
            this.btnWDDel.Name = "btnWDDel";
            this.btnWDDel.Size = new System.Drawing.Size(75, 23);
            this.btnWDDel.TabIndex = 14;
            this.btnWDDel.Text = "Delete";
            this.btnWDDel.UseVisualStyleBackColor = true;
            // 
            // COBXWDTypeNM
            // 
            this.COBXWDTypeNM.FormattingEnabled = true;
            this.COBXWDTypeNM.Items.AddRange(new object[] {
            "",
            "Wagon",
            "Road",
            "HL"});
            this.COBXWDTypeNM.Location = new System.Drawing.Point(124, 45);
            this.COBXWDTypeNM.Name = "COBXWDTypeNM";
            this.COBXWDTypeNM.Size = new System.Drawing.Size(100, 21);
            this.COBXWDTypeNM.TabIndex = 15;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allowancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblWDHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWDWgnAmt;
        private System.Windows.Forms.Label lblWDTypeID;
        private System.Windows.Forms.Label lblWDTypeNM;
        private System.Windows.Forms.Label lblWDHLAmt;
        private System.Windows.Forms.Label lblWDRdAmt;
        private System.Windows.Forms.Button btnWDDel;
        private System.Windows.Forms.Button btnWDClr;
        private System.Windows.Forms.Button btnWDUpdate;
        private System.Windows.Forms.Button btnWDSave;
        private System.Windows.Forms.TextBox txtWDHLAmt;
        private System.Windows.Forms.TextBox txtWDRDAmt;
        private System.Windows.Forms.TextBox txtWDWgnAmt;
        private System.Windows.Forms.TextBox txtWDTypeID;
        private System.Windows.Forms.ComboBox COBXWDTypeNM;
    }
}

