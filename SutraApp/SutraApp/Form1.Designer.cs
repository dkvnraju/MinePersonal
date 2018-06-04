namespace SutraApp
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblheading = new System.Windows.Forms.Label();
            this.parenttabcontrol = new System.Windows.Forms.TabControl();
            this.tabPagestdtl = new System.Windows.Forms.TabPage();
            this.tabPagestdf = new System.Windows.Forms.TabPage();
            this.tabPageStdPndg = new System.Windows.Forms.TabPage();
            this.lblSchCd = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.HomePanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.parenttabcontrol.SuspendLayout();
            this.tabPagestdtl.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.SystemColors.Control;
            this.HomePanel.Controls.Add(this.parenttabcontrol);
            this.HomePanel.Location = new System.Drawing.Point(0, 25);
            this.HomePanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(1300, 700);
            this.HomePanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1334, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockEntryToolStripMenuItem,
            this.stockViewToolStripMenuItem,
            this.adminViewToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
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
            // parenttabcontrol
            // 
            this.parenttabcontrol.Controls.Add(this.tabPagestdtl);
            this.parenttabcontrol.Controls.Add(this.tabPagestdf);
            this.parenttabcontrol.Controls.Add(this.tabPageStdPndg);
            this.parenttabcontrol.Location = new System.Drawing.Point(25, 15);
            this.parenttabcontrol.Name = "parenttabcontrol";
            this.parenttabcontrol.SelectedIndex = 0;
            this.parenttabcontrol.Size = new System.Drawing.Size(1233, 653);
            this.parenttabcontrol.TabIndex = 0;
            // 
            // tabPagestdtl
            // 
            this.tabPagestdtl.Controls.Add(this.comboBox1);
            this.tabPagestdtl.Controls.Add(this.lblSchCd);
            this.tabPagestdtl.Location = new System.Drawing.Point(4, 22);
            this.tabPagestdtl.Name = "tabPagestdtl";
            this.tabPagestdtl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagestdtl.Size = new System.Drawing.Size(1225, 627);
            this.tabPagestdtl.TabIndex = 0;
            this.tabPagestdtl.Text = "Student Details";
            this.tabPagestdtl.UseVisualStyleBackColor = true;
            // 
            // tabPagestdf
            // 
            this.tabPagestdf.Location = new System.Drawing.Point(4, 22);
            this.tabPagestdf.Name = "tabPagestdf";
            this.tabPagestdf.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagestdf.Size = new System.Drawing.Size(1225, 627);
            this.tabPagestdf.TabIndex = 1;
            this.tabPagestdf.Text = "Find Student";
            this.tabPagestdf.UseVisualStyleBackColor = true;
            // 
            // tabPageStdPndg
            // 
            this.tabPageStdPndg.Location = new System.Drawing.Point(4, 22);
            this.tabPageStdPndg.Name = "tabPageStdPndg";
            this.tabPageStdPndg.Size = new System.Drawing.Size(1225, 627);
            this.tabPageStdPndg.TabIndex = 2;
            this.tabPageStdPndg.Text = "Pending";
            this.tabPageStdPndg.UseVisualStyleBackColor = true;
            // 
            // lblSchCd
            // 
            this.lblSchCd.AutoSize = true;
            this.lblSchCd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchCd.Location = new System.Drawing.Point(21, 19);
            this.lblSchCd.Name = "lblSchCd";
            this.lblSchCd.Size = new System.Drawing.Size(96, 15);
            this.lblSchCd.TabIndex = 0;
            this.lblSchCd.Text = "School Code :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 750);
            this.Controls.Add(this.lblheading);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.HomePanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.parenttabcontrol.ResumeLayout(false);
            this.tabPagestdtl.ResumeLayout(false);
            this.tabPagestdtl.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSchCd;
        private System.Windows.Forms.TabPage tabPageStdPndg;
    }
}

