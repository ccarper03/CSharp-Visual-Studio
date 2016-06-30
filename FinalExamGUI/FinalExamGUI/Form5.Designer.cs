namespace FinalExamGUI
{
    partial class Form5
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
            this.inputTextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.diffBtn = new System.Windows.Forms.Button();
            this.diffDisplayLabel = new System.Windows.Forms.Label();
            this.inputTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox2
            // 
            this.inputTextBox2.Location = new System.Drawing.Point(225, 89);
            this.inputTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.inputTextBox2.Name = "inputTextBox2";
            this.inputTextBox2.Size = new System.Drawing.Size(132, 22);
            this.inputTextBox2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter Second Number";
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(204, 246);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(161, 28);
            this.closeBtn.TabIndex = 16;
            this.closeBtn.Text = "&Close Form";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // diffBtn
            // 
            this.diffBtn.Location = new System.Drawing.Point(24, 246);
            this.diffBtn.Margin = new System.Windows.Forms.Padding(4);
            this.diffBtn.Name = "diffBtn";
            this.diffBtn.Size = new System.Drawing.Size(140, 28);
            this.diffBtn.TabIndex = 15;
            this.diffBtn.Text = "&Difference";
            this.diffBtn.UseVisualStyleBackColor = true;
            this.diffBtn.Click += new System.EventHandler(this.diffBtn_Click);
            // 
            // diffDisplayLabel
            // 
            this.diffDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.diffDisplayLabel.Location = new System.Drawing.Point(24, 154);
            this.diffDisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.diffDisplayLabel.Name = "diffDisplayLabel";
            this.diffDisplayLabel.Size = new System.Drawing.Size(341, 47);
            this.diffDisplayLabel.TabIndex = 14;
            // 
            // inputTextBox1
            // 
            this.inputTextBox1.Location = new System.Drawing.Point(225, 49);
            this.inputTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.inputTextBox1.Name = "inputTextBox1";
            this.inputTextBox1.Size = new System.Drawing.Size(132, 22);
            this.inputTextBox1.TabIndex = 13;
            this.inputTextBox1.TextChanged += new System.EventHandler(this.inputTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter First Number";
            // 
            // Form5
            // 
            this.AcceptButton = this.diffBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.inputTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.diffBtn);
            this.Controls.Add(this.diffDisplayLabel);
            this.Controls.Add(this.inputTextBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Difference of Two Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button diffBtn;
        private System.Windows.Forms.Label diffDisplayLabel;
        private System.Windows.Forms.TextBox inputTextBox1;
        private System.Windows.Forms.Label label1;

    }
}