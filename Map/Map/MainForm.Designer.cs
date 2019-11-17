namespace Map
{
    partial class MainForm
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miLools = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.miLools,
            this.helpToolStripMenuItem,
            this.toolStripTextBox1,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1060, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBankToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 23);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // addBankToolStripMenuItem
            // 
            this.addBankToolStripMenuItem.Name = "addBankToolStripMenuItem";
            this.addBankToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.addBankToolStripMenuItem.Text = "AddBank";
            this.addBankToolStripMenuItem.Click += new System.EventHandler(this.addBankToolStripMenuItem_Click);
            // 
            // miLools
            // 
            this.miLools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem});
            this.miLools.Name = "miLools";
            this.miLools.Size = new System.Drawing.Size(48, 23);
            this.miLools.Text = "&Tools";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rubToolStripMenuItem,
            this.eurToolStripMenuItem,
            this.usdToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // rubToolStripMenuItem
            // 
            this.rubToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byToolStripMenuItem,
            this.sellToolStripMenuItem});
            this.rubToolStripMenuItem.Name = "rubToolStripMenuItem";
            this.rubToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.rubToolStripMenuItem.Text = "rur";
            // 
            // byToolStripMenuItem
            // 
            this.byToolStripMenuItem.Name = "byToolStripMenuItem";
            this.byToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.byToolStripMenuItem.Text = "MinBy";
            this.byToolStripMenuItem.Click += new System.EventHandler(this.btnBy_Click);
            // 
            // sellToolStripMenuItem
            // 
            this.sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            this.sellToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.sellToolStripMenuItem.Text = "MaxSell";
            this.sellToolStripMenuItem.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // eurToolStripMenuItem
            // 
            this.eurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byToolStripMenuItem1,
            this.sellToolStripMenuItem1});
            this.eurToolStripMenuItem.Name = "eurToolStripMenuItem";
            this.eurToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.eurToolStripMenuItem.Text = "usd";
            // 
            // byToolStripMenuItem1
            // 
            this.byToolStripMenuItem1.Name = "byToolStripMenuItem1";
            this.byToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.byToolStripMenuItem1.Text = "MinBy";
            this.byToolStripMenuItem1.Click += new System.EventHandler(this.btnBy_Click);
            // 
            // sellToolStripMenuItem1
            // 
            this.sellToolStripMenuItem1.Name = "sellToolStripMenuItem1";
            this.sellToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.sellToolStripMenuItem1.Text = "MaxSell";
            this.sellToolStripMenuItem1.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // usdToolStripMenuItem
            // 
            this.usdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byToolStripMenuItem2,
            this.sellToolStripMenuItem2});
            this.usdToolStripMenuItem.Name = "usdToolStripMenuItem";
            this.usdToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.usdToolStripMenuItem.Text = "eur";
            // 
            // byToolStripMenuItem2
            // 
            this.byToolStripMenuItem2.Name = "byToolStripMenuItem2";
            this.byToolStripMenuItem2.Size = new System.Drawing.Size(114, 22);
            this.byToolStripMenuItem2.Text = "MinBy";
            this.byToolStripMenuItem2.Click += new System.EventHandler(this.btnBy_Click);
            // 
            // sellToolStripMenuItem2
            // 
            this.sellToolStripMenuItem2.Name = "sellToolStripMenuItem2";
            this.sellToolStripMenuItem2.Size = new System.Drawing.Size(114, 22);
            this.sellToolStripMenuItem2.Text = "MaxSell";
            this.sellToolStripMenuItem2.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 23);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Size = new System.Drawing.Size(1060, 532);
            this.splitContainer1.SplitterDistance = 194;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(194, 532);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(331, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(55, 24);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 559);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miLools;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBankToolStripMenuItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem rubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

