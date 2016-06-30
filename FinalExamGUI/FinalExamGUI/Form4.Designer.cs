namespace FinalExamGUI
{
    partial class Form4
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
            this.sumBtn = new System.Windows.Forms.Button();
            this.sumDisplayLabel = new System.Windows.Forms.Label();
            this.sumTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sumTextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(241, 257);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(161, 28);
            this.closeBtn.TabIndex = 16;
            this.closeBtn.Text = "&Close Form";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // sumBtn
            // 
            this.sumBtn.Location = new System.Drawing.Point(61, 257);
            this.sumBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sumBtn.Name = "sumBtn";
            this.sumBtn.Size = new System.Drawing.Size(140, 28);
            this.sumBtn.TabIndex = 15;
            this.sumBtn.Text = "&Sum";
            this.sumBtn.UseVisualStyleBackColor = true;
            this.sumBtn.Click += new System.EventHandler(this.sqBtn_Click);
            // 
            // sumDisplayLabel
            // 
            this.sumDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sumDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumDisplayLabel.Location = new System.Drawing.Point(61, 167);
            this.sumDisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sumDisplayLabel.Name = "sumDisplayLabel";
            this.sumDisplayLabel.Size = new System.Drawing.Size(341, 47);
            this.sumDisplayLabel.TabIndex = 14;
            this.sumDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sumTextBox1
            // 
            this.sumTextBox1.Location = new System.Drawing.Point(263, 60);
            this.sumTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.sumTextBox1.Name = "sumTextBox1";
            this.sumTextBox1.Size = new System.Drawing.Size(132, 22);
            this.sumTextBox1.TabIndex = 13;
            this.sumTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sumTextBox1.TextChanged += new System.EventHandler(this.sumTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter Second Number";
            // 
            // sumTextBox2
            // 
            this.sumTextBox2.Location = new System.Drawing.Point(263, 100);
            this.sumTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.sumTextBox2.Name = "sumTextBox2";
            this.sumTextBox2.Size = new System.Drawing.Size(132, 22);
            this.sumTextBox2.TabIndex = 18;
            this.sumTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form4
            // 
            this.AcceptButton = this.sumBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(463, 363);
            this.Controls.Add(this.sumTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.sumBtn);
            this.Controls.Add(this.sumDisplayLabel);
            this.Controls.Add(this.sumTextBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sum of Two Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button sumBtn;
        private System.Windows.Forms.Label sumDisplayLabel;
        private System.Windows.Forms.TextBox sumTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sumTextBox2;

    }
}