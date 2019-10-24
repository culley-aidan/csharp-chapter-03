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
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblFeds = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
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
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPay.Location = new System.Drawing.Point(9, 161);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(112, 13);
            this.lblGrossPay.TabIndex = 8;
            this.lblGrossPay.Text = "Your gross pay is: ";
            this.lblGrossPay.Visible = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(84, 124);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblFeds
            // 
            this.lblFeds.AutoSize = true;
            this.lblFeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeds.Location = new System.Drawing.Point(9, 185);
            this.lblFeds.Name = "lblFeds";
            this.lblFeds.Size = new System.Drawing.Size(114, 13);
            this.lblFeds.TabIndex = 10;
            this.lblFeds.Text = "You owe the feds: ";
            this.lblFeds.Visible = false;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(9, 209);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(118, 13);
            this.lblState.TabIndex = 11;
            this.lblState.Text = "You owe the state: ";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNet.Location = new System.Drawing.Point(9, 231);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(100, 13);
            this.lblNet.TabIndex = 12;
            this.lblNet.Text = "Your net pay is: ";
            // 
            // PayrollGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblFeds);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblGrossPay);
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
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblFeds;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblNet;
    }
}

