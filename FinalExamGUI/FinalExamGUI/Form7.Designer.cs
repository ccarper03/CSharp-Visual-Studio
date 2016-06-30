namespace FinalExamGUI
{
    partial class Form7
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.QtntBtn = new System.Windows.Forms.Button();
            this.qtntDisplayLabel = new System.Windows.Forms.Label();
            this.inputTextBox1 = new System.Windows.Forms.TextBox();
            this.fNumLabel = new System.Windows.Forms.Label();
            this.inputTextBox2 = new System.Windows.Forms.TextBox();
            this.sNumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(229, 247);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(161, 28);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "&Close Form";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // QtntBtn
            // 
            this.QtntBtn.Location = new System.Drawing.Point(49, 247);
            this.QtntBtn.Margin = new System.Windows.Forms.Padding(4);
            this.QtntBtn.Name = "QtntBtn";
            this.QtntBtn.Size = new System.Drawing.Size(140, 28);
            this.QtntBtn.TabIndex = 8;
            this.QtntBtn.Text = "&Quotient";
            this.QtntBtn.UseVisualStyleBackColor = true;
            this.QtntBtn.Click += new System.EventHandler(this.QtntBtn_Click);
            // 
            // qtntDisplayLabel
            // 
            this.qtntDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.qtntDisplayLabel.Location = new System.Drawing.Point(49, 154);
            this.qtntDisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qtntDisplayLabel.Name = "qtntDisplayLabel";
            this.qtntDisplayLabel.Size = new System.Drawing.Size(341, 47);
            this.qtntDisplayLabel.TabIndex = 7;
            this.qtntDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputTextBox1
            // 
            this.inputTextBox1.Location = new System.Drawing.Point(251, 50);
            this.inputTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.inputTextBox1.Name = "inputTextBox1";
            this.inputTextBox1.Size = new System.Drawing.Size(132, 22);
            this.inputTextBox1.TabIndex = 6;
            this.inputTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputTextBox1.TextChanged += new System.EventHandler(this.inputTextBox1_TextChanged);
            // 
            // fNumLabel
            // 
            this.fNumLabel.AutoSize = true;
            this.fNumLabel.Location = new System.Drawing.Point(39, 54);
            this.fNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fNumLabel.Name = "fNumLabel";
            this.fNumLabel.Size = new System.Drawing.Size(127, 17);
            this.fNumLabel.TabIndex = 5;
            this.fNumLabel.Text = "Enter First Number";
            // 
            // inputTextBox2
            // 
            this.inputTextBox2.Location = new System.Drawing.Point(251, 90);
            this.inputTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.inputTextBox2.Name = "inputTextBox2";
            this.inputTextBox2.Size = new System.Drawing.Size(132, 22);
            this.inputTextBox2.TabIndex = 11;
            this.inputTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sNumLabel
            // 
            this.sNumLabel.AutoSize = true;
            this.sNumLabel.Location = new System.Drawing.Point(39, 94);
            this.sNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sNumLabel.Name = "sNumLabel";
            this.sNumLabel.Size = new System.Drawing.Size(148, 17);
            this.sNumLabel.TabIndex = 10;
            this.sNumLabel.Text = "Enter Second Number";
            // 
            // Form7
            // 
            this.AcceptButton = this.QtntBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(465, 338);
            this.Controls.Add(this.inputTextBox2);
            this.Controls.Add(this.sNumLabel);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.QtntBtn);
            this.Controls.Add(this.qtntDisplayLabel);
            this.Controls.Add(this.inputTextBox1);
            this.Controls.Add(this.fNumLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quotient of Two Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button QtntBtn;
        private System.Windows.Forms.Label qtntDisplayLabel;
        private System.Windows.Forms.TextBox inputTextBox1;
        private System.Windows.Forms.Label fNumLabel;
        private System.Windows.Forms.TextBox inputTextBox2;
        private System.Windows.Forms.Label sNumLabel;
    }
}