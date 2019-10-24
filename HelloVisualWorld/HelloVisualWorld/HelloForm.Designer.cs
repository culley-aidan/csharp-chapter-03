namespace HelloVisualWorld
{
    partial class HelloForm
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
            this.helloLabel = new System.Windows.Forms.Label();
            this.displayOutputButton = new System.Windows.Forms.Button();
            this.changeOutputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Location = new System.Drawing.Point(90, 75);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(99, 13);
            this.helloLabel.TabIndex = 0;
            this.helloLabel.Text = "Hello, Visual World!";
            this.helloLabel.Visible = false;
            // 
            // displayOutputButton
            // 
            this.displayOutputButton.Location = new System.Drawing.Point(100, 150);
            this.displayOutputButton.Name = "displayOutputButton";
            this.displayOutputButton.Size = new System.Drawing.Size(75, 23);
            this.displayOutputButton.TabIndex = 1;
            this.displayOutputButton.Text = "Click here";
            this.displayOutputButton.UseVisualStyleBackColor = true;
            this.displayOutputButton.Click += new System.EventHandler(this.displayOutputButton_Click);
            // 
            // changeOutputButton
            // 
            this.changeOutputButton.Enabled = false;
            this.changeOutputButton.Location = new System.Drawing.Point(100, 180);
            this.changeOutputButton.Name = "changeOutputButton";
            this.changeOutputButton.Size = new System.Drawing.Size(75, 23);
            this.changeOutputButton.TabIndex = 2;
            this.changeOutputButton.Text = "Click me last";
            this.changeOutputButton.UseVisualStyleBackColor = true;
            this.changeOutputButton.Click += new System.EventHandler(this.changeOutputButton_Click);
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.changeOutputButton);
            this.Controls.Add(this.displayOutputButton);
            this.Controls.Add(this.helloLabel);
            this.Name = "HelloForm";
            this.Text = "Hello Visual World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Button displayOutputButton;
        private System.Windows.Forms.Button changeOutputButton;
    }
}

