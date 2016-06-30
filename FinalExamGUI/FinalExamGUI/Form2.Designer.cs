namespace FinalExamGUI
{
    partial class Form2
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
            this.squareTextBox = new System.Windows.Forms.TextBox();
            this.sqDisplayLabel = new System.Windows.Forms.Label();
            this.sqBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number to Square";
            // 
            // squareTextBox
            // 
            this.squareTextBox.Location = new System.Drawing.Point(264, 75);
            this.squareTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.squareTextBox.Name = "squareTextBox";
            this.squareTextBox.Size = new System.Drawing.Size(132, 22);
            this.squareTextBox.TabIndex = 1;
            this.squareTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.squareTextBox.TextChanged += new System.EventHandler(this.squareTextBox_TextChanged);
            // 
            // sqDisplayLabel
            // 
            this.sqDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sqDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqDisplayLabel.Location = new System.Drawing.Point(63, 147);
            this.sqDisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sqDisplayLabel.Name = "sqDisplayLabel";
            this.sqDisplayLabel.Size = new System.Drawing.Size(341, 47);
            this.sqDisplayLabel.TabIndex = 2;
            this.sqDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sqDisplayLabel.TextChanged += new System.EventHandler(this.squareTextBox_TextChanged);
            // 
            // sqBtn
            // 
            this.sqBtn.Location = new System.Drawing.Point(63, 241);
            this.sqBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sqBtn.Name = "sqBtn";
            this.sqBtn.Size = new System.Drawing.Size(140, 28);
            this.sqBtn.TabIndex = 3;
            this.sqBtn.Text = "&Square";
            this.sqBtn.UseVisualStyleBackColor = true;
            this.sqBtn.Click += new System.EventHandler(this.sqBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(243, 241);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(161, 28);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "&Close Form";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.sqBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(468, 308);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.sqBtn);
            this.Controls.Add(this.sqDisplayLabel);
            this.Controls.Add(this.squareTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Square a Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox squareTextBox;
        private System.Windows.Forms.Label sqDisplayLabel;
        private System.Windows.Forms.Button sqBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}