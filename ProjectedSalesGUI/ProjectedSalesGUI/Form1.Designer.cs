namespace ProjectedSalesGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.northLabel = new System.Windows.Forms.Label();
            this.southLabel = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.northTextBox = new System.Windows.Forms.TextBox();
            this.southTextBox = new System.Windows.Forms.TextBox();
            this.findButton_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Current North Division Sales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(47, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Current South Division Sales";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(47, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Projected South Division Sales";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(47, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Projected North Division Sales";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // northLabel
            // 
            this.northLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.northLabel.Location = new System.Drawing.Point(276, 140);
            this.northLabel.Name = "northLabel";
            this.northLabel.Size = new System.Drawing.Size(100, 23);
            this.northLabel.TabIndex = 7;
            this.northLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.northLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // southLabel
            // 
            this.southLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.southLabel.Location = new System.Drawing.Point(276, 176);
            this.southLabel.Name = "southLabel";
            this.southLabel.Size = new System.Drawing.Size(100, 23);
            this.southLabel.TabIndex = 9;
            this.southLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.Location = new System.Drawing.Point(223, 236);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(153, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "E&xit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // northTextBox
            // 
            this.northTextBox.Location = new System.Drawing.Point(276, 43);
            this.northTextBox.Name = "northTextBox";
            this.northTextBox.Size = new System.Drawing.Size(100, 20);
            this.northTextBox.TabIndex = 0;
            this.northTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.northTextBox.TextChanged += new System.EventHandler(this.northTextBox_TextChanged);
            // 
            // southTextBox
            // 
            this.southTextBox.Location = new System.Drawing.Point(276, 84);
            this.southTextBox.Name = "southTextBox";
            this.southTextBox.Size = new System.Drawing.Size(100, 20);
            this.southTextBox.TabIndex = 1;
            this.southTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.southTextBox.TextChanged += new System.EventHandler(this.southTextBox_TextChanged);
            // 
            // findButton_Click
            // 
            this.findButton_Click.Location = new System.Drawing.Point(50, 236);
            this.findButton_Click.Name = "findButton_Click";
            this.findButton_Click.Size = new System.Drawing.Size(163, 23);
            this.findButton_Click.TabIndex = 2;
            this.findButton_Click.Text = "&Find Projected Sales";
            this.findButton_Click.UseVisualStyleBackColor = true;
            this.findButton_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.findButton_Click;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(458, 349);
            this.Controls.Add(this.findButton_Click);
            this.Controls.Add(this.southTextBox);
            this.Controls.Add(this.northTextBox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.southLabel);
            this.Controls.Add(this.northLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Current and Projected Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label northLabel;
        private System.Windows.Forms.Label southLabel;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox northTextBox;
        private System.Windows.Forms.TextBox southTextBox;
        private System.Windows.Forms.Button findButton_Click;
    }
}

