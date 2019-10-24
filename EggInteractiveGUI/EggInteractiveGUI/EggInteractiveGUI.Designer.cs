namespace EggInteractiveGUI
{
    partial class EggInteractiveGUI
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtChickenOne = new System.Windows.Forms.TextBox();
            this.txtChickenTwo = new System.Windows.Forms.TextBox();
            this.txtChickenThree = new System.Windows.Forms.TextBox();
            this.txtChickenFour = new System.Windows.Forms.TextBox();
            this.txtChickenFive = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblEggs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(214, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Enter eggs produced by each of 5 chickens";
            // 
            // txtChickenOne
            // 
            this.txtChickenOne.Location = new System.Drawing.Point(16, 54);
            this.txtChickenOne.Name = "txtChickenOne";
            this.txtChickenOne.Size = new System.Drawing.Size(58, 20);
            this.txtChickenOne.TabIndex = 1;
            // 
            // txtChickenTwo
            // 
            this.txtChickenTwo.Location = new System.Drawing.Point(91, 54);
            this.txtChickenTwo.Name = "txtChickenTwo";
            this.txtChickenTwo.Size = new System.Drawing.Size(58, 20);
            this.txtChickenTwo.TabIndex = 2;
            // 
            // txtChickenThree
            // 
            this.txtChickenThree.Location = new System.Drawing.Point(169, 54);
            this.txtChickenThree.Name = "txtChickenThree";
            this.txtChickenThree.Size = new System.Drawing.Size(58, 20);
            this.txtChickenThree.TabIndex = 3;
            // 
            // txtChickenFour
            // 
            this.txtChickenFour.Location = new System.Drawing.Point(54, 80);
            this.txtChickenFour.Name = "txtChickenFour";
            this.txtChickenFour.Size = new System.Drawing.Size(58, 20);
            this.txtChickenFour.TabIndex = 4;
            // 
            // txtChickenFive
            // 
            this.txtChickenFive.Location = new System.Drawing.Point(131, 80);
            this.txtChickenFive.Name = "txtChickenFive";
            this.txtChickenFive.Size = new System.Drawing.Size(58, 20);
            this.txtChickenFive.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(86, 121);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblEggs
            // 
            this.lblEggs.AutoSize = true;
            this.lblEggs.Location = new System.Drawing.Point(13, 161);
            this.lblEggs.Name = "lblEggs";
            this.lblEggs.Size = new System.Drawing.Size(25, 13);
            this.lblEggs.TabIndex = 7;
            this.lblEggs.Text = "egg";
            this.lblEggs.Visible = false;
            // 
            // EggInteractiveGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEggs);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtChickenFive);
            this.Controls.Add(this.txtChickenFour);
            this.Controls.Add(this.txtChickenThree);
            this.Controls.Add(this.txtChickenTwo);
            this.Controls.Add(this.txtChickenOne);
            this.Controls.Add(this.lblTitle);
            this.Name = "EggInteractiveGUI";
            this.Text = "Egg Interactive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtChickenOne;
        private System.Windows.Forms.TextBox txtChickenTwo;
        private System.Windows.Forms.TextBox txtChickenThree;
        private System.Windows.Forms.TextBox txtChickenFour;
        private System.Windows.Forms.TextBox txtChickenFive;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblEggs;
    }
}

