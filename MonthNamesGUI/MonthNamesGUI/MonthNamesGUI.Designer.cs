namespace MonthNamesGUI
{
    partial class MonthNamesGUI
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
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblFound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(13, 13);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(147, 13);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Enter a month number (1-12): ";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(166, 10);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(35, 20);
            this.txtMonth.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(66, 41);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Find Month";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblFound
            // 
            this.lblFound.AutoSize = true;
            this.lblFound.Location = new System.Drawing.Point(63, 86);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(27, 13);
            this.lblFound.TabIndex = 3;
            this.lblFound.Text = "epic";
            this.lblFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFound.Visible = false;
            // 
            // MonthNamesGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 147);
            this.Controls.Add(this.lblFound);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.lblMonth);
            this.Name = "MonthNamesGUI";
            this.Text = "Month Names";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblFound;
    }
}

