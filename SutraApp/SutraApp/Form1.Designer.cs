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
            this.studentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentPendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblheading = new System.Windows.Forms.Label();
            this.parenttabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.HomePanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.parenttabcontrol.SuspendLayout();
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
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentDetailsToolStripMenuItem,
            this.findStudentToolStripMenuItem,
            this.studentPendingToolStripMenuItem});
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
            // studentDetailsToolStripMenuItem
            // 
            this.studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            this.studentDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.studentDetailsToolStripMenuItem.Text = "Student Details";
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
            // findStudentToolStripMenuItem
            // 
            this.findStudentToolStripMenuItem.Name = "findStudentToolStripMenuItem";
            this.findStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findStudentToolStripMenuItem.Text = "Find Student";
            // 
            // studentPendingToolStripMenuItem
            // 
            this.studentPendingToolStripMenuItem.Name = "studentPendingToolStripMenuItem";
            this.studentPendingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.studentPendingToolStripMenuItem.Text = "Student Pending";
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
            this.parenttabcontrol.Controls.Add(this.tabPage1);
            this.parenttabcontrol.Controls.Add(this.tabPage2);
            this.parenttabcontrol.Location = new System.Drawing.Point(25, 15);
            this.parenttabcontrol.Name = "parenttabcontrol";
            this.parenttabcontrol.SelectedIndex = 0;
            this.parenttabcontrol.Size = new System.Drawing.Size(1233, 653);
            this.parenttabcontrol.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1225, 627);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentPendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.TabControl parenttabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

