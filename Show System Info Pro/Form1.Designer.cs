namespace Show_System_Info_Pro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtMac = new System.Windows.Forms.TextBox();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.cmbDB = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbIP = new System.Windows.Forms.CheckBox();
            this.cbMac = new System.Windows.Forms.CheckBox();
            this.cbProcess = new System.Windows.Forms.CheckBox();
            this.txtPrinter = new System.Windows.Forms.TextBox();
            this.cbPrinter = new System.Windows.Forms.CheckBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelCL2 = new System.Windows.Forms.Panel();
            this.panelCL1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIP.Location = new System.Drawing.Point(152, 75);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(208, 22);
            this.txtIP.TabIndex = 1;
            // 
            // txtMac
            // 
            this.txtMac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMac.Location = new System.Drawing.Point(152, 119);
            this.txtMac.Name = "txtMac";
            this.txtMac.Size = new System.Drawing.Size(208, 22);
            this.txtMac.TabIndex = 2;
            // 
            // txtProcess
            // 
            this.txtProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProcess.Location = new System.Drawing.Point(152, 163);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(208, 22);
            this.txtProcess.TabIndex = 3;
            // 
            // cmbDB
            // 
            this.cmbDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDB.FormattingEnabled = true;
            this.cmbDB.Items.AddRange(new object[] {
            "BWelkinATP",
            "WelkinATP"});
            this.cmbDB.Location = new System.Drawing.Point(152, 29);
            this.cmbDB.Name = "cmbDB";
            this.cmbDB.Size = new System.Drawing.Size(208, 24);
            this.cmbDB.TabIndex = 2;
            this.cmbDB.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(33, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "Database :";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbIP
            // 
            this.cbIP.AutoSize = true;
            this.cbIP.Location = new System.Drawing.Point(33, 76);
            this.cbIP.Name = "cbIP";
            this.cbIP.Size = new System.Drawing.Size(98, 20);
            this.cbIP.TabIndex = 3;
            this.cbIP.TabStop = false;
            this.cbIP.Text = "IP Address :";
            this.cbIP.UseVisualStyleBackColor = true;
            // 
            // cbMac
            // 
            this.cbMac.AutoSize = true;
            this.cbMac.Location = new System.Drawing.Point(33, 121);
            this.cbMac.Name = "cbMac";
            this.cbMac.Size = new System.Drawing.Size(115, 20);
            this.cbMac.TabIndex = 3;
            this.cbMac.TabStop = false;
            this.cbMac.Text = "MAC Address :";
            this.cbMac.UseVisualStyleBackColor = true;
            // 
            // cbProcess
            // 
            this.cbProcess.AutoSize = true;
            this.cbProcess.Location = new System.Drawing.Point(33, 166);
            this.cbProcess.Name = "cbProcess";
            this.cbProcess.Size = new System.Drawing.Size(110, 20);
            this.cbProcess.TabIndex = 3;
            this.cbProcess.TabStop = false;
            this.cbProcess.Text = "Processor ID :";
            this.cbProcess.UseVisualStyleBackColor = true;
            // 
            // txtPrinter
            // 
            this.txtPrinter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrinter.Location = new System.Drawing.Point(152, 207);
            this.txtPrinter.Name = "txtPrinter";
            this.txtPrinter.Size = new System.Drawing.Size(208, 22);
            this.txtPrinter.TabIndex = 4;
            // 
            // cbPrinter
            // 
            this.cbPrinter.AutoSize = true;
            this.cbPrinter.Location = new System.Drawing.Point(33, 211);
            this.cbPrinter.Name = "cbPrinter";
            this.cbPrinter.Size = new System.Drawing.Size(97, 20);
            this.cbPrinter.TabIndex = 3;
            this.cbPrinter.TabStop = false;
            this.cbPrinter.Text = "Printer Port :";
            this.cbPrinter.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnShow.Location = new System.Drawing.Point(101, 265);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(93, 33);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.Location = new System.Drawing.Point(200, 265);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 33);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panelCL2
            // 
            this.panelCL2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCL2.Location = new System.Drawing.Point(300, 265);
            this.panelCL2.Name = "panelCL2";
            this.panelCL2.Size = new System.Drawing.Size(60, 33);
            this.panelCL2.TabIndex = 5;
            this.panelCL2.Click += new System.EventHandler(this.panelCL1_Click);
            // 
            // panelCL1
            // 
            this.panelCL1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCL1.Location = new System.Drawing.Point(35, 265);
            this.panelCL1.Name = "panelCL1";
            this.panelCL1.Size = new System.Drawing.Size(60, 33);
            this.panelCL1.TabIndex = 5;
            this.panelCL1.Click += new System.EventHandler(this.panelCL1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar1.MarqueeAnimationSpeed = 25;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(392, 5);
            this.progressBar1.Step = 25;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(393, 316);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panelCL1);
            this.Controls.Add(this.panelCL2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cbPrinter);
            this.Controls.Add(this.cbProcess);
            this.Controls.Add(this.cbIP);
            this.Controls.Add(this.cbMac);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmbDB);
            this.Controls.Add(this.txtPrinter);
            this.Controls.Add(this.txtProcess);
            this.Controls.Add(this.txtMac);
            this.Controls.Add(this.txtIP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(30, 30, 30, 15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show System Info Pro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtMac;
        private System.Windows.Forms.TextBox txtProcess;
        private System.Windows.Forms.ComboBox cmbDB;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox cbIP;
        private System.Windows.Forms.CheckBox cbMac;
        private System.Windows.Forms.CheckBox cbProcess;
        private System.Windows.Forms.TextBox txtPrinter;
        private System.Windows.Forms.CheckBox cbPrinter;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panelCL2;
        private System.Windows.Forms.Panel panelCL1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

