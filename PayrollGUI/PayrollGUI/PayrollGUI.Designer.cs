namespace PayrollGUI
{
    partial class PayrollGUI
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.lblWorkHours = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtPayrate = new System.Windows.Forms.TextBox();
            this.txtWorkHours = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter your name: ";
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(30, 39);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(83, 13);
            this.lblSSN.TabIndex = 1;
            this.lblSSN.Text = "Enter your SSN:";
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Location = new System.Drawing.Point(11, 65);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(104, 13);
            this.lblPayRate.TabIndex = 2;
            this.lblPayRate.Text = "Enter hourly payrate:";
            // 
            // lblWorkHours
            // 
            this.lblWorkHours.AutoSize = true;
            this.lblWorkHours.Location = new System.Drawing.Point(13, 92);
            this.lblWorkHours.Name = "lblWorkHours";
            this.lblWorkHours.Size = new System.Drawing.Size(102, 13);
            this.lblWorkHours.TabIndex = 3;
            this.lblWorkHours.Text = "Enter hours worked:";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(124, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(81, 20);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "John Doe";
            // 
            // txtSSN
            // 
            this.txtSSN.Enabled = false;
            this.txtSSN.Location = new System.Drawing.Point(124, 36);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(81, 20);
            this.txtSSN.TabIndex = 5;
            this.txtSSN.Text = "000 - 00 - 0000";
            // 
            // txtPayrate
            // 
            this.txtPayrate.Location = new System.Drawing.Point(124, 62);
            this.txtPayrate.Name = "txtPayrate";
            this.txtPayrate.Size = new System.Drawing.Size(100, 20);
            this.txtPayrate.TabIndex = 6;
            // 
            // txtWorkHours
            // 
            this.txtWorkHours.Location = new System.Drawing.Point(124, 89);
            this.txtWorkHours.Name = "txtWorkHours";
            this.txtWorkHours.Size = new System.Drawing.Size(100, 20);
            this.txtWorkHours.TabIndex = 7;
            // 
            // PayrollGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtWorkHours);
            this.Controls.Add(this.txtPayrate);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblWorkHours);
            this.Controls.Add(this.lblPayRate);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.lblName);
            this.Name = "PayrollGUI";
            this.Text = "Payroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.Label lblWorkHours;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.TextBox txtPayrate;
        private System.Windows.Forms.TextBox txtWorkHours;
    }
}

