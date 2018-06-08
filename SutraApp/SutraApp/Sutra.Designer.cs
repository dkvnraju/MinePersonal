namespace SutraApp
{
    partial class Sutra
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
            this.HomePanel = new System.Windows.Forms.Panel();
            this.parenttabcontrol = new System.Windows.Forms.TabControl();
            this.tabPagestdtl = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtLndLine = new System.Windows.Forms.TextBox();
            this.lbllandline = new System.Windows.Forms.Label();
            this.TxtConcatNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtStdNm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCustNbr = new System.Windows.Forms.TextBox();
            this.lblCustomerno = new System.Windows.Forms.Label();
            this.LblSchoolname = new System.Windows.Forms.Label();
            this.comboBoxSC = new System.Windows.Forms.ComboBox();
            this.lblSchCd = new System.Windows.Forms.Label();
            this.tabPagestdf = new System.Windows.Forms.TabPage();
            this.tabPageStdPndg = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblheading = new System.Windows.Forms.Label();
            this.PnlPrdtGirl = new System.Windows.Forms.Panel();
            this.HomePanel.SuspendLayout();
            this.parenttabcontrol.SuspendLayout();
            this.tabPagestdtl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.SystemColors.Control;
            this.HomePanel.Controls.Add(this.parenttabcontrol);
            this.HomePanel.Location = new System.Drawing.Point(5, 25);
            this.HomePanel.Margin = new System.Windows.Forms.Padding(1);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(1300, 700);
            this.HomePanel.TabIndex = 0;
            // 
            // parenttabcontrol
            // 
            this.parenttabcontrol.Controls.Add(this.tabPagestdtl);
            this.parenttabcontrol.Controls.Add(this.tabPagestdf);
            this.parenttabcontrol.Controls.Add(this.tabPageStdPndg);
            this.parenttabcontrol.Location = new System.Drawing.Point(7, 7);
            this.parenttabcontrol.Name = "parenttabcontrol";
            this.parenttabcontrol.SelectedIndex = 0;
            this.parenttabcontrol.Size = new System.Drawing.Size(1290, 653);
            this.parenttabcontrol.TabIndex = 0;
            // 
            // tabPagestdtl
            // 
            this.tabPagestdtl.Controls.Add(this.PnlPrdtGirl);
            this.tabPagestdtl.Controls.Add(this.textBox1);
            this.tabPagestdtl.Controls.Add(this.LblEmail);
            this.tabPagestdtl.Controls.Add(this.TxtLndLine);
            this.tabPagestdtl.Controls.Add(this.lbllandline);
            this.tabPagestdtl.Controls.Add(this.TxtConcatNum);
            this.tabPagestdtl.Controls.Add(this.label2);
            this.tabPagestdtl.Controls.Add(this.TxtStdNm);
            this.tabPagestdtl.Controls.Add(this.label1);
            this.tabPagestdtl.Controls.Add(this.TxtCustNbr);
            this.tabPagestdtl.Controls.Add(this.lblCustomerno);
            this.tabPagestdtl.Controls.Add(this.LblSchoolname);
            this.tabPagestdtl.Controls.Add(this.comboBoxSC);
            this.tabPagestdtl.Controls.Add(this.lblSchCd);
            this.tabPagestdtl.Location = new System.Drawing.Point(4, 22);
            this.tabPagestdtl.Name = "tabPagestdtl";
            this.tabPagestdtl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagestdtl.Size = new System.Drawing.Size(1282, 627);
            this.tabPagestdtl.TabIndex = 0;
            this.tabPagestdtl.Text = "Student Details";
            this.tabPagestdtl.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 12;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(92, 176);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(52, 15);
            this.LblEmail.TabIndex = 11;
            this.LblEmail.Text = "Email :";
            // 
            // TxtLndLine
            // 
            this.TxtLndLine.Location = new System.Drawing.Point(395, 133);
            this.TxtLndLine.Name = "TxtLndLine";
            this.TxtLndLine.Size = new System.Drawing.Size(142, 20);
            this.TxtLndLine.TabIndex = 10;
            this.TxtLndLine.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lbllandline
            // 
            this.lbllandline.AutoSize = true;
            this.lbllandline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllandline.Location = new System.Drawing.Point(318, 138);
            this.lbllandline.Name = "lbllandline";
            this.lbllandline.Size = new System.Drawing.Size(71, 15);
            this.lbllandline.TabIndex = 9;
            this.lbllandline.Text = "LandLine:";
            // 
            // TxtConcatNum
            // 
            this.TxtConcatNum.Location = new System.Drawing.Point(159, 133);
            this.TxtConcatNum.Name = "TxtConcatNum";
            this.TxtConcatNum.Size = new System.Drawing.Size(139, 20);
            this.TxtConcatNum.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "MobileNumber :";
            // 
            // TxtStdNm
            // 
            this.TxtStdNm.Location = new System.Drawing.Point(159, 90);
            this.TxtStdNm.Name = "TxtStdNm";
            this.TxtStdNm.Size = new System.Drawing.Size(226, 20);
            this.TxtStdNm.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name Of Student :";
            // 
            // TxtCustNbr
            // 
            this.TxtCustNbr.Location = new System.Drawing.Point(159, 56);
            this.TxtCustNbr.Name = "TxtCustNbr";
            this.TxtCustNbr.Size = new System.Drawing.Size(121, 20);
            this.TxtCustNbr.TabIndex = 4;
            // 
            // lblCustomerno
            // 
            this.lblCustomerno.AutoSize = true;
            this.lblCustomerno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerno.Location = new System.Drawing.Point(13, 56);
            this.lblCustomerno.Name = "lblCustomerno";
            this.lblCustomerno.Size = new System.Drawing.Size(131, 15);
            this.lblCustomerno.TabIndex = 3;
            this.lblCustomerno.Text = "Customer Number :";
            // 
            // LblSchoolname
            // 
            this.LblSchoolname.AutoSize = true;
            this.LblSchoolname.Location = new System.Drawing.Point(379, 21);
            this.LblSchoolname.Name = "LblSchoolname";
            this.LblSchoolname.Size = new System.Drawing.Size(35, 13);
            this.LblSchoolname.TabIndex = 2;
            this.LblSchoolname.Text = "label1";
            // 
            // comboBoxSC
            // 
            this.comboBoxSC.FormattingEnabled = true;
            this.comboBoxSC.Location = new System.Drawing.Point(159, 18);
            this.comboBoxSC.Name = "comboBoxSC";
            this.comboBoxSC.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSC.TabIndex = 1;
            // 
            // lblSchCd
            // 
            this.lblSchCd.AutoSize = true;
            this.lblSchCd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchCd.Location = new System.Drawing.Point(48, 19);
            this.lblSchCd.Name = "lblSchCd";
            this.lblSchCd.Size = new System.Drawing.Size(96, 15);
            this.lblSchCd.TabIndex = 0;
            this.lblSchCd.Text = "School Code :";
            // 
            // tabPagestdf
            // 
            this.tabPagestdf.Location = new System.Drawing.Point(4, 22);
            this.tabPagestdf.Name = "tabPagestdf";
            this.tabPagestdf.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagestdf.Size = new System.Drawing.Size(1282, 627);
            this.tabPagestdf.TabIndex = 1;
            this.tabPagestdf.Text = "Find Student";
            this.tabPagestdf.UseVisualStyleBackColor = true;
            // 
            // tabPageStdPndg
            // 
            this.tabPageStdPndg.Location = new System.Drawing.Point(4, 22);
            this.tabPageStdPndg.Name = "tabPageStdPndg";
            this.tabPageStdPndg.Size = new System.Drawing.Size(1282, 627);
            this.tabPageStdPndg.TabIndex = 2;
            this.tabPageStdPndg.Text = "Pending";
            this.tabPageStdPndg.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1174, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockEntryToolStripMenuItem,
            this.stockViewToolStripMenuItem,
            this.adminViewToolStripMenuItem});
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // stockEntryToolStripMenuItem
            // 
            this.stockEntryToolStripMenuItem.Name = "stockEntryToolStripMenuItem";
            this.stockEntryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stockEntryToolStripMenuItem.Text = "Stock Entry";
            // 
            // stockViewToolStripMenuItem
            // 
            this.stockViewToolStripMenuItem.Name = "stockViewToolStripMenuItem";
            this.stockViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stockViewToolStripMenuItem.Text = "Stock View";
            // 
            // adminViewToolStripMenuItem
            // 
            this.adminViewToolStripMenuItem.Name = "adminViewToolStripMenuItem";
            this.adminViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adminViewToolStripMenuItem.Text = "Admin View";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // lblheading
            // 
            this.lblheading.AutoSize = true;
            this.lblheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading.Location = new System.Drawing.Point(531, 0);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(168, 24);
            this.lblheading.TabIndex = 0;
            this.lblheading.Text = "Sutra Application";
            // 
            // PnlPrdtGirl
            // 
            this.PnlPrdtGirl.Location = new System.Drawing.Point(22, 247);
            this.PnlPrdtGirl.Name = "PnlPrdtGirl";
            this.PnlPrdtGirl.Size = new System.Drawing.Size(829, 163);
            this.PnlPrdtGirl.TabIndex = 13;
            // 
            // Sutra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 750);
            this.Controls.Add(this.lblheading);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Sutra";
            this.Text = "Sutra App";
            this.HomePanel.ResumeLayout(false);
            this.parenttabcontrol.ResumeLayout(false);
            this.tabPagestdtl.ResumeLayout(false);
            this.tabPagestdtl.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.TabControl parenttabcontrol;
        private System.Windows.Forms.TabPage tabPagestdtl;
        private System.Windows.Forms.TabPage tabPagestdf;
        private System.Windows.Forms.ComboBox comboBoxSC;
        private System.Windows.Forms.Label lblSchCd;
        private System.Windows.Forms.TabPage tabPageStdPndg;
        private System.Windows.Forms.Label LblSchoolname;
        private System.Windows.Forms.TextBox TxtLndLine;
        private System.Windows.Forms.Label lbllandline;
        private System.Windows.Forms.TextBox TxtConcatNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtStdNm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCustNbr;
        private System.Windows.Forms.Label lblCustomerno;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Panel PnlPrdtGirl;
    }
}

