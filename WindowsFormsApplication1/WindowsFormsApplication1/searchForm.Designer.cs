namespace WindowsFormsApplication1
{
    partial class searchForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDataSearch = new System.Windows.Forms.TextBox();
            this.cboSearchCategory = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.contactMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(871, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 492);
            this.panel1.TabIndex = 1;
            // 
            // txtDataSearch
            // 
            this.txtDataSearch.Location = new System.Drawing.Point(117, 21);
            this.txtDataSearch.Name = "txtDataSearch";
            this.txtDataSearch.Size = new System.Drawing.Size(189, 20);
            this.txtDataSearch.TabIndex = 2;
            // 
            // cboSearchCategory
            // 
            this.cboSearchCategory.FormattingEnabled = true;
            this.cboSearchCategory.Items.AddRange(new object[] {
            "Last Name",
            "First Name",
            "Private Mobile",
            "Street"});
            this.cboSearchCategory.Location = new System.Drawing.Point(376, 21);
            this.cboSearchCategory.Name = "cboSearchCategory";
            this.cboSearchCategory.Size = new System.Drawing.Size(121, 21);
            this.cboSearchCategory.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1391, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactMenuStrip});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1391, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // contactMenuStrip
            // 
            this.contactMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllContactToolStripMenuItem,
            this.seToolStripMenuItem});
            this.contactMenuStrip.Name = "contactMenuStrip";
            this.contactMenuStrip.Size = new System.Drawing.Size(59, 20);
            this.contactMenuStrip.Text = "contact";
            // 
            // viewAllContactToolStripMenuItem
            // 
            this.viewAllContactToolStripMenuItem.Name = "viewAllContactToolStripMenuItem";
            this.viewAllContactToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.viewAllContactToolStripMenuItem.Text = "View All Contact";
            this.viewAllContactToolStripMenuItem.Click += new System.EventHandler(this.ViewAllContact_Click);
            // 
            // seToolStripMenuItem
            // 
            this.seToolStripMenuItem.Name = "seToolStripMenuItem";
            this.seToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.seToolStripMenuItem.Text = "Add New Contact";
            this.seToolStripMenuItem.Click += new System.EventHandler(this.AddContact_Click);
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 686);
            this.Controls.Add(this.cboSearchCategory);
            this.Controls.Add(this.txtDataSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "searchForm";
            this.Text = "Form1";
          
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDataSearch;
        private System.Windows.Forms.ComboBox cboSearchCategory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem contactMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewAllContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seToolStripMenuItem;
    }
}

