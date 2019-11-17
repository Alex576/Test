namespace Map.AddForm
{
    partial class EditBank
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbBankName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbLantitude = new System.Windows.Forms.TextBox();
            this.tbLongtitude = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddKurses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "BankName";
            // 
            // tbBankName
            // 
            this.tbBankName.Location = new System.Drawing.Point(66, 7);
            this.tbBankName.Name = "tbBankName";
            this.tbBankName.Size = new System.Drawing.Size(249, 20);
            this.tbBankName.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Longitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Latitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(66, 33);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(249, 20);
            this.tbAddress.TabIndex = 18;
            // 
            // tbLantitude
            // 
            this.tbLantitude.Location = new System.Drawing.Point(66, 59);
            this.tbLantitude.Name = "tbLantitude";
            this.tbLantitude.Size = new System.Drawing.Size(249, 20);
            this.tbLantitude.TabIndex = 17;
            // 
            // tbLongtitude
            // 
            this.tbLongtitude.Location = new System.Drawing.Point(66, 85);
            this.tbLongtitude.Name = "tbLongtitude";
            this.tbLongtitude.Size = new System.Drawing.Size(249, 20);
            this.tbLongtitude.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddKurses
            // 
            this.btnAddKurses.Location = new System.Drawing.Point(208, 111);
            this.btnAddKurses.Name = "btnAddKurses";
            this.btnAddKurses.Size = new System.Drawing.Size(104, 37);
            this.btnAddKurses.TabIndex = 25;
            this.btnAddKurses.Text = "AddKurses";
            this.btnAddKurses.UseVisualStyleBackColor = true;
            this.btnAddKurses.Click += new System.EventHandler(this.btnAddKurses_Click);
            // 
            // EditBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 152);
            this.Controls.Add(this.btnAddKurses);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbBankName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbLantitude);
            this.Controls.Add(this.tbLongtitude);
            this.Controls.Add(this.button1);
            this.Name = "EditBank";
            this.Text = "EditBank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBankName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbLantitude;
        private System.Windows.Forms.TextBox tbLongtitude;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddKurses;
    }
}