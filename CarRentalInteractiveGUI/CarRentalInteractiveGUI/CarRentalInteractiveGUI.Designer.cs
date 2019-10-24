namespace CarRentalInteractiveGUI
{
    partial class CarRentalInteractiveGUI
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
            this.lblDays = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.lblMiles = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(13, 13);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(34, 13);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "Days:";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(53, 10);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(42, 20);
            this.txtDays.TabIndex = 1;
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(12, 41);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(34, 13);
            this.lblMiles.TabIndex = 2;
            this.lblMiles.Text = "Miles:";
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(53, 38);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(42, 20);
            this.txtMiles.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(196, 10);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 36);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Rental Fee";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.AutoSize = true;
            this.lblTotalFee.Location = new System.Drawing.Point(13, 83);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(35, 13);
            this.lblTotalFee.TabIndex = 5;
            this.lblTotalFee.Text = "label1";
            this.lblTotalFee.Visible = false;
            // 
            // CarRentalInteractiveGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 146);
            this.Controls.Add(this.lblTotalFee);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblDays);
            this.Name = "CarRentalInteractiveGUI";
            this.Text = "Car Rentals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotalFee;
    }
}

